using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCvSharpPT.Entity
{
    public class eMenu
    {
        private string menuCd;
        private string menuNm;
        private int dispOrder;
        private int imgIdx;

        public eMenu()
        {
            menuCd = "";
            menuNm = "";
            dispOrder = 0;
            imgIdx = -1;
        }

        public eMenu(string sMenuCd, string sMenuNm, int iDispOrder, int iImgIdx)
        {
            menuCd = sMenuCd;
            menuNm = sMenuNm;
            dispOrder = iDispOrder;
            imgIdx = iImgIdx;
        }

        public string MenuCd
        {
            get { return menuCd; }
            set { menuCd = value; }
        }
        public string MenuNm
        {
            get { return menuNm; }
            set { menuNm = value; }
        }
        public int DispOrder
        {
            get { return dispOrder; }
            set { dispOrder = value; }
        }
        public int ImgIdx
        {
            get { return imgIdx; }
            set { imgIdx = value; }
        }

    }
}
