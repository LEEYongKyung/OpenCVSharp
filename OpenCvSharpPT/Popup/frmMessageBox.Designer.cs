namespace OpenCvSharpPT.Popup
{
    partial class frmMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.tmrVisible = new System.Windows.Forms.Timer(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 255);
            this.panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("맑은 고딕", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblMessage.Size = new System.Drawing.Size(620, 255);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            this.lblMessage.MouseEnter += new System.EventHandler(this.pbxIcon_MouseEnter);
            this.lblMessage.MouseLeave += new System.EventHandler(this.pbxIcon_MouseLeave);
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(51, 5);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(515, 40);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "Error";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCaption.Click += new System.EventHandler(this.lblMessage_Click);
            this.lblCaption.MouseEnter += new System.EventHandler(this.pbxIcon_MouseEnter);
            this.lblCaption.MouseLeave += new System.EventHandler(this.pbxIcon_MouseLeave);
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Location = new System.Drawing.Point(5, 5);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(40, 40);
            this.pbxIcon.TabIndex = 2;
            this.pbxIcon.TabStop = false;
            this.pbxIcon.Click += new System.EventHandler(this.lblMessage_Click);
            this.pbxIcon.MouseEnter += new System.EventHandler(this.pbxIcon_MouseEnter);
            this.pbxIcon.MouseLeave += new System.EventHandler(this.pbxIcon_MouseLeave);
            // 
            // tmrVisible
            // 
            this.tmrVisible.Interval = 1000;
            this.tmrVisible.Tick += new System.EventHandler(this.tmrVisible_Tick);
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(572, 5);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(48, 40);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "5";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblCount.Visible = false;
            this.lblCount.Click += new System.EventHandler(this.lblMessage_Click);
            this.lblCount.MouseEnter += new System.EventHandler(this.pbxIcon_MouseEnter);
            this.lblCount.MouseLeave += new System.EventHandler(this.pbxIcon_MouseLeave);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(630, 310);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.pbxIcon);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageBox";
            this.Padding = new System.Windows.Forms.Padding(5, 50, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessageBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            this.Click += new System.EventHandler(this.lblMessage_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMessageBox_KeyDown);
            this.MouseEnter += new System.EventHandler(this.pbxIcon_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.pbxIcon_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Timer tmrVisible;
        private System.Windows.Forms.Label lblCount;
    }
}