namespace ServerTestTool
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonCon1 = new System.Windows.Forms.Button();
            this.buttonConCount = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxConCount = new System.Windows.Forms.TextBox();
            this.buttonCon100 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSend1 = new System.Windows.Forms.Button();
            this.buttonSendCount = new System.Windows.Forms.Button();
            this.buttonSendLoop = new System.Windows.Forms.Button();
            this.textBoxSendCount = new System.Windows.Forms.TextBox();
            this.labelSendCount = new System.Windows.Forms.Label();
            this.labelRecvCount = new System.Windows.Forms.Label();
            this.labelSumCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timerControlsUpdate = new System.Windows.Forms.Timer(this.components);
            this.labelConCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInitEndPoint = new System.Windows.Forms.Button();
            this.buttonSetBuffer = new System.Windows.Forms.Button();
            this.textBoxBufferText = new System.Windows.Forms.TextBox();
            this.timerSendData = new System.Windows.Forms.Timer(this.components);
            this.labelSumCountAll = new System.Windows.Forms.Label();
            this.labelRecvCountAll = new System.Windows.Forms.Label();
            this.labelSendCountAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCon1
            // 
            this.buttonCon1.Location = new System.Drawing.Point(12, 41);
            this.buttonCon1.Name = "buttonCon1";
            this.buttonCon1.Size = new System.Drawing.Size(75, 23);
            this.buttonCon1.TabIndex = 1;
            this.buttonCon1.Text = "1명 연결";
            this.buttonCon1.UseVisualStyleBackColor = true;
            this.buttonCon1.Click += new System.EventHandler(this.buttonCon1_Click);
            // 
            // buttonConCount
            // 
            this.buttonConCount.Location = new System.Drawing.Point(174, 41);
            this.buttonConCount.Name = "buttonConCount";
            this.buttonConCount.Size = new System.Drawing.Size(75, 23);
            this.buttonConCount.TabIndex = 2;
            this.buttonConCount.Text = "n명 연결";
            this.buttonConCount.UseVisualStyleBackColor = true;
            this.buttonConCount.Click += new System.EventHandler(this.buttonConCount_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(54, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(114, 21);
            this.textBoxIP.TabIndex = 3;
            this.textBoxIP.Text = "127.0.0.1";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(174, 12);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(75, 21);
            this.textBoxPort.TabIndex = 4;
            this.textBoxPort.Text = "3000";
            // 
            // textBoxConCount
            // 
            this.textBoxConCount.Location = new System.Drawing.Point(255, 42);
            this.textBoxConCount.Name = "textBoxConCount";
            this.textBoxConCount.Size = new System.Drawing.Size(57, 21);
            this.textBoxConCount.TabIndex = 5;
            this.textBoxConCount.Text = "1000";
            // 
            // buttonCon100
            // 
            this.buttonCon100.Location = new System.Drawing.Point(93, 41);
            this.buttonCon100.Name = "buttonCon100";
            this.buttonCon100.Size = new System.Drawing.Size(75, 23);
            this.buttonCon100.TabIndex = 0;
            this.buttonCon100.Text = "100명 연결";
            this.buttonCon100.UseVisualStyleBackColor = true;
            this.buttonCon100.Click += new System.EventHandler(this.buttonCon100_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "전송 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "받음 :";
            // 
            // buttonSend1
            // 
            this.buttonSend1.Location = new System.Drawing.Point(12, 68);
            this.buttonSend1.Name = "buttonSend1";
            this.buttonSend1.Size = new System.Drawing.Size(75, 23);
            this.buttonSend1.TabIndex = 9;
            this.buttonSend1.Text = "1개 전송";
            this.buttonSend1.UseVisualStyleBackColor = true;
            this.buttonSend1.Click += new System.EventHandler(this.buttonSend1_Click);
            // 
            // buttonSendCount
            // 
            this.buttonSendCount.Location = new System.Drawing.Point(93, 68);
            this.buttonSendCount.Name = "buttonSendCount";
            this.buttonSendCount.Size = new System.Drawing.Size(75, 23);
            this.buttonSendCount.TabIndex = 10;
            this.buttonSendCount.Text = "n 개 전송";
            this.buttonSendCount.UseVisualStyleBackColor = true;
            this.buttonSendCount.Click += new System.EventHandler(this.buttonSendCount_Click);
            // 
            // buttonSendLoop
            // 
            this.buttonSendLoop.Location = new System.Drawing.Point(174, 68);
            this.buttonSendLoop.Name = "buttonSendLoop";
            this.buttonSendLoop.Size = new System.Drawing.Size(75, 23);
            this.buttonSendLoop.TabIndex = 11;
            this.buttonSendLoop.Text = "n 개 반복";
            this.buttonSendLoop.UseVisualStyleBackColor = true;
            this.buttonSendLoop.Click += new System.EventHandler(this.buttonSendLoop_Click);
            // 
            // textBoxSendCount
            // 
            this.textBoxSendCount.Location = new System.Drawing.Point(255, 69);
            this.textBoxSendCount.Name = "textBoxSendCount";
            this.textBoxSendCount.Size = new System.Drawing.Size(57, 21);
            this.textBoxSendCount.TabIndex = 12;
            this.textBoxSendCount.Text = "100";
            // 
            // labelSendCount
            // 
            this.labelSendCount.AutoSize = true;
            this.labelSendCount.Location = new System.Drawing.Point(64, 130);
            this.labelSendCount.Name = "labelSendCount";
            this.labelSendCount.Size = new System.Drawing.Size(61, 12);
            this.labelSendCount.TabIndex = 13;
            this.labelSendCount.Text = "10,000,000";
            // 
            // labelRecvCount
            // 
            this.labelRecvCount.AutoSize = true;
            this.labelRecvCount.Location = new System.Drawing.Point(64, 161);
            this.labelRecvCount.Name = "labelRecvCount";
            this.labelRecvCount.Size = new System.Drawing.Size(61, 12);
            this.labelRecvCount.TabIndex = 14;
            this.labelRecvCount.Text = "10,000,000";
            // 
            // labelSumCount
            // 
            this.labelSumCount.AutoSize = true;
            this.labelSumCount.Location = new System.Drawing.Point(64, 197);
            this.labelSumCount.Name = "labelSumCount";
            this.labelSumCount.Size = new System.Drawing.Size(61, 12);
            this.labelSumCount.TabIndex = 16;
            this.labelSumCount.Text = "10,000,000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "합계 :";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(9, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 1);
            this.label8.TabIndex = 17;
            // 
            // timerControlsUpdate
            // 
            this.timerControlsUpdate.Enabled = true;
            this.timerControlsUpdate.Interval = 1000;
            this.timerControlsUpdate.Tick += new System.EventHandler(this.timerControlsUpdate_Tick);
            // 
            // labelConCount
            // 
            this.labelConCount.AutoSize = true;
            this.labelConCount.Location = new System.Drawing.Point(64, 101);
            this.labelConCount.Name = "labelConCount";
            this.labelConCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelConCount.Size = new System.Drawing.Size(29, 12);
            this.labelConCount.TabIndex = 21;
            this.labelConCount.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "연결 : ";
            // 
            // buttonInitEndPoint
            // 
            this.buttonInitEndPoint.Location = new System.Drawing.Point(255, 11);
            this.buttonInitEndPoint.Name = "buttonInitEndPoint";
            this.buttonInitEndPoint.Size = new System.Drawing.Size(57, 23);
            this.buttonInitEndPoint.TabIndex = 22;
            this.buttonInitEndPoint.Text = "접속";
            this.buttonInitEndPoint.UseVisualStyleBackColor = true;
            this.buttonInitEndPoint.Click += new System.EventHandler(this.buttonInitEndPoint_Click);
            // 
            // buttonSetBuffer
            // 
            this.buttonSetBuffer.Location = new System.Drawing.Point(237, 218);
            this.buttonSetBuffer.Name = "buttonSetBuffer";
            this.buttonSetBuffer.Size = new System.Drawing.Size(75, 23);
            this.buttonSetBuffer.TabIndex = 23;
            this.buttonSetBuffer.Text = "버퍼설정";
            this.buttonSetBuffer.UseVisualStyleBackColor = true;
            this.buttonSetBuffer.Click += new System.EventHandler(this.buttonSetBuffer_Click);
            // 
            // textBoxBufferText
            // 
            this.textBoxBufferText.Location = new System.Drawing.Point(11, 219);
            this.textBoxBufferText.Multiline = true;
            this.textBoxBufferText.Name = "textBoxBufferText";
            this.textBoxBufferText.Size = new System.Drawing.Size(220, 89);
            this.textBoxBufferText.TabIndex = 24;
            this.textBoxBufferText.Text = "08 00 00 00 02 00 20 00";
            // 
            // timerSendData
            // 
            this.timerSendData.Tick += new System.EventHandler(this.timerSendData_Tick);
            // 
            // labelSumCountAll
            // 
            this.labelSumCountAll.AutoSize = true;
            this.labelSumCountAll.Location = new System.Drawing.Point(177, 197);
            this.labelSumCountAll.Name = "labelSumCountAll";
            this.labelSumCountAll.Size = new System.Drawing.Size(61, 12);
            this.labelSumCountAll.TabIndex = 27;
            this.labelSumCountAll.Text = "10,000,000";
            // 
            // labelRecvCountAll
            // 
            this.labelRecvCountAll.AutoSize = true;
            this.labelRecvCountAll.Location = new System.Drawing.Point(177, 161);
            this.labelRecvCountAll.Name = "labelRecvCountAll";
            this.labelRecvCountAll.Size = new System.Drawing.Size(61, 12);
            this.labelRecvCountAll.TabIndex = 26;
            this.labelRecvCountAll.Text = "10,000,000";
            // 
            // labelSendCountAll
            // 
            this.labelSendCountAll.AutoSize = true;
            this.labelSendCountAll.Location = new System.Drawing.Point(177, 130);
            this.labelSendCountAll.Name = "labelSendCountAll";
            this.labelSendCountAll.Size = new System.Drawing.Size(61, 12);
            this.labelSendCountAll.TabIndex = 25;
            this.labelSendCountAll.Text = "10,000,000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 316);
            this.Controls.Add(this.labelSumCountAll);
            this.Controls.Add(this.labelRecvCountAll);
            this.Controls.Add(this.labelSendCountAll);
            this.Controls.Add(this.textBoxBufferText);
            this.Controls.Add(this.buttonSetBuffer);
            this.Controls.Add(this.buttonInitEndPoint);
            this.Controls.Add(this.labelConCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSumCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelRecvCount);
            this.Controls.Add(this.labelSendCount);
            this.Controls.Add(this.textBoxSendCount);
            this.Controls.Add(this.buttonSendLoop);
            this.Controls.Add(this.buttonSendCount);
            this.Controls.Add(this.buttonSend1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConCount);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.buttonConCount);
            this.Controls.Add(this.buttonCon1);
            this.Controls.Add(this.buttonCon100);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCon1;
        private System.Windows.Forms.Button buttonConCount;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxConCount;
        private System.Windows.Forms.Button buttonCon100;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSend1;
        private System.Windows.Forms.Button buttonSendCount;
        private System.Windows.Forms.Button buttonSendLoop;
        private System.Windows.Forms.TextBox textBoxSendCount;
        private System.Windows.Forms.Label labelSendCount;
        private System.Windows.Forms.Label labelRecvCount;
        private System.Windows.Forms.Label labelSumCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerControlsUpdate;
        private System.Windows.Forms.Label labelConCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInitEndPoint;
        private System.Windows.Forms.Button buttonSetBuffer;
        private System.Windows.Forms.TextBox textBoxBufferText;
        private System.Windows.Forms.Timer timerSendData;
        private System.Windows.Forms.Label labelSumCountAll;
        private System.Windows.Forms.Label labelRecvCountAll;
        private System.Windows.Forms.Label labelSendCountAll;
    }
}

