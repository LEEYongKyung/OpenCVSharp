using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace OpenCvSharpPT
{
    public partial class frmMainMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void aceCameraOut_Click(object sender, EventArgs e)
        {
            if(!container.Controls.Contains(ucCamera.Instance))
            {
                container.Controls.Add(ucCamera.Instance);
                ucCamera.Instance.Dock = DockStyle.Fill;
                ucCamera.Instance.BringToFront();

            }
            ucCamera.Instance.BringToFront();
        }

        private void aceLoadImg_Click(object sender, EventArgs e)
        {
            if(!container.Controls.Contains(UserControl.Sec1_srcOutput.unLoadImg.Instance))
            {
                container.Controls.Add(UserControl.Sec1_srcOutput.unLoadImg.Instance);
                UserControl.Sec1_srcOutput.unLoadImg.Instance.Dock = DockStyle.Fill;
                UserControl.Sec1_srcOutput.unLoadImg.Instance.BringToFront();

            }
            UserControl.Sec1_srcOutput.unLoadImg.Instance.BringToFront();
        }
    }
}
