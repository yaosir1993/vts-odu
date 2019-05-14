using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VesselMonitor.Main
{

    public enum LOAL_MAP_NAME
    {
        GoogleRoadMap = 0,//谷歌街道地图
        GoogleSatelliteMap = 1,//谷歌卫星地图
        
        TencentStrMap = 2,//腾讯街道地图

        //大于10为百度切割模式
        BaiduStaMap = 11, //百度
        BaiduStrMap = 12,
    };
    public enum SHIP_TYPE //图层的属性，注意：在少数情况下，图层可能不是唯一的地理类型
    {
        CLASS_A = 1,
        CLASS_B = 2,
        BeiDou = 3
    };
    public class Ais_Type_Style
    {
        public int iShipType = 0;//船舶类型
        public int iOnlineAisTypeId = 0;//在线船舶样式的id
        public int iOfflineAisTypeId = 0;//离线船舶样式的id

        /// <summary>
        /// 设置样式信息
        /// </summary>
        /// <param name="iType">船舶类型标识</param>
        /// <param name="iOnLineId">在线船舶样式id</param>
        /// <param name="iOffLineId">在线船舶样式id</param>
        public void SetAisTypeInfo(int iType, int iOnLineId, int iOffLineId)
        { 
            this.iShipType = iType;
            this.iOnlineAisTypeId = iOnLineId;
            this.iOfflineAisTypeId = iOffLineId;
        }
    }
    public class Class_Parameter
    {
        public ArrayList arrAisTypeStyleList;//船舶样式列表信息，元素结构体为：Ais_Type_Style

        public Class_Parameter()
        {
            this.arrAisTypeStyleList = new ArrayList();
        }

        public Ais_Type_Style GetShipTypeStyleInfoByType(int iType)
        {
            
            for (int i = 0; i < this.arrAisTypeStyleList.Count; i++)
            {
                if (((Ais_Type_Style)this.arrAisTypeStyleList[i]).iShipType == iType)
                { 
                    return (Ais_Type_Style)this.arrAisTypeStyleList[i];
                }
            }

            Ais_Type_Style curAisTypeStyle = new Ais_Type_Style();
            return curAisTypeStyle;
        }
    }
}
