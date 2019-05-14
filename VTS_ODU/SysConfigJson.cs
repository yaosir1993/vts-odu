using BasicLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vts_odu
{
    public class SysConfigJson
    {
        public CoachStationConfig coachStation { get; set; }
        public DataBaseConfig dataBase { get; set; }
        public String radarRecvPort { get; set; }
        public String aisRecvPort { get; set; }
        public String localIp { get; set; }

        /// <summary>
        /// 配置文件解析
        /// </summary>
        /// <returns></returns>
        public static SysConfigJson Parse()
        {
            String basePath = System.Windows.Forms.Application.StartupPath;
            StreamReader reader = new StreamReader(basePath + "\\SysConfig.json");
            String content = reader.ReadToEnd();
            SysConfigJson config = JSON.Deserialize<SysConfigJson>(content);
            if (config != null)
            {
                return config;
            }
            reader.Close();
            return null;
        }

        /// <summary>
        /// 配置文件解析
        /// </summary>
        /// <returns></returns>
        public static void Save(SysConfigJson sysConfig)
        {
            String basePath = System.Windows.Forms.Application.StartupPath;
            StreamWriter writer = new StreamWriter(basePath + "\\SysConfig.json");
            String content = JSON.ConvertToJosnString(sysConfig);
            writer.Write(content);
            writer.Flush();
            writer.Close();
        }
    }

    /// <summary>
    /// 教练站
    /// </summary>
    public class CoachStationConfig
    {
        public String coachStationIp { get; set; }
        public String coachStationPort { get; set; }

        public CoachStationConfig(){}

        public CoachStationConfig(String ip, String port)
        {
            coachStationIp = ip;
            coachStationPort = port;
        }
    }

    /// <summary>
    /// 数据库配置
    /// </summary>
    public class DataBaseConfig
    {
        public String dataBaseIp { get; set; }
        public String dataBasePort { get; set; }
        public String dataBaseUser { get; set; }
        public String dataBasePass { get; set; }

        public DataBaseConfig() { }

        public DataBaseConfig(String ip, String port, String user,String pass)
        {
            dataBaseIp = ip;
            dataBasePort = port;
            dataBaseUser = user;
            dataBasePass = pass;
        }
    }
}
