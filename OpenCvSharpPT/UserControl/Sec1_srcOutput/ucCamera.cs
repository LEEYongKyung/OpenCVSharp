using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OpenCvSharp;

namespace OpenCvSharpPT
{
    public partial class ucCamera : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucCamera _instance;

        public static ucCamera Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new ucCamera();
                    return _instance;
                
            }
        }
        public ucCamera()
        {
            InitializeComponent();
        }
        CvCapture capture;
        IplImage src;

        private void ucCamera_Load(object sender, EventArgs e)
        {
            try
            {
                capture = CvCapture.FromCamera(CaptureDevice.DShow, 0); //0은 카메라 장치 번호
                capture.SetCaptureProperty(CaptureProperty.FrameWidth, 640);
                capture.SetCaptureProperty(CaptureProperty.FrameHeight, 480);

            }
            catch
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            src = capture.QueryFrame();
            pictureBoxIpl1.ImageIpl = src; // 영상출력
        }

        private void ucCamera_ControlRemoved(object sender, ControlEventArgs e)
        {
            Cv.ReleaseImage(src);
            if (src != null) src.Dispose();
        }
    }
}
