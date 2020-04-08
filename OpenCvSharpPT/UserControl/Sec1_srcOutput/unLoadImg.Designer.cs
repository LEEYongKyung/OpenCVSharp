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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSymmetry = new DevExpress.XtraEditors.SimpleButton();
            this.lueSymmetry = new DevExpress.XtraEditors.LookUpEdit();
            this.gpSrc = new System.Windows.Forms.GroupBox();
            this.pictureBoxIpl2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.gpOut = new System.Windows.Forms.GroupBox();
            this.gcRotate = new DevExpress.XtraEditors.GroupControl();
            this.btnRotate = new DevExpress.XtraEditors.SimpleButton();
            this.txtRotateAng = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSymmetry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRotate)).BeginInit();
            this.gcRotate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRotateAng.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIpl1.Location = new System.Drawing.Point(65, 126);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(390, 279);
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSymmetry);
            this.groupControl1.Controls.Add(this.lueSymmetry);
            this.groupControl1.Location = new System.Drawing.Point(487, 115);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(244, 74);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "대칭";
            // 
            // btnSymmetry
            // 
            this.btnSymmetry.Location = new System.Drawing.Point(147, 33);
            this.btnSymmetry.Name = "btnSymmetry";
            this.btnSymmetry.Size = new System.Drawing.Size(92, 34);
            this.btnSymmetry.TabIndex = 1;
            this.btnSymmetry.Text = "대칭";
            this.btnSymmetry.Click += new System.EventHandler(this.btnSymmetry_Click);
            // 
            // lueSymmetry
            // 
            this.lueSymmetry.Location = new System.Drawing.Point(5, 37);
            this.lueSymmetry.Name = "lueSymmetry";
            this.lueSymmetry.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lueSymmetry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSymmetry.Size = new System.Drawing.Size(136, 30);
            this.lueSymmetry.TabIndex = 0;
            // 
            // gpSrc
            // 
            this.gpSrc.Location = new System.Drawing.Point(55, 101);
            this.gpSrc.Name = "gpSrc";
            this.gpSrc.Size = new System.Drawing.Size(426, 319);
            this.gpSrc.TabIndex = 4;
            this.gpSrc.TabStop = false;
            this.gpSrc.Text = "Src이미지";
            // 
            // pictureBoxIpl2
            // 
            this.pictureBoxIpl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIpl2.Location = new System.Drawing.Point(65, 451);
            this.pictureBoxIpl2.Name = "pictureBoxIpl2";
            this.pictureBoxIpl2.Size = new System.Drawing.Size(390, 279);
            this.pictureBoxIpl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl2.TabIndex = 5;
            this.pictureBoxIpl2.TabStop = false;
            // 
            // gpOut
            // 
            this.gpOut.Location = new System.Drawing.Point(55, 426);
            this.gpOut.Name = "gpOut";
            this.gpOut.Size = new System.Drawing.Size(426, 319);
            this.gpOut.TabIndex = 6;
            this.gpOut.TabStop = false;
            this.gpOut.Text = "Src이미지";
            // 
            // gcRotate
            // 
            this.gcRotate.Controls.Add(this.txtRotateAng);
            this.gcRotate.Controls.Add(this.btnRotate);
            this.gcRotate.Location = new System.Drawing.Point(487, 209);
            this.gcRotate.Name = "gcRotate";
            this.gcRotate.Size = new System.Drawing.Size(244, 74);
            this.gcRotate.TabIndex = 4;
            this.gcRotate.Text = "회전";
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(147, 35);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(92, 34);
            this.btnRotate.TabIndex = 1;
            this.btnRotate.Text = "회전";
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // txtRotateAng
            // 
            this.txtRotateAng.Location = new System.Drawing.Point(0, 38);
            this.txtRotateAng.Name = "txtRotateAng";
            this.txtRotateAng.Size = new System.Drawing.Size(141, 30);
            this.txtRotateAng.TabIndex = 2;
            // 
            // unLoadImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcRotate);
            this.Controls.Add(this.pictureBoxIpl2);
            this.Controls.Add(this.gpOut);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.gpSrc);
            this.Name = "unLoadImg";
            this.Size = new System.Drawing.Size(1369, 986);
            this.Load += new System.EventHandler(this.unLoadImg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueSymmetry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRotate)).EndInit();
            this.gcRotate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRotateAng.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lueSymmetry;
        private DevExpress.XtraEditors.SimpleButton btnSymmetry;
        private System.Windows.Forms.GroupBox gpSrc;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl2;
        private System.Windows.Forms.GroupBox gpOut;
        private DevExpress.XtraEditors.GroupControl gcRotate;
        private DevExpress.XtraEditors.SimpleButton btnRotate;
        private DevExpress.XtraEditors.TextEdit txtRotateAng;
    }
}
