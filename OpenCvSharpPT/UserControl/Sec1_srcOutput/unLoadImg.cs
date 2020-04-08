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
using OpenCvSharpPT.API;
using OpenCvSharpPT.BaseForm;
using OpenCvSharpPT.Control;
using OpenCvSharpPT.Entity;
using OpenCvSharpPT.Popup;
using OpenCvSharpPT.UserControl;
using OpenCvSharpPT.Util;


namespace OpenCvSharpPT.UserControl.Sec1_srcOutput
{
    public partial class unLoadImg : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variable
        private static unLoadImg _instance;
        protected String file_path = null;
        IplImage ipl = null;
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


         // Load Image 버튼
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
                ipl = new IplImage(file_path, LoadMode.AnyColor);
                pictureBoxIpl1.ImageIpl = ipl;

                //using (ipl = new IplImage(file_path, LoadMode.AnyColor))
                //{
                //    pictureBoxIpl1.ImageIpl = ipl;
                //}
            }
        }

        private void unLoadImg_Load(object sender, EventArgs e)
        {



            List <CustomPairs > lstControl1 = new List<CustomPairs> ();

            lstControl1.Add(new CustomPairs("X방향", "X"));
            lstControl1.Add(new CustomPairs("Y방향", "Y"));
            lstControl1.Add(new CustomPairs("XY방향", "XY"));
            lueSymmetry.Properties.DataSource = lstControl1;
            lueSymmetry.Properties.ValueMember = "Value";
            lueSymmetry.Properties.DisplayMember = lueSymmetry.Properties.ValueMember;
            lueSymmetry.Properties.NullText = "선택";

        }

        // summery
        // 대칭 동작 
        // summery
        private void btnSymmetry_Click(object sender, EventArgs e)
        {

            try
            {
                CustomPairs select = (CustomPairs)lueSymmetry.GetSelectedDataRow();


                if (ipl == null)
                {
                    uMsgBox.MessageBoxShow(uMsgBox.MessageBoxType.Error, "이미지 에러", "대상 이미지가 없습니다.");
                    return;
                }

                if (select == null)
                {
                    uMsgBox.MessageBoxShow(uMsgBox.MessageBoxType.Error, "속성 선택 에러", "대칭 속성을 선택해 주시기 바랍니다.");
                    return;
                }


                string strSelName = select.Name.ToString();
                string strSelValue = select.Value.ToString();

                //Symmetric Sym = new Symmetric();

                //IplImage iplSymOutputImg =  Sym.SymmetryTransfrom(ipl, strSelValue);

                Geometry geomtry = new Geometry();

                IplImage iplGeoOut = geomtry.SymmetricTransform(ipl, strSelValue);

                if (iplGeoOut == null)
                {
                    uMsgBox.MessageBoxShow(uMsgBox.MessageBoxType.Error, "변환 에러", "대칭 변환이 동작하지 않습니다.");
                    return;
                }
                pictureBoxIpl2.ImageIpl = iplGeoOut;
                geomtry.Dispose();
            }
            catch(Exception ex)
            {
                uMsgBox.MessageBoxShow(uMsgBox.MessageBoxType.Error, "Error", ex.Message);
            }
            
            
        }
        //summery
        // 회전 동작
        //summery
        private void btnRotate_Click(object sender, EventArgs e)
        {
            try
            {
                int intRotateAng = 0;
                if (txtRotateAng == null)
                {
                    uMsgBox.MessageBoxShow(uMsgBox.MessageBoxType.Error, "수치 에러", "수치를 정확히 입력해 주시기 바랍니다.");
                    return;

                }
                intRotateAng = Convert.ToInt32(txtRotateAng.EditValue.ToString());
                Geometry geometry = new Geometry();

                IplImage iplGeoOut = geometry.RotateTransform(ipl, intRotateAng);
                if (iplGeoOut == null)
                {
                    uMsgBox.MessageBoxShow(uMsgBox.MessageBoxType.Error, "변환 에러", "회전 변환이 동작하지 않습니다.");
                    return;
                }
                pictureBoxIpl2.ImageIpl = iplGeoOut;
                geometry.Dispose();

            }
            catch (Exception ex)
            {
                uMsgBox.MessageBoxShow(uMsgBox.MessageBoxType.Error, "Error", ex.Message);
            }
            

        }



        private void tbRotateAng_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
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
