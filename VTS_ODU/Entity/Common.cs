using AxYIMAENCLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    public class Common
    {
        public static double PI = 3.14159265;
        public static double RAND_MAX = 0x7fff;
        public static double TIME_PER_STEP = 100.0;
        public static int RADAR_LAYER_POS = 0;
        public static int AIS_LAYER_POS = 1;
        public static int MOUSE_MOVE_POINT_DISTANCE = 10;
        public static int SHIP_TRACK_POINT_WIDTH = 6;
        public static int SCAN_LINE_POS = 0;
        public static int SCAN_LINE_NUM = 2048; //雷达扫描线密度
        public static int SCAN_LINE_NODE_NUM = 512; //雷达扫描线节点数量
        public static double METER_NAUTICAL_TRANSLATE = 1.852; //1海里(nmi)=1.852千米(km)
        public static int RADAR_SCANLINE__NODE_WIDTH = 5; //雷达扫描线节点间距
        public static double SHOW_VECTOR = 0.5;

        /// <summary>
        /// 检查是不是管理员
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public static bool CheckAdmin(String userRole)
        {
            if(userRole.Equals("0"))
            {
                return true;
            }
            return false;
        }

        private static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString = hexString.Insert(hexString.Length - 1, 0.ToString());
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// <summary>
        /// 字符串转Unicode
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>Unicode编码后的字符串</returns>
        public static string String2Unicode(string source)
        {
            var bytes = Encoding.Unicode.GetBytes(source);
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < bytes.Length; i += 2)
            {
                stringBuilder.AppendFormat("\\u{0:x2}{1:x2}", bytes[i + 1], bytes[i]);
            }
            return stringBuilder.ToString();
        }


        /// <summary>  
        /// 字符串转为UniCode码字符串  
        /// </summary>  
        /// <param name="s"></param>  
        /// <returns></returns>  
        public static string StringToUnicode(string s)
        {
            char[] charbuffers = s.ToCharArray();
            byte[] buffer;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < charbuffers.Length; i++)
            {
                buffer = System.Text.Encoding.Unicode.GetBytes(charbuffers[i].ToString());
                sb.Append(String.Format("\\u{0:X2}{1:X2}", buffer[1], buffer[0]));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 将对象序列化为二进制数据 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] SerializeToBinary(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, obj);

            byte[] data = stream.ToArray();
            stream.Close();

            return data;
        }

        /// <summary>
        /// 将二进制数据反序列化
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static object DeserializeWithBinary(byte[] data)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(data, 0, data.Length);
            stream.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(stream);

            stream.Close();

            return obj;
        }

        /// <summary>
        /// 将二进制数据反序列化为指定类型对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static T DeserializeWithBinary<T>(byte[] data)
        {
            return (T)DeserializeWithBinary(data);
        }

        /// <summary>
        /// 检查船已经存在
        /// </summary>
        /// <param name="mmsi"></param>
        /// <returns></returns>
        public static void ShipUpdateOrAdd(AxYimaEnc ymEncCtrl, List<CShip> shiplist, CShip recvShip)
        {
            if (recvShip == null || shiplist == null)
            {
                return;
            }
            if (shiplist.Count <= 0 && recvShip.shipUseOrNot >= 0)
            {
                recvShip.SetCurGeoPos(ymEncCtrl, recvShip.shipLatitude, recvShip.shipLongitude, false);
                recvShip.SetCurHeading(ymEncCtrl, recvShip.shipHeading, false);
                shiplist.Add(recvShip);
                recvShip.shipID = shiplist.Count - 1;
            }

            bool isAdd = true;
            for (int iship = 0; iship < shiplist.Count; iship++)
            {
                if (shiplist[iship].shipMMSI == recvShip.shipMMSI)
                {
                    shiplist[iship].SetCurGeoPos(ymEncCtrl, recvShip.shipLatitude, recvShip.shipLongitude, false);
                    shiplist[iship].SetCurHeading(ymEncCtrl, recvShip.shipHeading, false);
                    //shiplist[iship].shipTrack.AddTrack(recvShip.shipLatitude, recvShip.shipLongitude);
                    //更新船是否显示
                    shiplist[iship].shipUseOrNot = 1;
                    isAdd = false;
                    break;
                }
            }
            if (isAdd && recvShip.shipUseOrNot >= 0)
            {
                recvShip.SetCurGeoPos(ymEncCtrl, recvShip.shipLatitude, recvShip.shipLongitude, false);
                recvShip.SetCurHeading(ymEncCtrl, recvShip.shipHeading, false);
                shiplist.Add(recvShip);
                recvShip.shipID = shiplist.Count - 1;
            }
        }

        /// <summary>
        /// 检查雷达是否已经存在
        /// </summary>
        /// <param name="radarlist"></param>
        /// <param name="radarName"></param>
        /// <returns></returns>
        public static void RadarUpdateOrAdd(AxYimaEnc ymEncCtrl, List<CRadar> radarlist, CRadar recvRadar)
        {
            if (recvRadar == null || radarlist == null)
            {
                return;
            }
            if (radarlist.Count == 0 && recvRadar.radarUseOrNot >= 0)
            {
                SetRadarInfo(ymEncCtrl, 0, recvRadar);
                radarlist.Add(recvRadar);
            }
            bool isAdd = true;
            for (int iradar = 0; iradar < radarlist.Count; iradar++)
            {
                //判断雷达是否已经存在
                if (radarlist[iradar].radarName.Equals(recvRadar.radarName.Trim()))
                {
                    //通过雷达ID获取雷达POS
                    int radarMapPos = ymEncCtrl.GetRadarPosById(radarlist[iradar].radarMapID);
                    if (recvRadar.radarUseOrNot >= 0)
                    {
                        if (radarlist[iradar].radarLines != recvRadar.radarLines || radarlist[iradar].radarPoints != recvRadar.radarPoints)
                        {
                            radarlist[iradar].radarLines = recvRadar.radarLines;
                            radarlist[iradar].radarPoints = recvRadar.radarPoints;
                            radarlist[iradar].radarScanRadius = recvRadar.radarScanRadius;
                            ymEncCtrl.SetRadarBaseInfo(radarMapPos, recvRadar.radarLines, recvRadar.radarPoints, (float)recvRadar.radarScale, Color.Red.ToArgb());
                        }
                        recvRadar.radarMapID = radarlist[iradar].radarMapID;
                        recvRadar.radarMapPos = radarlist[iradar].radarMapPos;
                    }
                    else
                    {
                        //删除物标
                        bool removePointObject = ymEncCtrl.tmDeleteGeoObject(Common.RADAR_LAYER_POS, radarlist[iradar].radarMapPos);
                    }
                    isAdd = false;
                    break;
                }
            }
            if (isAdd && recvRadar.radarUseOrNot >= 0)
            {
                int count = radarlist.Count;
                SetRadarInfo(ymEncCtrl, count, recvRadar);
                radarlist.Add(recvRadar);
            }
        }

        /// <summary>
        /// 设置雷达信息
        /// </summary>
        /// <param name="ymEncCtrl"></param>
        /// <param name="cRadar"></param>
        public static void SetRadarInfo(AxYimaEnc ymEncCtrl, int count, CRadar cRadar)
        {
            cRadar.radarID = count;
            //添加雷达物标
            ymEncCtrl.tmAppendObjectInLayer(Common.RADAR_LAYER_POS, (int)M_GEO_TYPE.TYPE_POINT);
            cRadar.radarMapPos = ymEncCtrl.tmGetLayerObjectCount(Common.RADAR_LAYER_POS) - 1;
            ymEncCtrl.tmSetPointObjectCoor(Common.RADAR_LAYER_POS, cRadar.radarMapPos, cRadar.radarGeoPosX, cRadar.radarGeoPosY);
            ymEncCtrl.tmSetPointObjectStyleRefLib(Common.RADAR_LAYER_POS, cRadar.radarMapPos, 57, false, 0, 1, 0);
            ymEncCtrl.tmSetObjectAttrValueString(Common.RADAR_LAYER_POS, cRadar.radarMapPos, 0, "11");
            //设置ym雷达对象
            cRadar.radarMapID = ymEncCtrl.AddOneRadar();
            //通过雷达ID获取雷达POS
            int radarMapPos = ymEncCtrl.GetRadarPosById(cRadar.radarMapID);
            ymEncCtrl.SetRadarShowState(radarMapPos, true, true);
            //设置雷达基础信息，扫描线密度，节点数量，节点间距，雷达整体颜色
            ymEncCtrl.SetRadarBaseInfo(radarMapPos, cRadar.radarLines, cRadar.radarPoints, (float)cRadar.radarScale, Color.Red.ToArgb());
            //设置雷达的位置
            ymEncCtrl.SetRadarCenterGeoPo(radarMapPos, cRadar.radarGeoPosX, cRadar.radarGeoPosY);
        }

        /// <summary>
        /// 检查AIS是否已经存在
        /// </summary>
        /// <param name="aislist"></param>
        /// <param name="aisName"></param>
        /// <returns></returns>
        public static void AisUpdateOrAdd(AxYimaEnc ymEncCtrl, List<CAis> aislist, CAis recvrAis)
        {
            if (recvrAis == null || aislist == null)
            {
                return;
            }
            if (aislist.Count == 0 && recvrAis.aisUseOrNot >= 0)
            {
                SetAisInfo(ymEncCtrl, 0, recvrAis);
                aislist.Add(recvrAis);
            }
            bool isAdd = true;
            for (int iais = 0; iais < aislist.Count; iais++)
            {
                if (aislist[iais].aisName.Equals(recvrAis.aisName))
                {
                    if(recvrAis.aisUseOrNot >= 0)
                    {
                        //更新扫描半径
                        if (aislist[iais].aisScanRadius != recvrAis.aisScanRadius)
                        {
                            aislist[iais].aisScanRadius = recvrAis.aisScanRadius;
                        }
                        //更新是否可见
                        if (aislist[iais].aisUseOrNot != recvrAis.aisUseOrNot)
                        {
                            aislist[iais].aisUseOrNot = recvrAis.aisUseOrNot;
                        }
                    }
                    else
                    {
                        //删除物标
                        bool removePointObject = ymEncCtrl.tmDeleteGeoObject(Common.AIS_LAYER_POS, aislist[iais].aisMapPos);
                    }
                    isAdd = false;
                    break;
                }
            }
            if (isAdd && recvrAis.aisUseOrNot >= 0)
            {
                int count = aislist.Count;
                SetAisInfo(ymEncCtrl, count, recvrAis);
                aislist.Add(recvrAis);
            }
        }

        /// <summary>
        /// 设置雷达信息
        /// </summary>
        /// <param name="ymEncCtrl"></param>
        /// <param name="cRadar"></param>
        public static void SetAisInfo(AxYimaEnc ymEncCtrl, int count, CAis cAis)
        {
            cAis.aisID = count;
            //添加AIS基站物标
            ymEncCtrl.tmAppendObjectInLayer(1, (int)M_GEO_TYPE.TYPE_POINT);
            cAis.aisMapPos = ymEncCtrl.tmGetLayerObjectCount(1) - 1;
            ymEncCtrl.tmSetPointObjectCoor(1, cAis.aisMapPos, cAis.aisGeoPosX, cAis.aisGeoPosY);
            //物标样式
            ymEncCtrl.tmSetPointObjectStyleRefLib(1, cAis.aisMapPos, 64, false, 0, 1, 0);
        }

        /// <summary>
        /// 检查船是否在圆内
        /// </summary>
        /// <param name="shipPoint">船在屏幕上的位置</param>
        /// <returns>true 在园内，false 在圆外</returns>
        public static bool CheckShipInCircle(M_POINT centerPoint, M_POINT shipPoint, double pxRadius)
        {
            int x_len = Math.Abs(Math.Abs(shipPoint.x) - Math.Abs(centerPoint.x));
            int y_len = Math.Abs(Math.Abs(shipPoint.y) - Math.Abs(centerPoint.y));
            return (Math.Sqrt((x_len) * (x_len) + (y_len) * (y_len)) < pxRadius);
        }

        /// <summary>
        /// 生成随机九位MMSI
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomMMSI()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            return rand.Next(100000000, 1000000000);
        }

        /// <summary>
        /// 生成随机六位ODUID
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomODUID()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            return rand.Next(100000, 999999);
        }

        /// <summary>
        /// 生成随机5位MMSI
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomUUID()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            return rand.Next(10000, 100000);
        }

        /// <summary>
        /// 获取船舶模型名称
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static String GetModelName(int model)
        {
            if(model == 1)
            {
                return "5万吨";
            }
            else if(model == 2)
            {
                return "巡逻30米";
            }
            else if(model == 3)
            {
                return "巡逻40米";
            }
            else if(model == 4)
            {
                return "巡逻60米";
            }
            else if (model == 5)
            {
                return "海监1500";
            }
            return "未知模型"; 
        }

        /// <summary>
        /// 根据num获取画刷
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static SolidBrush GetBrush(String data)
        {
            if (Convert.ToInt32(data) == 0)
            {
                //0 无障碍，绿色
                return new SolidBrush(Color.Green);
            }
            //1 有障碍，红色
            return new SolidBrush(Color.Red);
        }

        /// <summary>
        /// 根据num获取画刷
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Pen GetPen(int num)
        {
            if (num == 0)
            {
                //0 无障碍，绿色
                return new Pen(Color.Red);
            }
            //1 有障碍，红色
            return new Pen(Color.Green);
        }

        /// <summary>
        /// 根据num获取画刷
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int GetPenColor(String data)
        {
            if (Convert.ToInt32(data) == 0)
            {
                //0 无障碍，绿色
                return new M_COLOR(0, 255, 0).ToInt();
            }
            //1 有障碍，红色
            return new M_COLOR(255, 0, 0).ToInt();
        }

        /// <summary>
        /// 检查索引是否在列表中
        /// </summary>
        /// <param name="indexList"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool CheckIndexInList(List<int> indexList,int index)
        {
            if (indexList.Count == 0)
            {
                return false;
            }
            foreach (int i in indexList.ToArray())
            {
                if(i == index)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 处理雷达数据
        /// </summary>
        /// <param name="num"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static int[] DealRadarData(int num, int count)
        {
            String basePath = System.Windows.Forms.Application.StartupPath;
            int[] dataArray = new int[count];
            using (System.IO.StreamReader dataFile = new StreamReader(basePath + "\\data\\" + num + ".json"))
            {
                String[] info = dataFile.ReadLine().Replace("[", "").Replace("]", "").Split(',');
                for (int j = 0; j < info.Length; j++)
                {
                    dataArray[j] = Convert.ToInt32(info[j]);
                    if (dataArray[j] > 1 || dataArray[j] < 0)
                        dataArray[j] = 0;
                }
            }
            return dataArray;
        }

        /// <summary>
        /// 处理雷达数据
        /// </summary>
        /// <param name="num"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static String DealRadarData2(int num, int count)
        {
            String basePath = System.Windows.Forms.Application.StartupPath;
            String[] info = new string[count];
            using (System.IO.StreamReader dataFile = new StreamReader(basePath + "\\data\\" + num + ".json"))
            {
                info = dataFile.ReadLine().Replace("[", "").Replace("]", "").Split(',');
                for (int j = 0; j < info.Length; j++)
                {
                    if (Convert.ToInt32(info[j]) > 1 || Convert.ToInt32(info[j]) < 0)
                    {
                        info[j] = "0";
                    }
                }
            }
            return String.Join("", info);
        }

        /// <summary> 
        /// 放大缩小图片尺寸 
        /// </summary> 
        /// <param name="picPath"></param> 
        /// <param name="reSizePicPath"></param> 
        /// <param name="iSize"></param> 
        /// <param name="format"></param> 
        public void PicSized(string picPath, string reSizePicPath, int iSize, ImageFormat format)
        {
            Bitmap originBmp = new Bitmap(picPath);
            int w = originBmp.Width * iSize;
            int h = originBmp.Height * iSize;
            Bitmap resizedBmp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(resizedBmp);
            //设置高质量插值法   
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度   
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            //消除锯齿 
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(originBmp, new Rectangle(0, 0, w, h), new Rectangle(0, 0, originBmp.Width, originBmp.Height), GraphicsUnit.Pixel);
            resizedBmp.Save(reSizePicPath, format);
            g.Dispose();
            resizedBmp.Dispose();
            originBmp.Dispose();
        }

        /// <summary>
        /// 判断是否是纯数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNumeric(string str) //接收一个string类型的参数,保存到str里
        {
            if (str == null || str.Length == 0)    //验证这个参数是否为空
                return false;                           //是，就返回False
            ASCIIEncoding ascii = new ASCIIEncoding();//new ASCIIEncoding 的实例
            byte[] bytestr = ascii.GetBytes(str);         //把string类型的参数保存到数组里

            foreach (byte c in bytestr)                   //遍历这个数组里的内容
            {
                if (c < 48 || c > 57)                          //判断是否为数字
                {
                    return false;                              //不是，就返回False
                }
            }
            return true;                                        //是，就返回True
        }

        /// <summary>
        /// 检查数字是否在列表中
        /// </summary>
        /// <param name="scanList"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool CheckNumInList(List<int> scanList,int num)
        {
            if(scanList.Count == 0)
            {
                return false;
            }
            foreach(int index in scanList)
            {
                if(index == num)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 从雷达图像中获取数据
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="centerx"></param>
        /// <param name="centery"></param>
        /// <param name="pointSpace"></param>
        /// <returns></returns>
        public static List<String> GetRadarData(Bitmap bitmap,double centerx, double centery, double pointSpace)
        {
            double degree = 360.0 / 2048.0;
            //double centerx = 697.99999999999992, centery = 392.41110404427445, pointSpace = 0.6290081998856527;
            Color color = new Color();
            int[] dataArray = new int[512];
            List<String> datas = new List<String>();
            double x = 0.0d, y = 0.0d, tmp_degree = 0.0d, tmp_r = 0.0d;
            StringBuilder data = new StringBuilder(512);
            for (int i = 0; i < 2048; i++)
            {
                if (i < 512)
                {
                    for (int j = 0; j < 512; j++)
                    {
                        //第一象限 x+ y-
                        tmp_degree = 90.0 - ((i + 1) * degree);
                        tmp_r = pointSpace * j;
                        x = tmp_r * Math.Cos(tmp_degree * Math.PI / 180); //求出来的x长度
                        y = tmp_r * Math.Sin(tmp_degree * Math.PI / 180); //求出来的y长度
                        color = bitmap.GetPixel(Convert.ToInt32(centerx + x), Convert.ToInt32(centery - y));
                        if (color.R == 255 && color.G < 255 && color.B < 255)
                        {
                            dataArray[j] = 1; //红色遮挡1
                        }
                        else
                        {
                            dataArray[j] = 0; //绿色无遮挡0
                        }
                    }
                }
                else if (i >= 512 && i < 1024)
                {
                    for (int j = 0; j < 512; j++)
                    {
                        //第二象限 x+ y+
                        tmp_degree = ((i + 1) * degree) - 90.0;
                        tmp_r = pointSpace * j;
                        x = tmp_r * Math.Cos(tmp_degree * Math.PI / 180); //求出来的x长度
                        y = tmp_r * Math.Sin(tmp_degree * Math.PI / 180); //求出来的y长度
                        color = bitmap.GetPixel(Convert.ToInt32(centerx + x), Convert.ToInt32(centery + y));
                        if (color.R == 255 && color.G < 255 && color.B < 255)
                        {
                            dataArray[j] = 1; //红色遮挡1
                        }
                        else
                        {
                            dataArray[j] = 0; //绿色无遮挡0
                        }
                    }
                }
                else if (i >= 1024 && i < 1536)
                {
                    for (int j = 0; j < 512; j++)
                    {
                        //第三象限 x- y+
                        tmp_degree = ((i + 1) * degree) - 180.0;
                        tmp_r = pointSpace * j;
                        x = tmp_r * Math.Cos(tmp_degree * Math.PI / 180); //求出来的x长度
                        y = tmp_r * Math.Sin(tmp_degree * Math.PI / 180); //求出来的y长度
                        color = bitmap.GetPixel(Convert.ToInt32(centerx - x), Convert.ToInt32(centery + y));
                        if (color.R == 255 && color.G < 255 && color.B < 255)
                        {
                            dataArray[j] = 1; //红色遮挡1
                        }
                        else
                        {
                            dataArray[j] = 0; //绿色无遮挡0
                        }
                    }
                }
                else if (i >= 1536)
                {
                    for (int j = 0; j < 512; j++)
                    {
                        //第四象限 x- y-
                        tmp_degree = ((i + 1) * degree) - 270.0;
                        tmp_r = pointSpace * j;
                        x = tmp_r * Math.Cos(tmp_degree * Math.PI / 180); //求出来的x长度
                        y = tmp_r * Math.Sin(tmp_degree * Math.PI / 180); //求出来的y长度
                        color = bitmap.GetPixel(Convert.ToInt32(centerx - x), Convert.ToInt32(centery - y));
                        if (color.R == 255 && color.G < 255 && color.B < 255)
                        {
                            dataArray[j] = 1; //红色遮挡1
                        }
                        else
                        {
                            dataArray[j] = 0; //绿色无遮挡0
                        }
                    }
                }
                datas.Add(InteropEncDotNet.GetStringFromIntArray(dataArray, 512));
            }
            return datas;
        }

        /// <summary>
        /// 根据radarID获取雷达对象
        /// </summary>
        /// <param name="radarList"></param>
        /// <param name="radarID"></param>
        /// <returns></returns>
        public static CRadar GetRadarByRadarID(List<CRadar> radarList,int radarID)
        {
            foreach(CRadar radar in radarList.ToArray())
            {
                if (radar.radarID == radarID)
                    return radar;
            }
            return null;
        }

        /// <summary>
        /// radar跟踪名称
        /// </summary>
        /// <param name="radarList"></param>
        /// <param name="scanList"></param>
        /// <returns></returns>
        public static String GetRadarNameListByScanList(List<CRadar> radarList, List<int> scanList)
        {
            if (radarList == null || scanList == null || radarList.Count == 0 || scanList.Count == 0)
            {
                return "";
            }
            StringBuilder data = new StringBuilder();
            foreach (CRadar radar in radarList.ToArray())
            {
                foreach(int id in scanList.ToArray())
                {
                    if (radar.radarID == id)
                    {
                        data.Append(radar.radarName+",");
                    }
                }
            }
            String result = data.ToString();
            result = result.Remove(result.Length - 1);
            return result;
        }

        /// <summary>
        /// ais跟踪名称
        /// </summary>
        /// <param name="aisList"></param>
        /// <param name="scanList"></param>
        /// <returns></returns>
        public static String GetAisNameListByScanList(List<CAis> aisList, List<int> scanList)
        {
            if (aisList == null || scanList == null || aisList.Count == 0 || scanList.Count == 0)
            {
                return "";
            }
            StringBuilder data = new StringBuilder();
            foreach (CAis ais in aisList.ToArray())
            {
                foreach (int id in scanList.ToArray())
                {
                    if (ais.aisID == id)
                    {
                       data.Append(ais.aisName+",");
                    }
                }
            }
            String result = data.ToString();
            result = result.Remove(result.Length-1);
            return result;
        }
    }
}
