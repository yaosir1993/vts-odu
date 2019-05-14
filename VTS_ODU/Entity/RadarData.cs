using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    public class RadarData
    {
        //标识位	雷达编号	经度	纬度	高度	量程	比例尺	宽	高	数据	结束符
        //VTSRADAR-D;00001;123.24;30.12;20.5;6000.0;2.345;5;5;0101001101010100111001110#
        private String head;
        private String id;
        private double lng;
        private double lat;
        private double height;
        private double range;
        private double scale;
        private double depth;
        private int pointCount;
        private int lineCount;
        private int[][] datas;

        public string Head { get => head; set => head = value; }
        public string Id { get => id; set => id = value; }
        public double Lng { get => lng; set => lng = value; }
        public double Lat { get => lat; set => lat = value; }
        public double Height { get => height; set => height = value; }
        public double Range { get => range; set => range = value; }
        public double Scale { get => scale; set => scale = value; }
        public double Depth { get => depth; set => depth = value; }
        public int PointCount { get => pointCount; set => pointCount = value; }
        public int LineCount { get => lineCount; set => lineCount = value; }
        public int[][] Datas { get => datas; set => datas = value; }


        // 定义一个静态变量来保存类的实例
        private static RadarData uniqueRadarData;
        // 定义一个标识确保线程同步
        private static readonly object locker = new object();

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static RadarData GetInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断就可以了
            if (uniqueRadarData == null)
            {
                lock (locker)
                {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (uniqueRadarData == null)
                    {
                        uniqueRadarData = new RadarData();
                    }
                }
            }
            return uniqueRadarData;
        }

        /// <summary>
        /// 获取解析完雷达数据的雷达数据对象
        /// </summary>
        /// <returns></returns>
        public static RadarData getRadarData(byte[] data, int len)
        {
            //获取单例对象
            RadarData radarData = RadarData.GetInstance();
            int pointPos = 0;
            int linePos = 0;
            int[][] datas = null;
            int counts = 0;
            for (int ix = 0; ix < len; ix++)
            {
                char temp = (char)data[ix];
                if (datas == null)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        StringBuilder builder = new StringBuilder();
                        while (ix < len && temp != ';')
                        {
                            builder.Append((char)data[ix]);
                            temp = (char)data[++ix];
                        }
                        temp = (char)data[++ix];
                        switch (i)
                        {
                            case 0: radarData.Head = builder.ToString(); break;
                            case 1: radarData.Id = builder.ToString(); break;
                            case 2: radarData.Lng = Convert.ToDouble(builder.ToString()); break;
                            case 3: radarData.Lat = Convert.ToDouble(builder.ToString()); break;
                            case 4: radarData.Height = Convert.ToDouble(builder.ToString()); break;
                            case 5: radarData.Range = Convert.ToDouble(builder.ToString()); break;
                            case 6: radarData.Scale = Convert.ToDouble(builder.ToString()); break;
                            case 7: radarData.Depth = Convert.ToDouble(builder.ToString()); break;
                            case 8: radarData.PointCount = Convert.ToInt32(builder.ToString()); break;
                            case 9: radarData.LineCount = Convert.ToInt32(builder.ToString()); break;
                        }
                    }
                    datas = new int[radarData.LineCount][];
                    for (int k = 0; k < radarData.LineCount; k++)
                    {
                        datas[k] = new int[radarData.PointCount];
                    }
                }
                //最后一个#号不进行处理
                if (ix == (len - 1))
                {
                    break;
                }
                int value = (int)data[ix] > 127 ? (int)(data[ix] - 256) : (int)data[ix];
                //数据保存在二维数组
                int lp = Math.Abs(value);
                counts += lp;
                if ((pointPos + lp) > radarData.PointCount)
                {
                    linePos++;
                    pointPos = 0;
                }
                for (int j = 0; j < lp; j++)
                {
                    if (value > 0)
                    {
                        //生成ip个1,数组默认为0
                        datas[linePos][j + pointPos] = 1;
                    }
                }
                pointPos += lp;
            }
            radarData.Datas = datas;
            return radarData;
        }
    }
}
