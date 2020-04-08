using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCvSharpPT.Util;

namespace OpenCvSharpPT.Popup
{
    public partial class frmDialogBox : Form
    {
        #region Variable

        private uMsgBox.DialogBoxType mDialogBoxType = uMsgBox.DialogBoxType.YesNo;
        private string mstrCaption = "";
        private string mstrMessage = "QuestionMessage";
        private string mstrButton1 = "";
        private string mstrButton2 = "";

        public string TitleCaption
        {            
            get { return mstrCaption;  }
            set { mstrCaption = value; }
        }

        public string Message
        {
            get { return mstrMessage; }
            set { mstrMessage = value; }
        }

        public uMsgBox.DialogBoxType Type
        {
            get { return mDialogBoxType; }
            set { mDialogBoxType = value; }
        }

        private string Caption
        {
            get { return mstrCaption; }
            set { mstrCaption = value; }
        }

        private string ButtonCaption1
        {
            get { return mstrButton1; }
            set { mstrButton1 = value; }
        }

        private string ButtonCaption2
        {
            get { return mstrButton2; }
            set { mstrButton2 = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// 생성자
        /// </summary>
        public frmDialogBox()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// 생성자
        /// </summary>
        public frmDialogBox(uMsgBox.DialogBoxType dialogType, string strCaption, string strMessage)
        {
            Type = dialogType;
            TitleCaption = strCaption;
            Message = strMessage;

            InitializeComponent();
        }

        /// <summary>
        /// 생성자
        /// </summary>
        public frmDialogBox(uMsgBox.DialogBoxType dialogType, string strCaption, string strMessage, string strButton1, string strButton2)
        {
            Type = dialogType;
            TitleCaption = strCaption;
            Message = strMessage;
            ButtonCaption1 = strButton1;
            ButtonCaption1 = strButton2;

            InitializeComponent();
        }

        #endregion

        #region Event

        private void frmDialogBox_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleCaption))
                TitleCaption = "Confirm";

            switch (Type)
            {
                case uMsgBox.DialogBoxType.YesNo:
                    if (string.IsNullOrEmpty(ButtonCaption1))
                        btnYes.Text = "Yes";
                    if (string.IsNullOrEmpty(ButtonCaption2))
                        btnNo.Text = "No";
                    break;

                case uMsgBox.DialogBoxType.OKCancel:
                    if (string.IsNullOrEmpty(ButtonCaption1))
                        btnYes.Text = "OK";
                    if (string.IsNullOrEmpty(ButtonCaption2))
                        btnNo.Text = "Cancel";
                    break;

                case uMsgBox.DialogBoxType.OK:
                    if (string.IsNullOrEmpty(ButtonCaption1))
                        btnYes.Text = "OK";
                    if (string.IsNullOrEmpty(ButtonCaption2))
                        btnNo.Text = "";
                    btnYes.Location = new Point((pnlMain.Width - btnYes.Width) / 2, btnYes.Top);
                    btnNo.Visible = false;
                    break;
            }

            //pbxIcon.Image =
            lblCaption.Text = TitleCaption;
            lblMessage.Text = Message;

            this.Visible = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                case uMsgBox.DialogBoxType.YesNo:
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    break;

                case uMsgBox.DialogBoxType.OKCancel:
                case uMsgBox.DialogBoxType.OK:
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    break;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                case uMsgBox.DialogBoxType.YesNo:
                    this.DialogResult = System.Windows.Forms.DialogResult.No;
                    break;

                case uMsgBox.DialogBoxType.OKCancel:
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

        #endregion

        #region Method

        #endregion
    }
}
