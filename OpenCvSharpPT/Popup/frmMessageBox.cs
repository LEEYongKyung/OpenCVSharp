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
    public partial class frmMessageBox : Form
    {
        #region Variable

        private int mintTmrCount = 0;      // 밀리초
        private int mintTmrInterval = 100; // 밀리초

        private uMsgBox.MessageBoxType mMessageBoxType = uMsgBox.MessageBoxType.Information;
        private string mstrCaption = "";
        private string mstrMessage = "Message";
        private int mintVisibleTime = 5;   // 초

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

        public int VisibleTime
        {
            get { return mintVisibleTime; }
            set 
            {
                if (value < 1)                
                    mintVisibleTime = -1;                
                else
                    mintVisibleTime = value; 
            }
        }

        public uMsgBox.MessageBoxType Type
        {
            get { return mMessageBoxType; }
            set { mMessageBoxType = value; }        
        }

        private string Caption
        {
            get { return mstrCaption; }
            set { mstrCaption = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// 생성자
        /// </summary>
        public frmMessageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 생성자
        /// </summary>
        public frmMessageBox(uMsgBox.MessageBoxType messageType, string strCaption, string strMessage, int intVisibleTime)
        {
            Type = messageType;
            TitleCaption = strCaption;
            Message = strMessage;
            VisibleTime = intVisibleTime;

            InitializeComponent();
        }

        #endregion

        #region Event

        /// <summary>
        /// 폼 로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            switch (Type)
            {
                case uMsgBox.MessageBoxType.Information:
                    if (string.IsNullOrEmpty(TitleCaption))
                        TitleCaption = "Information";                    
                    this.BackColor = Color.FromArgb(3, 160, 3);                    
                    lblMessage.ForeColor = Color.FromArgb(3, 160, 3);
                    break;

                case uMsgBox.MessageBoxType.Error:
                    if (string.IsNullOrEmpty(TitleCaption))
                        TitleCaption = "Error";
                    this.BackColor = Color.FromArgb(254, 80, 60);                    
                    lblMessage.ForeColor = Color.FromArgb(254, 80, 60);
                    break;
            }

            //pbxIcon.Image =
            lblCaption.Text = TitleCaption;
            lblMessage.Text = Message;

            if (VisibleTime > 0)
            {
                lblCount.Visible = true;
                lblCount.Text = VisibleTime.ToString();
            }

            this.Opacity = 1;
            this.Visible = true;

            if (VisibleTime > 0)
            {
                tmrVisible.Interval = 100;
                tmrVisible.Enabled = true;
            }
        }        

        /// <summary>
        /// 타이머틱 (마지막 0.5초는 투명도처리)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrVisible_Tick(object sender, EventArgs e)
        {
            try
            {
                mintTmrCount = mintTmrCount + mintTmrInterval;
                
                if ((mintTmrCount) % 1000 == 0)
                {
                    lblCount.Text = (((mintVisibleTime * 1000) - mintTmrCount) / 1000).ToString();
                }

                if (mintVisibleTime * 1000 - mintTmrCount < 500)
                {
                    if (this.Opacity > 0)
                    {
                        this.Opacity -= 0.2;
                    }
                }

                if (mintVisibleTime * 1000 < mintTmrCount)
                {
                    tmrVisible.Enabled = false;

                    this.Visible = false;
                    this.Close();
                }
            }
            catch { }
        }

        /// <summary>
        /// 메세지 클릭시 화면 닫음
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMessage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pbxIcon_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pbxIcon_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        #endregion

        #region Method

        #endregion
    }
}
