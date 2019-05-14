using AxYIMAENCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    [Serializable]
    public class CShipShowBasicShape
    {
        public M_POINT[] shipPoint = new M_POINT[5];

        public CShipShowBasicShape()
        {
        }

        public M_POINT[] ReCalculateBoundryPoints(AxYimaEnc yimaEnc, int geoPosX, int geoPosY, double shipLength, double shipWidth, double shipCourse)
        {
            return YMUtils.GetShipBoundaryFromGeoCoor(yimaEnc, geoPosX, geoPosY, shipLength, shipWidth, shipCourse); 
        }

        public M_POINT[] RefreshBoundryByOffset(AxYimaEnc yimaEnc, int xOffect,int yOffect)
        {
            M_POINT[] point = { new M_POINT(0, 0), new M_POINT(0, 0), new M_POINT(0, 0), new M_POINT(0, 0), new M_POINT(0, 0) };
            for (int i = 0; i < 5; i++)
            {
                point[i].x += xOffect;
                point[i].y += yOffect;
            }
            return point;
        }
    }
}
