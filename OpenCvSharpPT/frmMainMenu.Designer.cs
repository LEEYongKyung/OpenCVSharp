namespace OpenCvSharpPT
{
    partial class frmMainMenu
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
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceSrcOutput = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceCameraOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLoadImg = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(260, 46);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1538, 1153);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceSrcOutput,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 46);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 1153);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceSrcOutput
            // 
            this.aceSrcOutput.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceCameraOut,
            this.aceLoadImg});
            this.aceSrcOutput.Expanded = true;
            this.aceSrcOutput.Name = "aceSrcOutput";
            this.aceSrcOutput.Text = "SrcOutput";
            // 
            // aceCameraOut
            // 
            this.aceCameraOut.Name = "aceCameraOut";
            this.aceCameraOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceCameraOut.Text = "CameraOut";
            this.aceCameraOut.Click += new System.EventHandler(this.aceCameraOut_Click);
            // 
            // aceLoadImg
            // 
            this.aceLoadImg.Name = "aceLoadImg";
            this.aceLoadImg.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLoadImg.Text = "LoadImg";
            this.aceLoadImg.Click += new System.EventHandler(this.aceLoadImg_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1798, 46);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Element1";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 1199);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmMainMenu";
            this.NavigationControl = this.accordionControl1;
            this.Text = "frmMainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSrcOutput;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceCameraOut;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLoadImg;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    }
}