using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace OpenCvSharpPT.API
{
    class Geometry
    {
        #region Variable
        IplImage iplGeometry;

        #endregion

        #region Method

        // summery
        // 대칭변환
        // summery
        public IplImage SymmetricTransform(IplImage src, String strMode)
        {
            iplGeometry = new IplImage(src.Size, BitDepth.U8, 3);

            switch (strMode)
            {
                case "X":
                    Cv.Flip(src, iplGeometry, FlipMode.X);
                    break;
                case "Y":
                    Cv.Flip(src, iplGeometry, FlipMode.Y);
                    break;
                case "XY":
                    Cv.Flip(src, iplGeometry, FlipMode.XY);
                    break;
                default:
                    Cv.Flip(src, iplGeometry, FlipMode.X);
                    break;

            }
            return iplGeometry;
        }

        // summery
        // 회전(Rotate)
        // summery

        public IplImage RotateTransform(IplImage src, int angle)
        {
            iplGeometry = new IplImage(src.Size, BitDepth.U8, 3);
            CvMat matrix = Cv.GetRotationMatrix2D(Cv.Point2D32f(src.Width / 2, src.Height / 2), angle, 1);
            Cv.WarpAffine(src, iplGeometry, matrix, Interpolation.Linear, CvScalar.ScalarAll(0));
            return iplGeometry;
        }

        public void Dispose()
        {
            if (iplGeometry != null) Cv.ReleaseImage(iplGeometry);
        }

        #endregion





    }
}
