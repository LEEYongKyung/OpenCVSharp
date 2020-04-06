using System;
using System.Windows.Forms;
using OpenCvSharp;

namespace OpenCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IplImage src;

        private void Form1_Load(object sender, EventArgs e)
        {
            src = new IplImage("../../../이미지 이름을 할당하세요.jpg");
            OpenCV_CLASS Convert = new OpenCV_CLASS();

            pictureBoxIpl1.ImageIpl = src;
            pictureBoxIpl2.ImageIpl = Convert.SkinDetection(src);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cv.ReleaseImage(src);
            if (src != null) src.Dispose();
        }
    }
}
