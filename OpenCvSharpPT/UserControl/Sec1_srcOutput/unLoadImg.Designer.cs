namespace OpenCvSharpPT.UserControl.Sec1_srcOutput
{
    partial class unLoadImg
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.btnLoadImg = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(65, 126);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(600, 600);
            this.pictureBoxIpl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Location = new System.Drawing.Point(553, 49);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(112, 34);
            this.btnLoadImg.TabIndex = 1;
            this.btnLoadImg.Text = "OpenImg";
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(463, 29);
            this.textBox1.TabIndex = 2;
            // 
            // unLoadImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "unLoadImg";
            this.Size = new System.Drawing.Size(1095, 814);
            this.Load += new System.EventHandler(this.unLoadImg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
