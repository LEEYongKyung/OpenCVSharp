using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Blob;

namespace OpenCV
{
    class OpenCV_CLASS : IDisposable
    {
        IplImage gray;
        IplImage inversion;
        IplImage bin;
        IplImage blur;
        IplImage zoomin;
        IplImage zoomout;
        IplImage resize;
        IplImage slice;
        IplImage symm;
        IplImage rotate;
        IplImage affine;
        IplImage perspective;
        IplImage draw;
        IplImage hsv;
        IplImage morp;
        IplImage canny;
        IplImage sobel;
        IplImage laplace;
        IplImage con;
        IplImage corner;
        IplImage apcon;
        IplImage convex;
        IplImage mom;
        IplImage houline;
        IplImage houcircle;
        IplImage skin;
        IplImage haarface;
        IplImage bound;
        IplImage ipl;
        IplImage hdcgrahics;
        IplImage blob;
        IplImage blobcontour;
        IplImage filter;
        IplImage bina;
        IplImage gamma;
        IplImage calc;
        IplImage inpaint;
        IplImage dist;
        IplImage pyrseg;
        IplImage pyrmean;
        IplImage match;
        IplImage templit;
        IplImage optical;
        IplImage snake;

        public IplImage GrayScale(IplImage src)
        {
            gray = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, gray, ColorConversion.BgrToGray);
            return gray;
        }
        
        public IplImage InversionImage(IplImage src)
        {
            inversion = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.Not(src, inversion);
            return inversion;
        }

