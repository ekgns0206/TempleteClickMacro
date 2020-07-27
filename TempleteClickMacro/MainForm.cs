using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using OpenCvSharp;
using OpenCvSharp.Extensions;



namespace TempleteClickMacro
{
    public partial class MainForm : Form
    {

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowRgn(IntPtr hWnd, IntPtr hRgn);
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private Timer timer = new Timer();
        private IntPtr processhandler;
        private int clickNum;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Tick += Timer_Tick;
            capturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            clickNum = 0;
            textBoxPath.Text = "C:\\Users\\dahun\\Desktop\\" + "templete.png";
        }

        private void btnProcessUpdate_Click(object sender, EventArgs e)
        {
            ProcessListBox.Items.Clear();
            Process[] processList = Process.GetProcesses();

            int length = processList.Length;

            for (int i = 0; i < length; i++)
            {
                if (processList[i].MainWindowTitle == "") continue;
                ProcessListBox.Items.Add(processList[i].MainWindowTitle);

            }
        }

        private void btnFileSearch_Click(object sender, EventArgs e)
        {
            textBoxPath.Clear();
            templeteOpenFileDialog.InitialDirectory = "C:\\";
            if (templeteOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = templeteOpenFileDialog.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProcessListBox.SelectedItem == null)
                {
                    MessageBox.Show("선택한 프로세스가 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                processhandler = FindWindow(null, ProcessListBox.SelectedItem.ToString());
            }
            catch (IndexOutOfRangeException ee)
            {
                MessageBox.Show("프로세스 핸들러를 얻을 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (btnStart.Text == "시작")
            {
                //timer = new Timer();
                timer.Interval = Int32.Parse(textBoxTimer.Text) * 1000;
                Timer_Tick(sender, e);
                timer.Start();
                btnStart.Text = "정지";
            }
            else
            {
                timer.Stop();
                clickNum = 0;
                clickLabel.Text = "매크로 시작 이후 총 클릭한 횟수 : 0";
                btnStart.Text = "시작";
            }

        }

        public Bitmap CaptureWindow(IntPtr hwnd)
        {
            Rectangle rc = Rectangle.Empty;
            Graphics gfxWin = Graphics.FromHwnd(hwnd);
            rc = Rectangle.Round(gfxWin.VisibleClipBounds);

            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format32bppArgb);

            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();
            bool succeeded = PrintWindow(hwnd, hdcBitmap, 0x02);

            gfxBmp.ReleaseHdc(hdcBitmap);
            if (!succeeded)
            {
                gfxBmp.FillRectangle(
                    new SolidBrush(Color.Gray),
                    new Rectangle(System.Drawing.Point.Empty, bmp.Size));
            }

            IntPtr hRgn = CreateRectRgn(0, 0, 0, 0);
            GetWindowRgn(hwnd, hRgn);
            Region region = Region.FromHrgn(hRgn);
            if (!region.IsEmpty(gfxBmp))
            {
                gfxBmp.ExcludeClip(region);
                gfxBmp.Clear(Color.Transparent);
            }
            gfxBmp.Dispose();

            return bmp;
        }

        public bool TemplitMatchingClick(IplImage src, IplImage temp)
        {
            IplImage match = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage templit = new IplImage(temp.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, match, ColorConversion.BgrToGray);
            Cv.CvtColor(temp, templit, ColorConversion.BgrToGray);
            IplImage tm = new IplImage(new CvSize(match.Size.Width - templit.Size.Width + 1, match.Size.Height - templit.Size.Height + 1), BitDepth.F32, 1);

            CvPoint minloc, maxloc;
            Double minval, maxval;

            Cv.MatchTemplate(match, templit, tm, MatchTemplateMethod.SqDiffNormed);

            Cv.MinMaxLoc(tm, out minval, out maxval, out minloc, out maxloc);

            double threshold = Convert.ToDouble(string.Format("{0:f2}", (1 - minval) * 100)); // 1-minval = 유사도 // minval = 오차

            Debug.WriteLine("matching " + threshold.ToString() + "%");

            resultLabel.Text = "[ 검사한 시간 : " + System.DateTime.Now.ToString("MM/dd hh:mm:ss") + " ]\n[ 일치율 : " + threshold + "% ]\n";

            if (threshold >= Double.Parse(thresholdTextBox.Text))
            {
                if (monitorCheckBox.Checked)
                {
                    Cursor.Position = new Point((minloc.X + (templit.Width / 2)), (minloc.Y + (templit.Height / 2)));
                    mouse_event(0x0002, 0, 0, 0, 0);    // 마우스 down
                    mouse_event(0x0004, 0, 0, 0, 0);    // 마우스 up
                }
                else
                {
                    IntPtr lParam = (IntPtr)((minloc.X + (templit.Width / 2) & 0xFFFF) | ((minloc.Y + (templit.Height / 2) & 0xFFFF) << 16));
                    const uint WM_MBUTTONDOWN = 0x0201;
                    const uint WM_MBUTTONUP = 0x0202;

                    PostMessage(processhandler, WM_MBUTTONDOWN, IntPtr.Zero, lParam);
                    PostMessage(processhandler, WM_MBUTTONUP, IntPtr.Zero, lParam);
                }

                clickLabel.Text = "매크로 시작 이후 총 클릭한 횟수 : " + (++clickNum);
                return true;
            }

            return false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Bitmap captureImage;
            if (monitorCheckBox.Checked)
            {
                captureImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics g = Graphics.FromImage(captureImage);
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
                g.Dispose();
                g = null;
            }
            else
                captureImage = CaptureWindow(processhandler);
            capturePictureBox.Image = captureImage;
            IplImage temp = new IplImage(textBoxPath.Text, LoadMode.AnyColor);
            IplImage src = captureImage.ToIplImage();
            if (TemplitMatchingClick(src, temp))
            {
                resultLabel.Text += " 찾아서 클릭했어요!";
            }
            else
            {
                resultLabel.Text += " 못 찾았어요!";
            }
        }

    }
}
