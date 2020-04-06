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

namespace OpenCvSharpPT.UserControl.Sec1_srcOutput
{
    public partial class unLoadImg : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variable
        private static unLoadImg _instance;
        protected String file_path = null;

        #endregion

        #region Constructor
        public unLoadImg()
        {
            InitializeComponent();
        }
        #endregion

        #region Event


        //public override void headerButton_Click(object sender, EventArgs e)
        //{
        //    SimpleButton btn = (SimpleButton)sender;


        //    base.headerButton_Click(sender, e);
        //}

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            file_path = null;
            openFileDialog1.InitialDirectory = "D:\\";
            openFileDialog1.DefaultExt = "png";
            openFileDialog1.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            //openFileDialog의 시작 위치를 지정
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                //선택된 파일의 풀 경로를 불러와 저장
                textBox1.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
                //해당경로에서 파일명만 추출하여 textBox1에 표시

                using (IplImage ipl = new IplImage(file_path, LoadMode.AnyColor))
                {
                    pictureBoxIpl1.ImageIpl = ipl;
                }
            }
        }

        private void unLoadImg_Load(object sender, EventArgs e)
        {
           


            using (IplImage ipl = new IplImage("D:\\08.ComputerVision\\OpenCVSharp\\OpenCVSharp\\OpenCV_Data\\apple.png", LoadMode.AnyColor))
            {
                pictureBoxIpl1.ImageIpl = ipl;
            }
        }
        #endregion

        #region Method
        public static unLoadImg Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new unLoadImg();
                    
                }
                return _instance;
            }
        }







        #endregion

        
    }
}
