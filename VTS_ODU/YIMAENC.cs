using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace vts_odu
{    
    public enum M_GEO_TYPE : int //物标的几何属性
    {
        TYPE_NULL = -1,
        TYPE_POINT = 0,
        TYPE_LINE = 2,
        TYPE_FACE = 3,
        TYPE_COMBINED_OBJECT = 10
    };

    //海图工具类型
    enum M_TOOl_TYPE
    {
        TYPE_NONE = 0,
        TYPE_EBL = 1, //电子方位线
        TYPE_MEASURE_DIS = 2, //
        TYPE_MEASURE_AREA = 3,//测面积
        TYPE_AREA_ZOOM_IN = 4//区域缩放
    };
    //线类型
    public enum SPECIAL_LINE_TYPE
    {
        NO_SPECIAL_TYPE = 0,
        RECTANGLE_LN_TYPE = 10,
        CIRCLE_LN_TYPE = 20,
        ELLIPSE_LN_TYPE = 30,
        ARC_LN_TYPE = 40,
        PIE_LN_TYPE = 41,
        BOW_LN_TYPE = 42,
        SECTOR_LN_TYPE = 50,
        CURVE_LN_TYPE = 60,
        CURVE_LN_TYPE_WITH_HEAD_ARROW = 61,
        CURVE_LN_TYPE_WITH_HAED_TAIL_ARROW = 62,
        SINGLE_ARROW_LN_TYPE = 80,
    }

    //物标特殊类型//————————————————————————————————————————————————————
    enum SPECIAL_OBJ_TYPE
    {
        NO_SPECIAL_TYPE = 0,	//常规，适用线、面
        RECTANGLE_TYPE = 10,	//矩形，适用线、面 
        CIRCLE_TYPE = 20,		//圆，适用线、面
        ELLIPSE_TYPE = 30,		//椭圆，适用线、面
        ARC_LN_TYPE = 40,		//弧形，适用线
        PIE_LN_TYPE = 41,		//扇形，适用线
        BOW_LN_TYPE = 42,		//弓形，适用线
        SECTOR_LN_TYPE = 50,	//扇区，适用线
        CURVE_LN_TYPE = 60,		//圆滑曲线，适用线
        CURVE_WITH_HEAD_ARROW_LN_TYPE = 61, //带单箭头圆滑曲线，适用线
        CURVE_WITH_HAED_TAIL_ARROW_LN_TYPE = 62, //带双箭头圆滑曲线，适用线 
        SINGLE_ARROW_LN_TYPE = 80,  //单箭头，适用线
    };



    /// <summary>
    /// 海图显示的信息模式
    /// </summary>
    public enum DISPLAY_CATEGORY_NUM : short
    {
        DISPLAY_BASE = 0,
        DISPLAY_STANDARD = 1,
        DISPLAY_ALL = 2,           
    }

    /// <summary>
    /// 海图显示的场景模式
    /// </summary>
    public enum ENC_COLOR_GROUP:short
    {
	    DAY_BRIGHT = 1,
	    DAY_WHITEBACK = 2,
	    DAY_BLACKBACK = 3,
	    DUSK = 4,
	    NIGHT = 5
    };

    public enum LAYER_GEO_TYPE //图层的属性，注意：在少数情况下，图层可能不是唯一的地理类型
    {
        LAYER_GEO_TYPE_NULL = 0,
        ALL_POINT = 1,
        ALL_LINE = 2,
        ALL_FACE = 3,
        ALL_STRING = 6,
        //MULTIPLE_GEO_TYPE = 4
        MULTIPLE_GEO_TYPE = 5
    };
    public enum UNDO_OPERATION_TYPE
    { 
	    ADD_GEO_OBJ = 3,
	    DEL_GEO_OBJ = 4,
	    MOD_GEO_OBJ = 5
    }

    public class M_COLOR
    {
        byte r;
        byte g;
        byte b;
        byte reserve;

        public M_COLOR()
        {
            r = g = b = reserve = 0;
        }

        public M_COLOR(byte R, byte G, byte B)
        {
            r = R;
            g = G;
            b = B;
            reserve = 0;
        }

        public M_COLOR(byte R, byte G, byte B, byte rsv)
        {
            r = R;
            g = G;
            b = B;
            reserve = rsv;
        }

        public int ToInt()
        {
            byte[] buffer = new byte[4];
            buffer[0] = r;
            buffer[1] = g;
            buffer[2] = b;
            buffer[3] = reserve;
            return BitConverter.ToInt32(buffer, 0);
        }

        public void FromInt(int intColorVal)
        {
            byte[] buffer = new byte[4];

            buffer = BitConverter.GetBytes(intColorVal);
            r = buffer[0];
            g = buffer[1];
            b = buffer[2];
            reserve = buffer[3];  
        } 

        public Color ToColor()
        {
            return System.Drawing.Color.FromArgb(r, g, b);  
        }  
    };

    [Serializable]
    public class M_POINT
    {
        public int x;
        public int y;

        public M_POINT()
        {
            x = y = 0;
        }

        public M_POINT(int poX, int poY)
        {
            x = poX;
            y = poY;
        }

        public static M_POINT operator +(M_POINT left, M_POINT right)
        {
            return new M_POINT(left.x + right.x, left.y + right.y);
        }

        public static M_POINT operator -(M_POINT left, M_POINT right)
        {
            return new M_POINT(left.x - right.x, left.y - right.y);
        }

        public M_POINT(byte[] strPoint)
        {
            x = BitConverter.ToInt32(strPoint, 0);
            y = BitConverter.ToInt32(strPoint, 4);  
        }

        public byte[] ToBytes()
        {
            byte[] buffer = new byte[8]; 
            byte[] buf1 = BitConverter.GetBytes(x);
            Array.Copy(buf1, 0, buffer, 0, 4);
            byte[] buf2 = BitConverter.GetBytes(y);
            Array.Copy(buf2, 0, buffer, 4, 4); 

            return buffer;
        } 
    };

    public class MEM_GEO_OBJ_POS //geo object position in memory-maps
    { 
        public int memMapPos;
        public int layerPos;
        public int innerLayerPos;

        public MEM_GEO_OBJ_POS()
        {
            memMapPos = layerPos = innerLayerPos = -1;
        }

        public MEM_GEO_OBJ_POS(int mapPos, int lyrPos, int objPos)
        {
            memMapPos = mapPos;
            layerPos = lyrPos;
            innerLayerPos = objPos;
        }

        public MEM_GEO_OBJ_POS(byte[] strObjPos)
        {  
            memMapPos = BitConverter.ToInt32(strObjPos, 0);
            layerPos = BitConverter.ToInt32(strObjPos, 4);
            innerLayerPos = BitConverter.ToInt32(strObjPos, 8); 
        }

        public byte[] ToBytes()
        {
            byte[] buffer = new byte[12]; 
            byte[] buf1 = BitConverter.GetBytes(memMapPos);
            Array.Copy(buf1, 0, buffer, 0, 4);
            byte[] buf2 = BitConverter.GetBytes(layerPos);
            Array.Copy(buf2, 0, buffer, 4, 4);
            byte[] buf3 = BitConverter.GetBytes(innerLayerPos);
            Array.Copy(buf3, 0, buffer, 8, 4);

            return buffer;
        } 
    };

    public class M_GEO_OBJ_POS //geo object position in a specific map
    {
        public int layerPos;
        public int innerLayerObjectPos;

        public M_GEO_OBJ_POS()
        {
            layerPos = -1;
            innerLayerObjectPos = -1;
        }

        public M_GEO_OBJ_POS(int lyrPos, int inLyrPos)
        {
            layerPos = lyrPos;
            innerLayerObjectPos = inLyrPos;
        }

        public M_GEO_OBJ_POS(byte[] strObjPos)
        {  
            layerPos = BitConverter.ToInt32(strObjPos, 0);
            innerLayerObjectPos = BitConverter.ToInt32(strObjPos, 4); 
        }

        public byte[] ToBytes()
        {
            byte[] buffer = new byte[8];
            byte[] buf1 = BitConverter.GetBytes(layerPos);
            Array.Copy(buf1, 0, buffer, 0, 4);
            byte[] buf2 = BitConverter.GetBytes(innerLayerObjectPos);
            Array.Copy(buf2, 0, buffer, 4, 4); 

            return buffer;
        } 
    };

    public class InteropEncDotNet
    {

        static DateTime m_dt = new DateTime(2000, 1, 1, 0, 0, 0);//copy from vs2013
        private static DateTime m_CheckDateTime = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        public static int DateTime2Int(DateTime dt)
        {
            TimeSpan ts = dt.Subtract(m_CheckDateTime).Duration();
            int iResult = (int)ts.TotalSeconds;
            DateTime aa = Int2DateTime(iResult);
            return iResult;
        }

        public static DateTime Int2DateTime(int iSecondCount)
        {
            DateTime dtResult = m_CheckDateTime.AddSeconds(iSecondCount);
            return dtResult;
        }

        public static string MTime2String(int iTime)
        {
            DateTime dt = Int2DateTime(iTime);
            string strResult = "";
            strResult = dt.Year + "-" + dt.Month + "-" + dt.Day + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;

            return strResult;
        }

        public static string DateTime2String(DateTime dt)
        {
            string strResult = "";
            strResult = dt.Year + "-" + dt.Month + "-" + dt.Day + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;
            return strResult;
        }

        public static string GetDegreeStringFromGeoCoor(bool bLongOrLatiCoor, int coorVal, int coorMultiFactor)
        {
            string retDegreeString = "";
            double fArcByDegree = coorVal / (float)coorMultiFactor;

            if (bLongOrLatiCoor)
            {
                if (fArcByDegree >= 0)
                {
                    retDegreeString = ((int)fArcByDegree).ToString() + "度" + Math.Round((60 * (fArcByDegree - (int)fArcByDegree)), 3).ToString() + "分E";
                }
                else
                {
                    fArcByDegree = -fArcByDegree;
                    retDegreeString = ((int)fArcByDegree).ToString() + "度" + Math.Round((60 * (fArcByDegree - (int)fArcByDegree)), 3).ToString() + "分W";
                }
            }
            else
            {
                if (fArcByDegree >= 0)
                {
                    retDegreeString = ((int)fArcByDegree).ToString() + "度" + Math.Round((60 * (fArcByDegree - (int)fArcByDegree)), 3).ToString() + "分N";
                }
                else
                {
                    fArcByDegree = -fArcByDegree;
                    retDegreeString = ((int)fArcByDegree).ToString() + "度" + Math.Round((60 * (fArcByDegree - (int)fArcByDegree)), 3).ToString() + "分S";
                }
            }

            return retDegreeString;
        }

        public static int DataTime2Int(DateTime curDateTime)
        {
            TimeSpan span = curDateTime - m_dt;
            int iResult = (int)span.TotalSeconds;
            return iResult;
        }
        public static DateTime Int2DataTime(int iDateTime)
        {
            DateTime curDateTime = m_dt.AddSeconds(iDateTime);
            return curDateTime;
        }




        public static int GetGeoCoorFromDegreeString(bool bLongOrLatiCoor, string strDegreeString)
        {
            int iCoorGeoValue = 0;
            int iCurDegreeValue = 0;
            double dCurFenValue = 0;
            int iSign = 1;
            if (strDegreeString.IndexOf("度") != -1 || strDegreeString.IndexOf("°") != -1
                || strDegreeString.IndexOf("分") != -1 || strDegreeString.IndexOf("′") != -1)
            {
                char cSplitDegree = '度';
                char cSplitFen = '分';
                if (strDegreeString.IndexOf("°") != -1)
                {
                    cSplitDegree = '°';
                    cSplitFen = '′';
                }

                try
                {
                    string strFenValue = strDegreeString;
                    if (strDegreeString.IndexOf(cSplitDegree) != -1)
                    {
                        string[] arrString = strDegreeString.Split('度');
                        iCurDegreeValue = Convert.ToInt32(arrString[0]);
                        if (arrString.Length > 1)
                        {
                            strFenValue = arrString[1];
                        }
                    }

                    if (strFenValue.IndexOf(cSplitFen) != -1)
                    {
                        string[] arrFenString = strFenValue.Split('分');
                        dCurFenValue = Convert.ToDouble(arrFenString[0]);
                    }

                    if (strDegreeString.IndexOf("W") > -1 || strDegreeString.IndexOf("S") > -1)
                    {
                        iSign = -1;
                    }
                    iCoorGeoValue = (int)(iSign * (iCurDegreeValue + dCurFenValue / 60) * 10000000);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                try
                {
                    iCoorGeoValue = (int)(Convert.ToDouble(strDegreeString) * 10000000);
                }
                catch (Exception ex)
                {

                }
            }


            return iCoorGeoValue;
        }


        public static string GetDegreeStringFromGeoCoor_new(bool bLongOrLatiCoor, int coorVal, int coorMultiFactor, int fenLen)
        {
            string retDegreeString = "";
            double fArcByDegree = coorVal / (float)coorMultiFactor;

            if (bLongOrLatiCoor)
            {
                if (fArcByDegree >= 0)
                {
                    double dFenValue = 60 * (fArcByDegree - (int)fArcByDegree);
                    string strFenValue = Math.Round(dFenValue, fenLen).ToString();
                    if (dFenValue < 10)
                    {
                        strFenValue = "0" + strFenValue;
                    }

                    while (strFenValue.Length < (fenLen + 3))
                    {
                        strFenValue += "0";
                    }
                    retDegreeString = ((int)fArcByDegree).ToString() + "度" + strFenValue + "分E";

                    if (fArcByDegree < 10)
                    {
                        retDegreeString = "0" + retDegreeString;
                    }
                }
                else
                {
                    fArcByDegree = -fArcByDegree;

                    double dFenValue = 60 * (fArcByDegree - (int)fArcByDegree);
                    string strFenValue = Math.Round(dFenValue, fenLen).ToString();
                    if (dFenValue < 10)
                    {
                        strFenValue = "0" + strFenValue;
                    }

                    while (strFenValue.Length < (fenLen + 3))
                    {
                        strFenValue += "0";
                    }

                    retDegreeString = ((int)fArcByDegree).ToString() + "度" + strFenValue + "分W";
                    if (fArcByDegree < 10)
                    {
                        retDegreeString = "0" + retDegreeString;
                    }
                }
            }
            else
            {
                if (fArcByDegree >= 0)
                {

                    double dFenValue = 60 * (fArcByDegree - (int)fArcByDegree);
                    string strFenValue = Math.Round(dFenValue, fenLen).ToString();
                    if (dFenValue < 10)
                    {
                        strFenValue = "0" + strFenValue;
                    }

                    while (strFenValue.Length < (fenLen + 3))
                    {
                        strFenValue += "0";
                    }

                    retDegreeString = ((int)fArcByDegree).ToString() + "度" + strFenValue + "分N";
                    if (fArcByDegree < 10)
                    {
                        retDegreeString = "0" + retDegreeString;
                    }

                }
                else
                {
                    fArcByDegree = -fArcByDegree;

                    double dFenValue = 60 * (fArcByDegree - (int)fArcByDegree);
                    string strFenValue = Math.Round(dFenValue, fenLen).ToString();
                    if (dFenValue < 10)
                    {
                        strFenValue = "0" + strFenValue;
                    }

                    while (strFenValue.Length < (fenLen + 3))
                    {
                        strFenValue += "0";
                    }

                    retDegreeString = ((int)fArcByDegree).ToString() + "度" + strFenValue + "分S";
                    if (fArcByDegree < 10)
                    {
                        retDegreeString = "0" + retDegreeString;
                    }
                }
            }

            return retDegreeString;
        }

        private static string GetStringFromBytes(byte[] buffer, int bufLen)
        {
            int charCount = bufLen / 2;
            char[] ca = new char[charCount];
            for (int charNum = 0; charNum < charCount; charNum++)
            {
                ca[charNum] = BitConverter.ToChar(buffer, charNum * 2);
            }

            return (new string(ca, 0, charCount));
        }

        private static byte[] GetBytesFromString(string str, int charCount)
        {
            byte[] buffer = new byte[charCount * 2];
            for (int charNum = 0; charNum < charCount; charNum++)
            {
                byte[] elementBuf = BitConverter.GetBytes(str.ToCharArray()[charNum]);
                Array.Copy(elementBuf, 0, buffer, charNum * 2, 2);
            }

            return buffer;
        }

        public static M_POINT[] GetPointArrayFromString(string strPoints, int elementCount)
        {
            byte[] buffer = GetBytesFromString(strPoints, elementCount*4); 
            M_POINT[] retPoints = new M_POINT[elementCount];
            for (int i = 0; i < elementCount; i++)
            {
                byte[] newElementBuffer = new byte[8];
                Array.Copy(buffer, i * 8, newElementBuffer, 0, 8);
                retPoints[i] = new M_POINT(newElementBuffer);
            }

            return retPoints;
        } 

        public static string GetStringFromPointArray(M_POINT[] pointArray, int elementCount)
        { 
            int bufLen = elementCount * 8 + 8;
            byte[] buffer = new byte[bufLen];
            for (int i = 0; i < elementCount; i++)
            {
                byte[] elemBuf = pointArray[i].ToBytes();
                Array.Copy(elemBuf, 0, buffer, i * 8, 8);
            }

            string str= GetStringFromBytes(buffer, bufLen);
            return str;
        }

        public static M_GEO_OBJ_POS[] GetObjPosArrayFromString(string strObjPoses, int elementCount)
        {
            byte[] buffer = UnicodeEncoding.Unicode.GetBytes(strObjPoses);
            M_GEO_OBJ_POS[] retObjPoses = new M_GEO_OBJ_POS[elementCount];
            for (int i = 0; i < elementCount; i++)
            {
                byte[] newElementBuffer = new byte[8];
                Array.Copy(buffer, i * 8, newElementBuffer, 0, 8);
                retObjPoses[i] = new M_GEO_OBJ_POS(newElementBuffer);
            }

            return retObjPoses;
        }

        public static MEM_GEO_OBJ_POS[] GetMemObjPosArrayFromString(string strObjPoses, int elementCount)
        { 
            byte[] buffer = new byte[elementCount * 12 + 2];
            buffer = UnicodeEncoding.Unicode.GetBytes(strObjPoses);
            MEM_GEO_OBJ_POS[] retObjPoses = new MEM_GEO_OBJ_POS[elementCount];
            for (int i = 0; i < elementCount; i++)
            {
                byte[] newElementBuffer = new byte[12];
                Array.Copy(buffer, i * 12, newElementBuffer, 0, 12);
                retObjPoses[i] = new MEM_GEO_OBJ_POS(newElementBuffer);
            }

            return retObjPoses;
        }

        public static string GetStringFromMemGeoObjPos(MEM_GEO_OBJ_POS objPos)
        {
            return UnicodeEncoding.Unicode.GetString(objPos.ToBytes()); 
        }

        public static string GetStringFromIntArray(int[] intArray, int elementCount)
        {
            byte[] buffer = new byte[elementCount * 4];
            for (int i = 0; i < elementCount; i++)
            {
                byte[] elemBuf = BitConverter.GetBytes(intArray[i]);
                Array.Copy(elemBuf, 0, buffer, i * 4, 4);
            }
            return UnicodeEncoding.Unicode.GetString(buffer);
        }

        public static int[] GetIntArrayFromString(string str, int elementCount)
        {
            byte[] buffer = UnicodeEncoding.Unicode.GetBytes(str.ToCharArray(), 0, elementCount*2);
            int[] retIntArray = new int[elementCount];
            for (int i = 0; i < elementCount; i++)
            { 
                retIntArray[i] = BitConverter.ToInt32(buffer,i*4);
            }

            return retIntArray;
        }

        /// <summary>
        /// 经纬度转成三维坐标，设地心为圆心
        /// </summary>
        /// <param name="LONG">经度</param>
        /// <param name="LAT">纬度</param>
        /// <param name="RADII">地球半径</param>
        /// <returns>THREE_DIMENSIONAL_POINT</returns>
        public static THREE_DIMENSIONAL_POINT getThreeDimensionalPointFromDegree(float LONG, float LAT, float RADII)
        {
            THREE_DIMENSIONAL_POINT point = new THREE_DIMENSIONAL_POINT();
            point.Y = (float)Math.Sin((double)(LAT * Math.PI / 180)) * RADII;
            point.X = (float)(Math.Cos((double)(LONG * Math.PI / 180)) * Math.Cos((double)(LAT * Math.PI / 180))* RADII);
            point.Z = (float)(Math.Sin((double)(LONG * Math.PI / 180)) * Math.Cos((double)(LAT * Math.PI / 180)) * RADII);
            return point;
        }

        //根据x方向的位移和y方向的位移计算，直线距离和角度
        public static void GetDistanceAndCourseFromOffset(double xOffset, double yOffset, ref double distance, ref double course)
        {
            distance = Math.Sqrt(xOffset * xOffset + yOffset * yOffset);
            if (xOffset > 0 && yOffset > 0)
            {
                course = Math.Atan2(xOffset, yOffset);
            }
            else if (xOffset > 0 && yOffset == 0)
            {
                course = Common.PI / 2;
            }
            else if (xOffset > 0 && yOffset < 0)
            {
                course = Common.PI / 2 + Math.Atan2(-yOffset, xOffset);
            }
            else if (xOffset == 0 && yOffset > 0)
            {
                course = 0.0;
            }
            else if (xOffset == 0 && yOffset == 0)
            {
                course = 0.0;
            }
            else if (xOffset == 0 && yOffset < 0)
            {
                course = Common.PI;
            }
            else if (xOffset < 0 && yOffset > 0)
            {
                course = Common.PI / 2 * 3 + Math.Atan2(yOffset, -xOffset);
            }
            else if (xOffset < 0 && yOffset == 0)
            {
                course = Common.PI / 2 * 3;
            }
            else if (xOffset < 0 && yOffset < 0)
            {
                course = Common.PI + Math.Atan2(-xOffset, -yOffset);
            }
            course = course / Common.PI * 180;
        }
    };

    #region 信息验证
    public class CheckInfo
    {
        
        #region 判断字符串是否为数字
        /// <summary>
        /// 判断输入的字符串是否为数字
        /// </summary>
        /// <param name="s">要判断的字符串</param>
        /// <param name="numberType">0:无符号整数判断，1:有符号整数判断，2:无符号小数判断，3:有符号小数判断</param>
        /// <returns>bool</returns>
        public static bool isNumber(string str,int numberType)
        {
            char[] strArray = str.ToCharArray();
            string sign = "+-";

            if (str.Equals(""))
            {
                return false;
            }
            switch(numberType)
            {
                case 0://判断为无符号整数
                    {
                        for (int i = 0; i < strArray.Length; i++)
                        {
                            if (!Char.IsNumber(str[i]))
                            {
                                return false;
                            }
                        }                                
                    }
                    break;
                case 1://判断为有符号整数
                    {
                        for (int i = 0; i < strArray.Length; i++)
                        {
                            if (!Char.IsNumber(str[i]))
                            {
                                if (i == 0)
                                {
                                    if (sign.IndexOf(str[0]) < 0)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 2://判断为无符号小数
                    {
                        bool signPoint = false;
                        for (int i = 0; i < strArray.Length; i++)
                        {
                            if (!Char.IsNumber(str[i]))
                            {
                                if (str[i].ToString().Equals("."))
                                {
                                    if (signPoint)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        signPoint = true;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    break;
                case 3://判断为有符号小数
                    {                        
                        bool signPoint = false;
                        for (int i = 0; i < strArray.Length; i++)
                        {
                            if (!Char.IsNumber(str[i]))
                            {
                                if (i == 0)
                                {
                                    if (str[0].Equals("."))
                                    {
                                        signPoint = true;
                                    }
                                    else if (sign.IndexOf(str[0]) < 0)
                                    {
                                        return false;
                                    }
                                }

                                if ((str[i].ToString().Equals(".")))
                                {
                                    if (signPoint)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        signPoint = true;
                                    }
                                }
                            }
                        }
                    }
                    break;
                default:
                    return false;
            }
            return true;
        }
        #endregion
    }
    #endregion

    #region 获取颜色
    class GetTopColor
    {
        [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
        public static extern IntPtr DeleteDC(IntPtr hdc);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern IntPtr DeleteObject(IntPtr hObject);

        [DllImport("gdi32.dll", EntryPoint = "BitBlt")]
        public static extern bool BitBlt(IntPtr hdcDest, int nXDest,
        int nYDest, int nWidth, int nHeight, IntPtr hdcSrc,
        int nXSrc, int nYSrc, int dwRop);

        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc,
        int nWidth, int nHeight);

        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobjBmp);

        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

        public static Bitmap GetDesktop(FormMain form1)
        {
            int screenX;
            int screenY;
            IntPtr hBmp;
            IntPtr hdcScreen = GetDC(GetDesktopWindow());
            IntPtr hdcCompatible = CreateCompatibleDC(hdcScreen);

            Point point = new Point(GetSystemMetrics(0), GetSystemMetrics(1));

            screenX = form1.PointToClient(point).X;
            screenY = form1.PointToClient(point).Y;
            hBmp = CreateCompatibleBitmap(hdcScreen, screenX, screenY);

            if (hBmp != IntPtr.Zero)
            {
                IntPtr hOldBmp = (IntPtr)SelectObject(hdcCompatible, hBmp);
                BitBlt(hdcCompatible, 0, 0, screenX, screenY, hdcScreen, 100, 100, 13369376);

                SelectObject(hdcCompatible, hOldBmp);
                DeleteDC(hdcCompatible);
                ReleaseDC(GetDesktopWindow(), hdcScreen);

                Bitmap bmp = System.Drawing.Image.FromHbitmap(hBmp);

                DeleteObject(hBmp);
                GC.Collect();

                return bmp;
            }

            return null;
        }
    }
    #endregion

    #region 画图
    public class M_DRAW
    {
        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", EntryPoint = "SetROP2")]
        private static extern IntPtr SetROP2(IntPtr hdc, IntPtr fnDrawMode);

        [DllImport("gdi32.dll", EntryPoint = "CreatePen")]
        public static extern IntPtr CreatePen(int penStype, int penWidth, int penColor);

        [DllImport("gdi32.dll", EntryPoint = "GetStockObject")]
        private static extern IntPtr GetStockObject(int fnObject);

        [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        static extern bool DeleteObject(IntPtr hObject);

        [DllImport("gdi32.dll", EntryPoint = "Ellipse")]
        public static extern bool Ellipse(IntPtr hdc, int left, int top, int right, int bottom);       

        [DllImport("gdi32.dll", EntryPoint = "MoveToEx")]
        public static extern IntPtr MoveToEx(IntPtr hdc, int x, int y, int p);

        [DllImport("gdi32.dll", EntryPoint = "LineTo")]
        public static extern IntPtr LineTo(IntPtr hdc, int x, int y);  

        //[DllImport("gdi32.dll", EntryPoint = "TextOutA")]
        //public static extern IntPtr TextOutA(IntPtr hdc, int x, int y,string str,int length); 

        #region 画电子方位线
        /// <summary>
        /// 画电子方位线
        /// </summary>
        /// <param name="control">System.Windows.Forms.Control</param>
        /// <param name="centerPoint">圆心或起点</param>
        /// <param name="endPoint">终点</param>
        /// <param name="penColor">画笔颜色</param>
        public static void DrawEBL(System.Windows.Forms.Control control, M_POINT centerPoint, M_POINT endPoint, int penColor)
        {
            IntPtr hdc = GetDC(control.Handle);//获取句柄
            float deltx = endPoint.x - centerPoint.x;
            float delty = endPoint.y - centerPoint.y;
            float radius = (float)Math.Sqrt(Math.Pow(deltx, 2) + Math.Pow(delty, 2));//圆的半径 

            IntPtr R2_XORPEN = (IntPtr)7;
            SetROP2(hdc, R2_XORPEN);//设置当前为异或画法 
            IntPtr pen = (IntPtr)CreatePen(0, 1, penColor);//创建画笔
            IntPtr oldPen = SelectObject(hdc, pen);//添加画笔
            int NULL_BRUSH = 5;
            IntPtr hdcBrush = SelectObject(hdc, GetStockObject(NULL_BRUSH));

            Ellipse(hdc, (int)(centerPoint.x - radius), (int)(centerPoint.y - radius), (int)(centerPoint.x + radius), (int)(centerPoint.y + radius));//画圆
            //string myText = "aaaaaaa";
            //TextOutA(hdc, endPoint.x, endPoint.y, myText, myText.Length);
            Point newEndPoint = new Point();
            if (deltx != 0)
            {
                newEndPoint.X = deltx > 0 ? 1500 : 0;//默认用户活动窗口的最大长度为1500
                newEndPoint.Y = (int)(delty / deltx * (newEndPoint.X - centerPoint.x) + centerPoint.y);
            }
            else
            {
                if (delty == 0)
                {
                    return;
                }
                newEndPoint.X = centerPoint.x;
                newEndPoint.Y = delty > 0 ? 1200 : 0;//默认用户活动窗口的最大高度为1200
            }

            MoveToEx(hdc, centerPoint.x, centerPoint.y, 0);//画线
            LineTo(hdc, newEndPoint.X, newEndPoint.Y);

            SetROP2(hdc, (IntPtr)12);//还原默认画法
            SelectObject(hdc, oldPen);
            SelectObject(hdc, hdcBrush);
            DeleteObject(pen);

            ReleaseDC(control.Handle, hdc);
        }
        #endregion
    }
    #endregion

    public class ListItem
    {
        private int id;
        private string name = string.Empty;
        public ListItem()
        { }
        public ListItem(int sid, string sname)
        {
            id = sid;
            name = sname;
        }
        public override string ToString()
        {
            return this.name;
        }
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }

    public class THREE_DIMENSIONAL_POINT
    {
        float x;
        float y;
        float z;

        public THREE_DIMENSIONAL_POINT()
        {
            this.x=0;
            this.y=0;
            this.z=0;
        }

        public float X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public float Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public float Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }
        public string toString()
        {
           return "X:" + this.x.ToString() + ",Y:" + this.y.ToString() + ",Z:" + this.z.ToString();
        }
    }

    public class WayPoint
    {
        int id;
        float lon;
        float lat;
        public WayPoint()
        {
            id = 0;
            lon = 0;
            lat = 0;
        }

        public WayPoint(int wayPointId, float wayPointLon, float wayPointLat)
        {
            this.id = wayPointId;
            this.lon = wayPointLon;
            this.lat = wayPointLat;
        }
    }

    public class M_DRAW_IMG
    {
        public Image img;
        public M_POINT mLeftTopGeoPo;
        public int iRightGeoX;
        public int iButtomGeoY;

    }
    public class ShipDataInfo
    {
 //int otherVesselPos, ref bool pBeArpaOrAisTarget, ref int pCurrentGeoPoX, ref int pCurrentGeoPoY, ref float pHeading, ref float pCourseOverGround, ref float pCourseThrghWater, ref float pSpeedOverGround, ref float pSpeedThrghWater, ref int pTime, ref string pExtAttrs
     //this.ymEncCtrl.GetOtherVesselBasicInfo(iShipPos, ref fShipLen, ref fShipWidth, ref strShipName, ref iShipMmsi, ref strShipAttr);
        public string strShipName;//船名
        public ArrayList arrGeoPo;
        public M_POINT mGeoPo;
        public int iShipLength;//船长
        public int iShipWidth;//船宽
        public int iMMSI;
        public float pHeading;//航向
        float pCourseOverGround;
        float pCourseThrghWater;
        float pShipSpeed;//船速
        float pSpeedThrghWater;
        int pTime;
        string pExtAttrs;//额外信息
        
        public ShipDataInfo()
        {
            strShipName = "";
            arrGeoPo = new ArrayList();
            mGeoPo = new M_POINT(0, 0);
            iShipLength = 0;
            iShipWidth = 0;
            iMMSI = 0;
            pHeading = 0;
            pCourseOverGround = 0;
            pCourseThrghWater = 0;
            pShipSpeed = 0;
            pSpeedThrghWater = 0;
            pTime = 0;
            pExtAttrs = "";
        }
    }
}