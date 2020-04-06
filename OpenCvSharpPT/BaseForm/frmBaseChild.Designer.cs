namespace OpenCvSharpPT.BaseForm
{
    partial class frmBaseChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseChild));
            this.pnlButtonArea = new DevExpress.Utils.Layout.StackPanel();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtonArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtonArea
            // 
            this.pnlButtonArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtonArea.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonArea.Name = "pnlButtonArea";
            this.pnlButtonArea.Size = new System.Drawing.Size(806, 45);
            this.pnlButtonArea.TabIndex = 0;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "add");
            this.imageCollection1.Images.SetKeyName(1, "cancel");
            this.imageCollection1.Images.SetKeyName(2, "apply");
            this.imageCollection1.Images.SetKeyName(3, "load");
            this.imageCollection1.Images.SetKeyName(4, "save");
            // 
            // frmBaseChild
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 564);
            this.Controls.Add(this.pnlButtonArea);
            this.Name = "frmBaseChild";
            this.Text = "frmBaseChild";
            this.Load += new System.EventHandler(this.frmBaseChild_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseChild_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtonArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel pnlButtonArea;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}