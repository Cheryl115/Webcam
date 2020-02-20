namespace beauty
{
    partial class Webcam
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera:";
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(57, 6);
            this.cboCamera.Margin = new System.Windows.Forms.Padding(2);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(189, 20);
            this.cboCamera.TabIndex = 1;
            
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(10, 27);
            this.pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(235, 201);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(93, 232);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(50, 31);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "&Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // Webcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 274);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Webcam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Webcam_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button BtnStart;
    }
}

