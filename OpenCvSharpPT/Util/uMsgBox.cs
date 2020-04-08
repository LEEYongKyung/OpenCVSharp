using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharpPT.Popup;

namespace OpenCvSharpPT.Util
{
    public class uMsgBox
    {
        public enum DialogBoxType
        {
            YesNo,
            OKCancel,
            OK
        }

        public enum MessageBoxType
        {
            Information,
            Error
        }

        public static DialogResult DialogBoxShow(DialogBoxType Type, string Caption, string Message)
        {
            MessageBoxClose();
            frmDialogBox frmDialog = new frmDialogBox(Type, Caption, Message);
            DialogResult dlg = frmDialog.ShowDialog();
            frmDialog.Dispose();
            return dlg;
        }

        public static DialogResult DialogBoxShow(DialogBoxType Type, string Caption, string Message, string Button1Caption, string Button2Caption)
        {
            MessageBoxClose();
            frmDialogBox frmDialog = new frmDialogBox(Type, Caption, Message, Button1Caption, Button2Caption);
            DialogResult dlg = frmDialog.ShowDialog();
            frmDialog.Dispose();
            return dlg;
        }

        public static void MessageBoxShow(uMsgBox.MessageBoxType Type, string Caption, string Message)
        {
            MessageBoxShow(Type, Caption, Message, -1);
        }

        public static void MessageBoxShow(uMsgBox.MessageBoxType Type, string Caption, string Message, int VisibleTime)
        {
            MessageBoxClose();
            frmMessageBox frmMessage = new frmMessageBox(Type, Caption, Message, VisibleTime);
            frmMessage.TopMost = true;
            frmMessage.Show();
        }

        public static void MessageBoxClose()
        {
            using (Form chkForm = Application.OpenForms["frmMessageBox"])
            {
                if (chkForm != null) chkForm.Close();
            }
        }
    }
}
