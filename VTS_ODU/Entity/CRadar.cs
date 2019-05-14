using AxYIMAENCLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    [Serializable]
    public class CRadar
    {
        public int radarID { get; set; } //雷达ID
        public int radarMapID { get; set; } //雷达在海图中的ID
        public String radarName { get; set; }    //雷达名称
        public double radarScanRadius { get; set; }   //雷达扫描半径
        public double radarPixelRadius { get; set; }   //雷达基站像素半径
        public double radarHigh { get; set; }    //雷达高度
        public double radarRange { get; set; }   //雷达量程
        public double radarDepth { get; set; }   //水深
        public int radarWidth { get; set; }    //雷达长度
        public int radarHeight { get; set; }   //雷达宽度
        public double radarScale { get; set; }   //雷达比例尺
        public int radarGeoPosX { get; set; }    //雷达经纬度坐标X
        public int radarGeoPosY { get; set; }   //雷达经纬度坐标Y
        public int radarMapPos { get; set; }
        public int radarUseOrNot { get; set; }  //雷达是否启用
        public int radarShowType { get; set; }  //0 完全显示 1余晖显示
        public Color radarShowColor { get; set; }  //雷达显示颜色
        public int radarLines { get; set; }  //雷达扫面线数量
        public int radarPoints { get; set; }  //雷达像素点个数
        public int[][] radarDatas { get; set; } //雷达数据

        public CRadar() { }

        public CRadar(int _radarID, String _radarName, 
            double _radarHigh, double _radarRange, int _radarGeoPosX,
            int _radarGeoPosY, int _radarWidth, int _radarHeight, double _radarScale, int _radarUseOrNot)
        {
            radarID = _radarID;
            radarName = _radarName;
            radarWidth = _radarWidth;
            radarHeight = _radarHeight;
            radarHigh = _radarHigh;
            radarScale = _radarScale;
            radarRange = _radarRange;
            radarGeoPosX = _radarGeoPosX;
            radarGeoPosY = _radarGeoPosY;
            radarUseOrNot = _radarUseOrNot;
            radarLines = 2048;
            radarPoints = 512;
        }

        /// <summary>
        /// 判断两个雷达相同
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if ((obj.GetType().Equals(this.GetType())) == false)
            {
                return false;
            }
            CRadar radar = (CRadar)obj;
            return this.radarID.Equals(radar.radarID);
        }

        /// <summary>
        /// 重写GetHashCode方法（重写Equals方法必须重写GetHashCode方法，否则发生警告
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.radarID.GetHashCode();
        }
    }
}
