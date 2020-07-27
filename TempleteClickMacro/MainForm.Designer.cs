namespace TempleteClickMacro
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcessListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFileSearch = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnProcessUpdate = new System.Windows.Forms.Button();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.templeteOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.capturePictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.thresholdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clickLabel = new System.Windows.Forms.Label();
            this.monitorCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.capturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessListBox
            // 
            this.ProcessListBox.FormattingEnabled = true;
            this.ProcessListBox.ItemHeight = 12;
            this.ProcessListBox.Location = new System.Drawing.Point(27, 26);
            this.ProcessListBox.Name = "ProcessListBox";
            this.ProcessListBox.Size = new System.Drawing.Size(556, 244);
            this.ProcessListBox.Sorted = true;
            this.ProcessListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "템플릿 파일경로";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "템플릿 매칭 타이머";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "초";
            // 
            // btnFileSearch
            // 
            this.btnFileSearch.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFileSearch.Location = new System.Drawing.Point(535, 417);
            this.btnFileSearch.Name = "btnFileSearch";
            this.btnFileSearch.Size = new System.Drawing.Size(48, 24);
            this.btnFileSearch.TabIndex = 4;
            this.btnFileSearch.Text = "찾기";
            this.btnFileSearch.UseVisualStyleBackColor = true;
            this.btnFileSearch.Click += new System.EventHandler(this.btnFileSearch_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxPath.Location = new System.Drawing.Point(25, 419);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(504, 22);
            this.textBoxPath.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(25, 604);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(296, 43);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnProcessUpdate
            // 
            this.btnProcessUpdate.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProcessUpdate.Location = new System.Drawing.Point(27, 296);
            this.btnProcessUpdate.Name = "btnProcessUpdate";
            this.btnProcessUpdate.Size = new System.Drawing.Size(556, 43);
            this.btnProcessUpdate.TabIndex = 8;
            this.btnProcessUpdate.Text = "프로세스 목록 갱신";
            this.btnProcessUpdate.UseVisualStyleBackColor = true;
            this.btnProcessUpdate.Click += new System.EventHandler(this.btnProcessUpdate_Click);
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(25, 544);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(76, 21);
            this.textBoxTimer.TabIndex = 6;
            this.textBoxTimer.Text = "60";
            // 
            // templeteOpenFileDialog
            // 
            this.templeteOpenFileDialog.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(618, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "최근 캡쳐화면";
            // 
            // CapturePictureBox
            // 
            this.capturePictureBox.Location = new System.Drawing.Point(622, 83);
            this.capturePictureBox.Name = "CapturePictureBox";
            this.capturePictureBox.Size = new System.Drawing.Size(614, 358);
            this.capturePictureBox.TabIndex = 10;
            this.capturePictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(618, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "최근 템플릿 매칭 결과";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultLabel.Location = new System.Drawing.Point(634, 546);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(114, 19);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "시작해주세요...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(306, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "요구 일치율";
            // 
            // thresholdTextBox
            // 
            this.thresholdTextBox.Location = new System.Drawing.Point(310, 544);
            this.thresholdTextBox.Name = "thresholdTextBox";
            this.thresholdTextBox.Size = new System.Drawing.Size(29, 21);
            this.thresholdTextBox.TabIndex = 15;
            this.thresholdTextBox.Text = "99";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "%";
            // 
            // clickLabel
            // 
            this.clickLabel.AutoSize = true;
            this.clickLabel.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clickLabel.Location = new System.Drawing.Point(891, 624);
            this.clickLabel.Name = "clickLabel";
            this.clickLabel.Size = new System.Drawing.Size(323, 23);
            this.clickLabel.TabIndex = 16;
            this.clickLabel.Text = "매크로 시작 이후 총 클릭한 횟수 :  0";
            // 
            // MonitorCheckBox
            // 
            this.monitorCheckBox.AutoSize = true;
            this.monitorCheckBox.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monitorCheckBox.Location = new System.Drawing.Point(409, 373);
            this.monitorCheckBox.Name = "MonitorCheckBox";
            this.monitorCheckBox.Size = new System.Drawing.Size(174, 27);
            this.monitorCheckBox.TabIndex = 17;
            this.monitorCheckBox.Text = "모니터 전체 대상";
            this.monitorCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 698);
            this.Controls.Add(this.monitorCheckBox);
            this.Controls.Add(this.clickLabel);
            this.Controls.Add(this.thresholdTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.capturePictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProcessUpdate);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.btnFileSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessListBox);
            this.Name = "MainForm";
            this.Text = "템플릿 매칭 자동클릭 매크로";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProcessListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFileSearch;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnProcessUpdate;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.OpenFileDialog templeteOpenFileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox capturePictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox thresholdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label clickLabel;
        private System.Windows.Forms.CheckBox monitorCheckBox;
    }
}

