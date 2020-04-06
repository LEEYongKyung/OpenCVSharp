using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace OpenCvSharpPT.BaseForm
{
    public partial class frmBaseChild : frmBase
    {
        #region Variable
        private int minBtnIdx = 0;

        #endregion

        #region Constructor
        public frmBaseChild()
        {
            InitializeComponent();
        }

        #endregion


        #region Event

        private void frmBaseChild_Load(object sender, EventArgs e)
        {
            InitHeaderButton();
        }

        #endregion

        #region Method
        public void InitHeaderButton()
        {
            pnlButtonArea.Controls.Clear();
            minBtnIdx = 0;
            


        }

        public void HeaderButtonAdd(string name, string text, int imgIdx = -1)
        {
            minBtnIdx++;
            SimpleButton btn = new SimpleButton();
            btn.Font = new Font("굴림체", 9);
            btn.AutoSize = true;
            btn.Padding = new Padding(12, 0, 12, 0);
            btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btn.AllowFocus = false;
            btn.Name = name;
            btn.Text = text;
            btn.Cursor = Cursors.Hand;
            if (minBtnIdx + 4 <= 12)
            {
                btn.ToolTipTitle = "단축키";
                btn.ToolTip = "F" + (minBtnIdx + 4).ToString();
            }
            btn.Click += new EventHandler(headerButton_Click);

            if (imgIdx >= 0)
            {
                btn.ImageOptions.ImageList = imageCollection1;
                btn.ImageOptions.ImageIndex = imgIdx;
            }
            pnlButtonArea.Controls.Add(btn);
            btn.BringToFront();

        }

        public virtual void headerButton_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private void frmBaseChild_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                case Keys.F6:
                case Keys.F7:
                case Keys.F8:
                case Keys.F9:
                case Keys.F10:
                case Keys.F11:
                case Keys.F12:
                    foreach (System.Windows.Forms.Control ctl in pnlButtonArea.Controls)
                    {
                        if (ctl.GetType() == typeof(SimpleButton))
                        {
                            SimpleButton btn = (SimpleButton)ctl;
                            if (btn.ToolTip == e.KeyCode.ToString())
                            {
                                headerButton_Click(btn, null);
                            }

                        }

                    }
                    break;
            }

           }
        }
}