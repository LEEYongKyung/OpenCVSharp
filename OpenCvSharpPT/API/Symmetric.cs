using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace OpenCvSharpPT.API
{
    class Symmetric
    {
        IplImage iplSymmetric;

        public IplImage Symmetry(IplImage src, String mode)
        {
            iplSymmetric = new IplImage(src.Size, BitDepth.U8, 3);

            switch( mode)
            {
                case "X":
                    Cv.Flip(src, iplSymmetric, FlipMode.X);
                    break;
                case "Y":
                    Cv.Flip(src, iplSymmetric, FlipMode.Y);
                    break;
                case "XY":
                    Cv.Flip(src, iplSymmetric, FlipMode.XY);
                    break;
                default:
                    Cv.Flip(src, iplSymmetric, FlipMode.X);
                    break;

            }
            return iplSymmetric;
            
        }

        public void Dispose()
        {
            if (iplSymmetric != null) Cv.ReleaseImage(iplSymmetric);

        }
    }
}
