using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class FormAlarmSetting : Form
    {
        public float isoDangerDistDoor;
        public float offRouteDistDoor;
        public float safeContourDistDoor;

        public FormAlarmSetting()
        {
            InitializeComponent();
        }

        private void FormAlarmSetting_Load(object sender, EventArgs e)
        {
            this.tb_isoDangerDistDoor.Text = isoDangerDistDoor.ToString();
            this.tb_offRouteDistDoor.Text = offRouteDistDoor.ToString();
            this.tb_safeContourDistDoor.Text = safeContourDistDoor.ToString();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            string strDangerDistDoor = this.tb_isoDangerDistDoor.Text;
            string strOffRouteDistDoor = this.tb_offRouteDistDoor.Text;
            string strSafeContourDistDoor = this.tb_safeContourDistDoor.Text;

            if (!CheckInfo.isNumber(strDangerDistDoor, 2) || !CheckInfo.isNumber(strOffRouteDistDoor, 2) || !CheckInfo.isNumber(strSafeContourDistDoor, 2))
            {
                MessageBox.Show("请输入正确的数值。");
                return;
            }

            FormMain.m_isoDangerDistDoor = Convert.ToUInt32(strDangerDistDoor);
            FormMain.m_offRouteDistDoor = Convert.ToUInt32(strOffRouteDistDoor);
            FormMain.m_safeContourDistDoor = Convert.ToUInt32(strSafeContourDistDoor);
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strDangerDistDoor = this.tb_isoDangerDistDoor.Text;
            string strOffRouteDistDoor = this.tb_offRouteDistDoor.Text;
            string strSafeContourDistDoor = this.tb_safeContourDistDoor.Text;

            if (!CheckInfo.isNumber(strDangerDistDoor, 2) || !CheckInfo.isNumber(strOffRouteDistDoor, 2) || !CheckInfo.isNumber(strSafeContourDistDoor, 2))
            {
                MessageBox.Show("请输入正确的数值。");
                return;
            }

            FormMain.m_isoDangerDistDoor = Convert.ToUInt32(strDangerDistDoor);
            FormMain.m_offRouteDistDoor = Convert.ToUInt32(strOffRouteDistDoor);
            FormMain.m_safeContourDistDoor = Convert.ToUInt32(strSafeContourDistDoor);
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