        public IplImage Binary(IplImage src, int threshold)
        {
            bin = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, bin, ColorConversion.BgrToGray);
            Cv.Threshold(bin, bin, threshold, 255, ThresholdType.Binary);
            return bin;
        }

        public IplImage BlurImage(IplImage src)
        {
            blur = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.Smooth(src, blur, SmoothType.Gaussian, 9);
            return blur;
        }

        public IplImage ZoomIn(IplImage src)
        {
            zoomin = new IplImage(new CvSize(src.Width *2, src.Height *2), BitDepth.U8, 3);
            Cv.PyrUp(src, zoomin, CvFilter.Gaussian5x5);
            return zoomin;
        }

        public IplImage ZoomOut(IplImage src)
        {
            zoomout = new IplImage(new CvSize(src.Width / 2, src.Height / 2), BitDepth.U8, 3);
            Cv.PyrDown(src, zoomout, CvFilter.Gaussian5x5);
            return zoomout;
        }

        public IplImage ResizeImage(IplImage src)
        {
            resize = new IplImage(new CvSize(src.Width / 4, src.Height - 1200), BitDepth.U8, 3);
            Cv.Resize(src, resize, Interpolation.Linear);
            return resize;
        }

        public IplImage SliceImage(IplImage src)
        {
            slice = new IplImage(new CvSize(350, 150), BitDepth.U8, 3);

            src.ROI = new CvRect(750, 840, slice.Width, slice.Height);
            //src.SetROI(new CvRect(750, 840, slice.Width, slice.Height));
            //Cv.SetImageROI(src, new CvRect(750, 840, slice.Width, slice.Height));

            Cv.Copy(src, slice);
            //Cv.Resize(src, slice);
            //slice = src.Clone();

            src.ResetROI();
            //Cv.ResetImageROI(src);

            //CvRect rect = new CvRect(750, 840, slice.Width, slice.Height);
            //slice = src.Clone(rect);

            return slice;
        }

        public IplImage Symmetry(IplImage src)
        {
            symm = new IplImage(src.Size, BitDepth.U8, 3);
            Cv.Flip(src, symm, FlipMode.Y);
            return symm;
        }

        public IplImage RotateImage(IplImage src, int angle)
        {
            rotate = new IplImage(src.Size, BitDepth.U8, 3);
            CvMat matrix = Cv.GetRotationMatrix2D(new CvPoint2D32f(src.Width / 2, src.Height / 2), angle, 1);
            Cv.WarpAffine(src, rotate, matrix, Interpolation.Linear, CvScalar.ScalarAll(0));
            return rotate;
        }

        public IplImage AffineImage(IplImage src)
        {
            affine = new IplImage(src.Size, BitDepth.U8, 3);

            CvPoint2D32f[] srcPoint = new CvPoint2D32f[3];
            CvPoint2D32f[] dstPoint = new CvPoint2D32f[3];

            srcPoint[0] = new CvPoint2D32f(100.0, 100.0);
            srcPoint[1] = new CvPoint2D32f(src.Width - 100.0, 100.0);
            srcPoint[2] = new CvPoint2D32f(100.0, src.Height - 100.0);

            dstPoint[0] = new CvPoint2D32f(300.0, 100.0);
            dstPoint[1] = new CvPoint2D32f(src.Width - 100.0, 100.0);
            dstPoint[2] = new CvPoint2D32f(100.0, src.Height - 100.0);

            CvMat matrix = Cv.GetAffineTransform(srcPoint, dstPoint);
            Console.WriteLine(matrix);

            Cv.WarpAffine(src, affine, matrix, Interpolation.Linear, CvScalar.ScalarAll(0));

            return affine;
        }

        public IplImage PerspectiveImage(IplImage src)
        {
            perspective = new IplImage(src.Size, BitDepth.U8, 3);

            CvPoint2D32f[] srcPoint = new CvPoint2D32f[4];
            CvPoint2D32f[] dstPoint = new CvPoint2D32f[4];

            srcPoint[0] = new CvPoint2D32f(600.0, 600.0);
            srcPoint[1] = new CvPoint2D32f(300.0, 900.0);
            srcPoint[2] = new CvPoint2D32f(1300.0, 600.0);
            srcPoint[3] = new CvPoint2D32f(1600.0, 900.0);

            float width = src.Size.Width;
            float height = src.Size.Height;

            dstPoint[0] = new CvPoint2D32f(0.0, 0.0);
            dstPoint[1] = new CvPoint2D32f(0.0, height);
            dstPoint[2] = new CvPoint2D32f(width, 0.0);
            dstPoint[4] = new CvPoint2D32f(width, height);

            CvMat matrix = Cv.GetPerspectiveTransform(srcPoint, dstPoint);
            Console.WriteLine(matrix);

            Cv.WarpPerspective(src, perspective, matrix, Interpolation.Linear, CvScalar.ScalarAll(0));
            return perspective;
        }

        public IplImage DrawImage()
        {
            draw = new IplImage(new CvSize(640, 480), BitDepth.U8, 3);

            Cv.DrawLine(draw, new CvPoint(100, 100), new CvPoint(500, 100), CvColor.Blue, 20);
            Cv.DrawCircle(draw, new CvPoint(200, 200), 50, CvColor.Red, -1);
            Cv.DrawRect(draw, new CvPoint(300, 150), new CvPoint(500, 300), CvColor.Green, 10);
            Cv.Ellipse(draw, new CvPoint(150, 400), new CvSize(100, 50), 0, 90, 360, CvColor.Yellow, 5);
            Cv.PutText(draw, "Open Cv", new CvPoint(400, 400), new CvFont(FontFace.HersheyComplex, 1, 1), CvColor.White);

            return draw;
        }

        public IplImage HSV(IplImage src)
        {
            hsv = new IplImage(src.Size, BitDepth.U8, 3);

            IplImage h = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage s = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage v = new IplImage(src.Size, BitDepth.U8, 1);

            Cv.CvtColor(src, hsv, ColorConversion.BgrToHsv);
            Cv.Split(hsv, h, s, v, null);
            hsv.SetZero();

            //Hue//
            //Cv.InRangeS(h, 20, 30, h);
            //Cv.Copy(src, hsv, h);

            //Saturation//
            //Cv.InRangeS(s, 20, 30, s);
            //Cv.Copy(src, hsv, s);

            //Value//
            //Cv.InRangeS(v, 20, 30, v);
            //Cv.Copy(src, hsv, v);

            //Red//
            IplImage lower_red = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage upper_red = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage red = new IplImage(src.Size, BitDepth.U8, 1);

            Cv.InRangeS(h, 0, 10, lower_red);
            Cv.InRangeS(h, 170, 179, upper_red);
            Cv.AddWeighted(lower_red, 1.0, upper_red, 1.0, 0.0, red);

            Cv.Copy(src, hsv, red);

            return hsv;
        }

        public IplImage HSV_Red(IplImage src)
        {
            hsv = new IplImage(src.Size, BitDepth.U8, 3);

            //Red//
            IplImage lower_red = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage upper_red = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage red = new IplImage(src.Size, BitDepth.U8, 1);

            Cv.InRangeS(hsv, new CvScalar(0, 100, 100), new CvScalar(10, 255, 255), lower_red);
            Cv.InRangeS(hsv, new CvScalar(170, 100, 100), new CvScalar(179, 255, 255), upper_red);
            Cv.AddWeighted(lower_red, 1.0, upper_red, 1.0, 0.0, red);

            hsv.SetZero();
            Cv.Copy(src, hsv, red);

            return hsv;
        }

        public IplImage DilateImage(IplImage src)
        {
            morp = new IplImage(src.Size, BitDepth.U8, 3);
            bin = this.Binary(src, 50);

            Cv.Dilate(bin, morp, null, 10);
            return morp;
        }

        public IplImage ErodeImage(IplImage src)
        {
            morp = new IplImage(src.Size, BitDepth.U8, 3);
            bin = this.Binary(src, 50);

            IplConvKernel element = new IplConvKernel(3, 3, 1, 1, ElementShape.Rect);

            Cv.Erode(bin, morp, element, 10);
            return morp;
        }

        public IplImage DEImage(IplImage src)
        {
            morp = new IplImage(src.Size, BitDepth.U8, 3);
            bin = this.Binary(src, 50);

            Cv.Dilate(bin, morp, null, 10);
            Cv.Erode(bin, morp, null, 10);
            return morp;
        }

        public IplImage MorphologyImage(IplImage src)
        {
            morp = new IplImage(src.Size, BitDepth.U8, 3);
            bin = this.Binary(src, 50);

            IplConvKernel element = new IplConvKernel(3, 3, 1, 1, ElementShape.Rect);
            Cv.MorphologyEx(src, morp, bin, element, MorphologyOperation.Gradient, 10);
            return morp;
        }

        public IplImage CannyEdge(IplImage src)
        {
            canny = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.Canny(src, canny, 100, 255, ApertureSize.Size3);
            return canny;
        }

        public IplImage SobelEdge(IplImage src)
        {
            sobel = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, sobel, ColorConversion.BgrToGray);
            Cv.Sobel(src, sobel, 1, 1, ApertureSize.Size3);
            return sobel;
        }

        public IplImage LaplaceEdge(IplImage src)
        {
            laplace = new IplImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, laplace, ColorConversion.BgrToGray);
            Cv.Laplace(laplace, laplace, ApertureSize.Size3);
            return laplace;
        }

        public IplImage FindContour(IplImage src)
        {
            con = new IplImage(src.Size, BitDepth.U8, 3);
            Cv.Copy(src, con);
            bin = this.Binary(src, 150);

            CvMemStorage Storage = new CvMemStorage();
            CvSeq<CvPoint> contours;

            Cv.FindContours(bin, Storage, out contours, CvContour.SizeOf, ContourRetrieval.List, ContourChain.ApproxNone);            
            Cv.DrawContours(con, contours, CvColor.Yellow, CvColor.Red, 1, 4, LineType.AntiAlias);

            Cv.ClearSeq(contours);
            Cv.ReleaseMemStorage(Storage);

            return con;
        }

        public IplImage ScannerContour(IplImage src)
        {
            con = new IplImage(src.Size, BitDepth.U8, 3);
            Cv.Copy(src, con);
            bin = this.Binary(src, 150);

            CvMemStorage Storage = new CvMemStorage();
            //CvSeq<CvPoint> contours;

            CvContourScanner scanner = Cv.StartFindContours(bin, Storage, CvContour.SizeOf, ContourRetrieval.List, ContourChain.ApproxNone);

            //while ((contours = Cv.FindNextContour(scanner)) != null)
            //{
            //    if (contours[0].Value == new CvPoint(1, 1)) continue;
            //    Cv.DrawContours(con, contours, CvColor.Yellow, CvColor.Red, 1, 4, LineType.AntiAlias);
            //}
            //Cv.EndFindContours(scanner);

            foreach (CvSeq<CvPoint> contours in scanner)
            {
                if (contours[0].Value == new CvPoint(1, 1)) continue;
                con.DrawContours(contours, CvColor.Yellow, CvColor.Red, 1, 4, LineType.AntiAlias);
            }

            return con;
        }

        public IplImage GoodFeaturesToTrack(IplImage src)
        {
            corner = new IplImage(src.Size, BitDepth.U8, 3);
            IplImage eigImage = new IplImage(src.Size, BitDepth.U8, 1);
            IplImage tempImage = new IplImage(src.Size, BitDepth.U8, 1);

            Cv.Copy(src, corner);
            gray = this.GrayScale(src);

            CvPoint2D32f[] corners;
            int cornerCount = 150;

            Cv.GoodFeaturesToTrack(gray, eigImage, tempImage, out corners, ref cornerCount, 0.01, 5);

            Cv.FindCornerSubPix(gray, corners, cornerCount, new CvSize(10, 10), new CvSize(-1, -1), new CvTermCriteria(100, 0.01));

            for (int i = 0; i < cornerCount; i++)
            {
                Cv.DrawCircle(corner, corners[i], 3, CvColor.Black, 2);
            }

            return corner;
        }

        public IplImage HarrisCorner(IplImage src)
        {
            corner = new IplImage(src.Size, BitDepth.U8, 3);
            gray = this.GrayScale(src);

            Cv.CornerHarris(gray, corner, 3, ApertureSize.Size3, 0.01);

            return corner;
        }

        public IplImage ApproxPoly(IplImage src)
        {
            apcon = new IplImage(src.Size, BitDepth.U8, 3);

            Cv.Copy(src, apcon);
            bin = this.Binary(src, 200);

            CvMemStorage Storage = new CvMemStorage();
            CvSeq<CvPoint> contours;
            Cv.FindContours(bin, Storage, out contours, CvContour.SizeOf, ContourRetrieval.List, ContourChain.ApproxNone);

            CvSeq<CvPoint> apcon_seq = Cv.ApproxPoly(contours, CvContour.SizeOf, Storage, ApproxPolyMethod.DP, 3, true);

            for (CvSeq<CvPoint> c = apcon_seq; c != null; c = c.HNext)
            {
                if (c.Total > 4)
                {
                    for (int i = 0; i < c.Total; i++)
                    {
                        //CvPoint conpt = new CvPoint(c[i].Value.X, c[i].Value.Y);
                        CvPoint? p = Cv.GetSeqElem(c, i);
                        CvPoint conpt;
                        conpt.X = p.Value.X;
                        conpt.Y = p.Value.Y;

                        Cv.DrawCircle(apcon, conpt, 3, CvColor.Black);
                    }
                }
            }
            return apcon;
        }

        public IplImage ConvexHull(IplImage src)
        {
            convex = new IplImage(src.Size, BitDepth.U8, 3);

            Cv.Copy(src, convex);
            bin = this.Binary(src, 200);

            CvMemStorage Storage = new CvMemStorage();
            CvSeq<CvPoint> contours;
            Cv.FindContours(bin, Storage, out contours, CvContour.SizeOf, ContourRetrieval.List, ContourChain.ApproxNone);

            CvSeq<CvPoint> apcon_seq = Cv.ApproxPoly(contours, CvContour.SizeOf, Storage, ApproxPolyMethod.DP, 3, true);

            for (CvSeq<CvPoint> c = apcon_seq; c != null; c = c.HNext)
            {
                if (c.Total > 4)
                {

                    CvPoint[] conpt = new CvPoint[c.Total];

                    for (int i = 0; i < c.Total; i++)
                    {
                        //CvPoint conpt = new CvPoint(c[i].Value.X, c[i].Value.Y);
                        CvPoint? p = Cv.GetSeqElem(c, i);

                        conpt[i] = new CvPoint(p.Value.X, p.Value.Y);
                    }

                    CvPoint[] hull;
                    Cv.ConvexHull2(conpt, out hull, ConvexHullOrientation.Clockwise);

                    CvPoint pt0 = hull.Last();
                    foreach(CvPoint pt in hull)
                    {
                        Cv.DrawLine(convex, pt0, pt, CvColor.Green, 2);
                        pt0 = pt;
                    }
                }
            }
            return convex;
        }

        public IplImage CenterPoint(IplImage src)
        {
            mom = new IplImage(src.Size, BitDepth.U8, 3);

            Cv.Copy(src, mom);
            bin = this.Binary(src, 200);

            CvMemStorage Storage = new CvMemStorage();
            CvSeq<CvPoint> contours;
            Cv.FindContours(bin, Storage, out contours, CvContour.SizeOf, ContourRetrieval.List, ContourChain.ApproxNone);

            CvSeq<CvPoint> apcon_seq = Cv.ApproxPoly(contours, CvContour.SizeOf, Storage, ApproxPolyMethod.DP, 3, true);

            CvMoments moments;
            int cX = 0, cY = 0;

            for (CvSeq<CvPoint> c = apcon_seq; c != null; c = c.HNext)
            {
                if (c.Total > 4)
                {
                    Cv.Moments(c, out moments, true);

                    cX = Convert.ToInt32(moments.M10 / moments.M00);
                    cY = Convert.ToInt32(moments.M01 / moments.M00);

                    Cv.DrawCircle(mom, new CvPoint(cX, cY), 5, CvColor.Red, -1);
                }
            }
            return mom;
        }

        public IplImage HoughLines(IplImage src)
        {
            houline = new IplImage(src.Size, BitDepth.U8, 3);
            bin = this.Binary(src, 150);

            Cv.Dilate(bin, bin, null, 1);
            Cv.Erode(bin, bin, null, 3);
            Cv.Dilate(bin, bin, null, 2);
            Cv.Canny(bin, bin, 0, 255);

            Cv.CvtColor(bin, houline, ColorConversion.GrayToBgr);

            CvMemStorage Storage = new CvMemStorage();
            
            CvSeq lines = canny.HoughLines2(Storage, HoughLinesMethod.Probabilistic, 1, Math.PI / 180, 140, 50, 10);
            //for (int i = 0; i < Math.Min(lines.Total, 20); i++)
            //{
            //    CvLineSegmentPolar element = lines.GetSeqElem<CvLineSegmentPolar>(i).Value;

            //    float r = element.Rho;
            //    float theta = element.Theta;

            //    double a = Math.Cos(theta);
            //    double b = Math.Sin(theta);
            //    double x0 = r * a;
            //    double y0 = r * b;

            //    int scale = src.Size.Width + src.Size.Height;

            //    CvPoint pt1 = new CvPoint(Convert.ToInt32(x0 - scale * b), Convert.ToInt32(y0 + scale * a));
            //    CvPoint pt2 = new CvPoint(Convert.ToInt32(x0 + scale * b), Convert.ToInt32(y0 - scale * a));

            //    houline.Line(pt1, pt2, CvColor.Red, 1, LineType.AntiAlias);
            //}
            for (int i = 0; i < Math.Min(lines.Total, 20); i++)
            {
                CvLineSegmentPoint element = lines.GetSeqElem<CvLineSegmentPoint>(i).Value;
                houline.Line(element.P1, element.P2, CvColor.Yellow, 1, LineType.AntiAlias);
            }
            return houline;
        }

        public IplImage HoughCircles(IplImage src)
        {
            houcircle = new IplImage(src.Size, BitDepth.U8, 3);
            Cv.Copy(src, houcircle);
            gray = this.GrayScale(src);
            Cv.Smooth(gray, gray, SmoothType.Gaussian, 9);

            CvMemStorage Storage = new CvMemStorage();
            CvSeq<CvCircleSegment> circles = Cv.HoughCircles(gray, Storage, HoughCirclesMethod.Gradient, 1, 100, 150, 50, 0, 0);

            foreach (CvCircleSegment item in circles)
            {
                Cv.DrawCircle(houcircle, item.Center, (int)item.Radius, CvColor.Blue, 3);
            }
            return houcircle;
        }

        public IplImage SkinDetection(IplImage src)
        {
            skin = new IplImage(src.Size, BitDepth.U8, 3);
            IplImage output = new IplImage(src.Size, BitDepth.U8, 1);

            Cv.Copy(src, skin);

            //CvAdaptiveSkinDetector detector = new CvAdaptiveSkinDetector(1, MorphingMethod.ErodeDilate);
            //detector.Process(src, output);

            for (int x = 0; x < src.Width; x++)
            {
                for (int y = 0; y < src.Height; y++)
                {
                    //if (output[y, x].Val0 != 0)
                    //{
                    //    skin[y, x] = CvColor.Green;
                    //}

                    CvColor Color = skin[y, x];
                    if (Color.R < 100)
                    {
                        skin[y, x] = new CvColor(0, 255, 0);
                    }
                }
            }
            return skin;
        }

        public IplImage FaceDetection(IplImage src)
        {
            haarface = new IplImage(src.Size, BitDepth.U8, 3);
            Cv.Copy(src, haarface);

            gray = this.GrayScale(src);
            Cv.EqualizeHist(gray, gray);

            double scaleFactor = 1.139;
            int minNeighbors = 1;

            CvHaarClassifierCascade cascade = CvHaarClassifierCascade.FromFile("../../haarcascade_frontalface_alt.xml");
            CvMemStorage Storage = new CvMemStorage();

            CvSeq<CvAvgComp> faces = Cv.HaarDetectObjects(gray, cascade, Storage, scaleFactor, minNeighbors, HaarDetectionType.ScaleImage, new CvSize(90, 90), new CvSize(0, 0));

            for (int i = 0; i < faces.Total; i++)
            {
                CvRect r = faces[i].Value.Rect;

                int cX = Cv.Round(r.X + r.Width * 0.5);
                int cY = Cv.Round(r.Y + r.Height * 0.5);
                int radius = Cv.Round((r.Width + r.Height) * 0.25);

                Cv.DrawCircle(haarface, new CvPoint(cX, cY), radius, CvColor.Black, 3);
            }
            return haarface;
        }

        public IplImage BoundingRectangle()
        {
            bound = new IplImage(new CvSize(640, 480), BitDepth.U8, 3);

            int num = 7;
            CvRNG rng = new CvRNG(DateTime.Now);
            CvPoint[] points = new CvPoint[num];

            for (int i = 0; i < num; i++)
            {
                points[i] = new CvPoint()
                {
                    X = (int)(rng.RandInt() % (bound.Width)),
                    Y = (int)(rng.RandInt() % (bound.Height))
                };
                Cv.DrawCircle(bound, points[i], 3, CvColor.Green, Cv.FILLED);
            }

            CvRect rect = Cv.BoundingRect(points);
            Cv.DrawRect(bound, rect, CvColor.Red, 2);
            return bound;
        }

        public IplImage ToBitmap(IplImage src)
        {
            ipl = new IplImage(src.Size, BitDepth.U8, 3);
            //Bitmap bitmap = src.ToBitmap();
            Bitmap bitmap = BitmapConverter.ToBitmap(src);

            Graphics grp = Graphics.FromImage(bitmap);
            grp.DrawEllipse(new Pen(Color.Red, 10), 10, 10, 200, 200);

            //ipl = bitmap.ToIplImage();
            ipl = BitmapConverter.ToIplImage(bitmap);

            return ipl;
        }

        public IplImage DrawToHdc(IplImage src)
        {
            hdcgrahics = new IplImage(src.Size, BitDepth.U8, 3);

            Bitmap bitmap = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppRgb);
            Graphics grp = Graphics.FromImage(bitmap);

            IntPtr hdc = grp.GetHdc();
            BitmapConverter.DrawToHdc(src, hdc, new CvRect(new CvPoint(0, 150), new CvSize(src.Width, src.Height - 150)));
            grp.ReleaseHdc(hdc);

            grp.DrawString("안녕하세요.", new Font("맑은 고딕", 72), Brushes.Red, 5, 5);
            hdcgrahics.CopyFrom(bitmap);

            return hdcgrahics;
        }

        public IplImage BlobImage(IplImage src)
        {
            blob = new IplImage(src.Size, BitDepth.U8, 3);
            bin = this.Binary(src, 50);

            CvBlobs blobs = new CvBlobs();
            blobs.Label(bin);

            blobs.RenderBlobs(src, blob);

            foreach (KeyValuePair<int, CvBlob> item in blobs)
            {
                CvBlob b = item.Value;

                Cv.PutText(blob, Convert.ToString(b.Label), b.Centroid, new CvFont(FontFace.HersheyComplex, 1, 1), CvColor.Red);
            }

            return blob;
        }

        public IplImage BlobContourImage(IplImage src)
        {
            blobcontour = new IplImage(src.Size, BitDepth.U8, 3);
            bin = this.Binary(src, 50);

            CvBlobs blobs = new CvBlobs();
            blobs.Label(bin);

            foreach (KeyValuePair<int, CvBlob> item in blobs)
            {
                CvBlob b = item.Value;

                CvContourChainCode cc = b.Contour;
                cc.Render(blobcontour);

                CvContourPolygon ex_polygon = cc.ConvertToPolygon();
                foreach (CvPoint p in ex_polygon)
                {
                    Cv.DrawCircle(blobcontour, p, 1, CvColor.Blue, -1);
                }

                for(int i=0; i<b.InternalContours.Count; i++)
                {
                    CvContourPolygon in_polygon = b.InternalContours[i].ConvertToPolygon();
                    foreach(CvPoint p in in_polygon)
                    {
                        Cv.DrawCircle(blobcontour, p, 1, CvColor.Red, -1);
                    }
                }
            }
            return blobcontour;
        }

        public IplImage Filter2D(IplImage src)
        {
            filter = new IplImage(src.Size, BitDepth.U8, 3);

            float[] data =  {   1,  4,  7,  4,  1,
                                4,  16, 26, 16, 4,
                                7,  26, 41, 26, 7,
                                4,  16, 26, 16, 4,
                                1,  4,  7,  4,  1   };

            CvMat kernel = new CvMat(5, 5, MatrixType.F32C1, data);

            Cv.Normalize(kernel, kernel, 1.0, 0, NormType.L1);
            Cv.Filter2D(src, filter, kernel);
            return filter;
        }

        public IplImage BinarizerMethod(IplImage src)
        {
            bina = new IplImage(src.Size, BitDepth.U8, 1);
            gray = this.GrayScale(src);

            Binarizer.Bernsen(gray, bina, 52, 60, 150);

            return bina;
        }

        public IplImage BinarizerMethod_Hist(IplImage src)
        {
            bina = new IplImage(src.Size, BitDepth.U8, 1);
            gray = this.GrayScale(src);

            int area = 200;
            int num = 0;

            int row = (src.Width % area == 0) ? (int)(src.Width / area) : (int)(src.Width / area + 1);
            int col = (src.Height % area == 0) ? (int)(src.Height / area) : (int)(src.Height / area + 1);
            int count = row * col;

            float[] data = new float[count];
            IplImage[] piece = new IplImage[count];
            CvRect[] piece_roi = new CvRect[count];

            for (int x = 0; x < src.Width; x = x + area)
            {
                for (int y = 0; y < src.Height; y = y + area)
                {
                    CvRect roi = new CvRect
                    {
                        X = x,
                        Y = y,
                        Width = area,
                        Height = area
                    };

                    if (roi.X + roi.Width > src.Width) roi.Width = area - ((roi.X + roi.Width) - src.Width);
                    if (roi.Y + roi.Height > src.Height) roi.Height = area - ((roi.Y + roi.Height) - src.Height);

                    gray.SetROI(roi);
                    piece[num] = new IplImage(gray.ROI.Size, BitDepth.U8, 1);
                    Cv.Copy(gray, piece[num]);
                    gray.ResetROI();

                    //히스토그램 계산//
                    int[] size = { area };
                    CvHistogram hist = new CvHistogram(size, HistogramFormat.Array);
                    Cv.CalcHist(piece[num], hist);

                    float minValue, maxValue;
                    hist.GetMinMaxValue(out minValue, out maxValue);

                    int highlevel = 0;
                    for (int i = 0; i < area; i++)
                    {
                        if (maxValue == hist.Bins[i].Val0) highlevel = i;
                    }

                    piece_roi[num] = roi;
                    data[num] = highlevel;
                    num++;
                }
            }

            CvMat kernel = new CvMat(row, col, MatrixType.F32C1, data);
            Cv.Normalize(kernel, kernel, 255, 0, NormType.C);

            for (int r = 0; r < count; r++)
            {
                Cv.Threshold(piece[r], piece[r], kernel[r], 255, ThresholdType.Otsu);

                Cv.SetImageROI(bina, piece_roi[r]);
                Cv.Copy(piece[r], bina);
                bina.ResetROI();
            }

            //37강 - 윈도우 창//
            CvWindow win = new CvWindow("window", WindowMode.StretchImage, src);
            win.Resize(640, 480);
            win.Move(100, 0);
            win.ShowImage(piece[0]);
            win.Close();

            new CvWindow(piece[0]).Move(0, 0);
            new CvWindow(piece[1]).Move(0, 200);
            new CvWindow(piece[2]).Move(0, 400);
            //37강 - 윈도우 창//

            return bina;
        }

        public IplImage GammaCorrect(IplImage src)
        {
            gamma = new IplImage(src.Size, BitDepth.U8, 3);

            double gamma_value = 0.5;

            byte[] lut = new byte[256];
            for (int i = 0; i < lut.Length; i++)
            {
                lut[i] = (byte)(Math.Pow(i / 255.0, 1.0 / gamma_value) * 255.0);
            }

            Cv.LUT(src, gamma, lut);

            return gamma;
        }

        public IplImage BitwiseMat(IplImage src)
        {
            Mat Input1 = new Mat(src);
            Mat Input2 = new Mat(this.Binary(src, 150));
            Mat bitwise = new Mat();

            Window win_src1 = new Window("src1", WindowMode.StretchImage, Input1);
            Window win_src2 = new Window("src2", WindowMode.StretchImage, Input2);

            Cv2.BitwiseNot(Input1, bitwise);
            Window win_Not = new Window("BitwiseNot", WindowMode.StretchImage, bitwise);

            Cv2.BitwiseAnd(Input1, Input2.CvtColor(ColorConversion.GrayToBgr), bitwise);
            Window win_And = new Window("BitwiseAnd", WindowMode.StretchImage, bitwise);

            Cv2.BitwiseOr(Input1, Input2.CvtColor(ColorConversion.GrayToBgr), bitwise);
            Window win_Or = new Window("BitwiseOr", WindowMode.StretchImage, bitwise);

            Cv2.BitwiseXor(Input1, Input2.CvtColor(ColorConversion.GrayToBgr), bitwise);
            Window win_Xor = new Window("BitwiseXor", WindowMode.StretchImage, bitwise);

            //IplImage 형식//

            //Cv.Not();
            //Cv.And();
            //Cv.Or();
            //Cv.Xor();

            //IplImage 형식//
        
            return Input2.ToIplImage();
        }

        public void Calculate(IplImage src)
        {
            calc = new IplImage(src.Size, BitDepth.U8, 3);
            IplImage src_symm = this.Symmetry(src);

            Cv.Add(src, src_symm, calc);
            CvWindow window_add = new CvWindow("Add", WindowMode.StretchImage, calc);

            Cv.Sub(src, src_symm, calc);
            CvWindow window_sub = new CvWindow("Sub", WindowMode.StretchImage, calc);

            Cv.Mul(src, src_symm, calc);
            CvWindow window_Mul = new CvWindow("Mul", WindowMode.StretchImage, calc);

            Cv.Div(src, src_symm, calc);
            CvWindow window_div = new CvWindow("Div", WindowMode.StretchImage, calc);

            Cv.Max(src, src_symm, calc);
            CvWindow window_max = new CvWindow("Max", WindowMode.StretchImage, calc);

            Cv.Min(src, src_symm, calc);
            CvWindow window_min = new CvWindow("Min", WindowMode.StretchImage, calc);

            Cv.AbsDiff(src, src_symm, calc);
            CvWindow window_absdiff = new CvWindow("AbsDiff", WindowMode.StretchImage, calc);

            Cv.WaitKey(0);
            {
                CvWindow.DestroyAllWindows();
            }
        }

        public IplImage InpaintImage(IplImage src)
        {
            inpaint = new IplImage(src.Size, BitDepth.U8, 3);
            IplImage paint = src.Clone();
            IplImage mask = new IplImage(src.Size, BitDepth.U8, 1);

            CvWindow win_Paint = new CvWindow("Paint", WindowMode.AutoSize, paint);

            CvPoint prevPt = new CvPoint(-1, -1);
            win_Paint.OnMouseCallback += delegate (MouseEvent eve, int x, int y, MouseEvent flag)
            {
                if (eve == MouseEvent.LButtonDown)
                {
                    prevPt = new CvPoint(x, y);
                }
                else if (eve == MouseEvent.LButtonUp || (flag & MouseEvent.FlagLButton) == 0)
                {
                    prevPt = new CvPoint(-1, -1);
                }
                else if (eve == MouseEvent.MouseMove && (flag & MouseEvent.FlagLButton) != 0)
                {
                    CvPoint pt = new CvPoint(x, y);

                    Cv.DrawLine(mask, prevPt, pt, CvColor.White, 5, LineType.AntiAlias, 0);
                    Cv.DrawLine(paint, prevPt, pt, CvColor.White, 5, LineType.AntiAlias, 0);
                    prevPt = pt;
                    win_Paint.ShowImage(paint);
                }
            };

            bool repeat = true;
            while (repeat)
            {
                switch (CvWindow.WaitKey(0))
                {
                    case 'r':
                        mask.SetZero();
                        Cv.Copy(src, paint);
                        win_Paint.ShowImage(paint);
                        break;
                    case '\r':
                        CvWindow win_Inpaint = new CvWindow("Inpainted", WindowMode.AutoSize);
                        Cv.Inpaint(paint, mask, inpaint, 3, InpaintMethod.NS);
                        win_Inpaint.ShowImage(inpaint);
                        break;
                    case (char)27:
                        CvWindow.DestroyAllWindows();
                        repeat = false;
                        break;
                }
            }
            return inpaint;
        }

        public IplImage DistTransform(IplImage src)
        {
            dist = new IplImage(src.Size, BitDepth.F32, 1);
            IplImage bin = new IplImage(src.Size, BitDepth.U8, 1);

            Cv.CvtColor(src, bin, ColorConversion.BgrToGray);
            Cv.Threshold(bin, bin, 230, 255, ThresholdType.BinaryInv);
            Cv.DistTransform(bin, dist, DistanceType.L2, 3);

            CvPoint minval, maxval;
            Cv.MinMaxLoc(dist, out minval, out maxval);
            Cv.DrawCircle(dist, maxval, 40, CvColor.Black, 10);

            return dist;
        }

        public IplImage PyrSegmentation(IplImage src)
        {
            pyrseg = src.Clone();
            IplImage srcROI = src.Clone();

            int level = 7;
            double link_threshold = 127;
            double secl_threshold = 127;

            CvRect roi = new CvRect()
            {
                X = 0,
                Y = 0,
                Width = srcROI.Width & -(1 << level),
                Height = srcROI.Height & -(1 << level)
            };

            srcROI.ROI = roi;
            pyrseg = srcROI.Clone();

            Cv.PyrSegmentation(srcROI, pyrseg, level, link_threshold, secl_threshold);

            return pyrseg;
        }

        public IplImage PyrMeanShiftFiltering(IplImage src)
        {
            pyrmean = src.Clone();
            IplImage srcROI = src.Clone();

            int level = 1;
            double space_radius = 60.0;
            double color_radius = 60.0;

            CvRect roi = new CvRect()
            {
                X = 0,
                Y = 0,
                Width = srcROI.Width & -(1 << level),
                Height = srcROI.Height & -(1 << level)
            };

            srcROI.ROI = roi;
            pyrmean = srcROI.Clone();

            Cv.PyrMeanShiftFiltering(srcROI, pyrmean, space_radius, color_radius, level, new CvTermCriteria(7, 3));

            return pyrmean;
        }

        public IplImage TemplitImage(IplImage src, IplImage temp)
        {
            match = src;
            templit = temp;
            IplImage calc = new IplImage(new CvSize(match.Size.Width - templit.Size.Width + 1, match.Size.Height - templit.Size.Height + 1), BitDepth.F32, 1);

            Cv.MatchTemplate(match, templit, calc, MatchTemplateMethod.SqDiffNormed);

            CvPoint minloc, maxloc;
            Cv.MinMaxLoc(calc, out minloc, out maxloc);

            Cv.DrawRect(match, new CvRect(minloc.X, minloc.Y, templit.Width, templit.Height), CvColor.Red, 3);

            return match;
        }

        public IplImage OpticalFlowLK(IplImage previous, IplImage current)
        {
            IplImage prev = this.GrayScale(previous);
            IplImage curr = this.GrayScale(current);
            optical = current;

            int rows = optical.Height;
            int cols = optical.Width;

            CvMat velx = Cv.CreateMat(rows, cols, MatrixType.F32C1);
            CvMat vely = Cv.CreateMat(rows, cols, MatrixType.F32C1);

            velx.SetZero();
            vely.SetZero();

            Cv.CalcOpticalFlowLK(prev, curr, new CvSize(15, 15), velx, vely);

            for (int i = 0; i < cols; i += 15)
            {
                for (int j = 0; j < rows; j += 15)
                {
                    int dx = (int)Cv.GetReal2D(velx, j, i);
                    int dy = (int)Cv.GetReal2D(vely, j, i);

                    Cv.DrawCircle(optical, i, j, 1, CvColor.Red);

                    if (Math.Abs(dx) < 30 && Math.Abs(dy) < 30)
                    {
                        if (Math.Abs(dx) < 10 && Math.Abs(dy) < 10) continue;

                        Cv.DrawLine(optical, new CvPoint(i, j), new CvPoint(i + dx, j + dy), CvColor.Blue, 1, LineType.AntiAlias);
                        Cv.DrawCircle(optical, new CvPoint(i + dx, j + dy), 3, CvColor.Blue, -1);
                    }
                }
            }
            return optical;
        }

        public IplImage OpticalFlowPyrLK(IplImage previous, IplImage current)
        {
            IplImage prev = this.GrayScale(previous);
            IplImage curr = this.GrayScale(current);
            optical = current;

            IplImage prev_pyramid = new IplImage(new CvSize(optical.Width + 8, optical.Height / 3), BitDepth.U8, 1);
            IplImage curr_pyramid = new IplImage(new CvSize(optical.Width + 8, optical.Height / 3), BitDepth.U8, 1);

            IplImage eigImg = new IplImage(optical.Size, BitDepth.U8, 1);
            IplImage tempImg = new IplImage(optical.Size, BitDepth.U8, 1);

            CvPoint2D32f[] corners;
            int cornerCount = 600;
            Cv.GoodFeaturesToTrack(prev, eigImg, tempImg, out corners, ref cornerCount, 0.01, 15);

            CvPoint2D32f[] corners2;
            sbyte[] status;
            CvTermCriteria critreia = new CvTermCriteria(100, 0.01);
            Cv.CalcOpticalFlowPyrLK(prev, curr, prev_pyramid, curr_pyramid, corners, out corners2, new CvSize(15, 15), 5, out status, critreia, LKFlowFlag.PyrAReady);

            for (int i = 0; i < cornerCount; i++)
            {
                if (status[i] == 1)
                {
                    int dx = (int)(corners2[i].X - corners[i].X);
                    int dy = (int)(corners2[i].Y - corners[i].Y);

                    if (Math.Abs(dx) < 30 && Math.Abs(dy) < 30)
                    {
                        if (Math.Abs(dx) < 10 && Math.Abs(dy) < 10) continue;

                        Cv.DrawLine(optical, corners[i], corners2[i], CvColor.Red, 1, LineType.AntiAlias);
                        Cv.DrawCircle(optical, corners2[i], 3, CvColor.Red, -1);
                    }
                }
            }
            return optical;
        }

        public IplImage SnakeImage(IplImage src)
        {
            snake = new IplImage(src.Size, BitDepth.U8, 3);
            IplImage calc = new IplImage(src.Size, BitDepth.U8, 1);

            calc = this.Binary(src, 150);
            calc = this.BlurImage(calc);

            int n = 2000;
            CvPoint[] contour = new CvPoint[n];
            CvPoint center = new CvPoint(src.Width / 2, src.Height / 2);

            for (int i = 0; i < n; i++)
            {
                contour[i].X = (int)(center.X + (center.X * Math.Cos(2 * Math.PI * i / n)));
                contour[i].Y = (int)(center.Y + (center.Y * Math.Sin(2 * Math.PI * i / n)));
            }

            CvWindow window = null;

            for (int j = 0; j < 100; j++)
            {
                window = new CvWindow("SnakeImage", WindowMode.StretchImage);
                window.Resize(640, 480);

                Cv.SnakeImage(calc, contour, 1f, 1f, 1f, new CvSize(15, 15), new CvTermCriteria(10), true);
                Cv.Copy(src, snake);

                for (int k = 0; k < n - 1; k++)
                {
                    Cv.DrawLine(snake, contour[k], contour[k + 1], CvColor.Red, 2);
                }
                Cv.DrawLine(snake, contour[n - 1], contour[0], CvColor.Red, 2);

                window.Image = snake;
                Application.DoEvents();
            }
            window.Close();
            return snake;
        }

        public void Dispose()
        {
            if (gray != null) Cv.ReleaseImage(gray);
            if (inversion != null) Cv.ReleaseImage(inversion);
            if (bin != null) Cv.ReleaseImage(bin);
            if (blur != null) Cv.ReleaseImage(blur);
            if (zoomin != null) Cv.ReleaseImage(zoomin);
            if (zoomout != null) Cv.ReleaseImage(zoomout);
            if (resize != null) Cv.ReleaseImage(resize);
            if (slice != null) Cv.ReleaseImage(slice);
            if (symm != null) Cv.ReleaseImage(symm);
            if (rotate != null) Cv.ReleaseImage(rotate);
            if (affine != null) Cv.ReleaseImage(affine);
            if (perspective != null) Cv.ReleaseImage(perspective);
            if (draw != null) Cv.ReleaseImage(draw);
            if (hsv != null) Cv.ReleaseImage(hsv);
            if (morp != null) Cv.ReleaseImage(morp);
            if (canny != null) Cv.ReleaseImage(canny);
            if (sobel != null) Cv.ReleaseImage(sobel);
            if (laplace != null) Cv.ReleaseImage(laplace);
            if (con != null) Cv.ReleaseImage(con);
            if (corner != null) Cv.ReleaseImage(corner);
            if (apcon != null) Cv.ReleaseImage(apcon);
            if (convex != null) Cv.ReleaseImage(convex);
            if (mom != null) Cv.ReleaseImage(mom);
            if (houline != null) Cv.ReleaseImage(houline);
            if (houcircle != null) Cv.ReleaseImage(houcircle);
            if (skin != null) Cv.ReleaseImage(skin);
            if (haarface != null) Cv.ReleaseImage(haarface);
            if (bound != null) Cv.ReleaseImage(bound);
            if (ipl != null) Cv.ReleaseImage(ipl);
            if (hdcgrahics != null) Cv.ReleaseImage(hdcgrahics);
            if (blob != null) Cv.ReleaseImage(blob);
            if (blobcontour != null) Cv.ReleaseImage(blobcontour);
            if (filter != null) Cv.ReleaseImage(filter);
            if (bina != null) Cv.ReleaseImage(bina);
            if (gamma != null) Cv.ReleaseImage(gamma);
            if (calc != null) Cv.ReleaseImage(calc);
            if (inpaint != null) Cv.ReleaseImage(inpaint);
            if (dist != null) Cv.ReleaseImage(dist);
            if (pyrseg != null) Cv.ReleaseImage(pyrseg);
            if (pyrmean != null) Cv.ReleaseImage(pyrmean);
            if (match != null) Cv.ReleaseImage(match);
            if (templit != null) Cv.ReleaseImage(templit);
            if (optical != null) Cv.ReleaseImage(optical);
            if (snake != null) Cv.ReleaseImage(snake);
        }
    }
}
