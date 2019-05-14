using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    public class CRadarPackage
    {
        public int radarID { get; set; } //雷达标识
        public double radarCenterX { get; set; }  //雷达数据索引
        public double radarCenterY { get; set; }  //雷达数据索引
        public double radarPixelWidth { get; set; }  //雷达数据索引

        public CRadarPackage()
        {
            radarCenterX = 0.0d;
            radarCenterY = 0.0d;
            radarPixelWidth = 0.0d;
        }

        public CRadarPackage(int _radarID, double _radarCenterX, double _radarCenterY, double _radarPixelWidth)
        {
            radarID = _radarID;
            radarCenterX = _radarCenterX;
            radarCenterY = _radarCenterY;
            radarPixelWidth = _radarPixelWidth;
        }
    }
}
