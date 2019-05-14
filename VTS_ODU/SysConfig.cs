using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class SysConfig : Form
    {
        public SysConfigJson sysConfig;

        public SysConfig(SysConfigJson _sysConfigJson)
        {
            sysConfig = _sysConfigJson;
            InitializeComponent();
        }

        private void SysConfig_Load(object sender, EventArgs e)
        {
            CoachStation_ip.Text = sysConfig.coachStation.coachStationIp;
            CoachStation_port.Text = sysConfig.coachStation.coachStationPort;
            dataBase_ip.Text = sysConfig.dataBase.dataBaseIp;
            dataBase_port.Text = sysConfig.dataBase.dataBasePort;
            dataBase_user.Text = sysConfig.dataBase.dataBaseUser;
            dataBase_pass.Text = sysConfig.dataBase.dataBasePass;
            radarRecv_Port.Text = sysConfig.radarRecvPort;
            aisRecv_Port.Text = sysConfig.aisRecvPort;
            local_ip.Text = sysConfig.localIp;
        }

        private void SysConfigOK_Click_1(object sender, EventArgs e)
        {
            sysConfig.coachStation.coachStationIp = CoachStation_ip.Text;
            sysConfig.coachStation.coachStationPort = CoachStation_port.Text;
            sysConfig.dataBase.dataBaseIp = dataBase_ip.Text;
            sysConfig.dataBase.dataBasePort = dataBase_port.Text;
            sysConfig.dataBase.dataBaseUser = dataBase_user.Text;
            sysConfig.dataBase.dataBasePass = dataBase_pass.Text;
            sysConfig.radarRecvPort = radarRecv_Port.Text;
            sysConfig.aisRecvPort = aisRecv_Port.Text;

            //开启手动配置的本机IP地址
            if (use_local_ip.CheckState == CheckState.Checked)
            {
                sysConfig.localIp = local_ip.Text;
            }
            else
            {
                sysConfig.localIp = "";
            }

            //保存配置文件
            SysConfigJson.Save(sysConfig);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
