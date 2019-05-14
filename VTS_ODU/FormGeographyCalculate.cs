using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class FormGeographyCalculate : Form
    {
        const int UNI_GEO_COOR_MULTI_FACTOR = 10000000;
        public FormGeographyCalculate()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string str_startLONG = tb_startLONG.Text.ToString().Trim();//起点：经度
            string str_startLAT = tb_startLAT.Text.ToString().Trim();//起点：纬度
            string str_endLONG = tb_endLONG.Text.ToString().Trim();//终点：经度
            string str_endLAT = tb_endLAT.Text.ToString().Trim();//终点：纬度

            //设置textBox字体为黑色
            tb_startLONG.ForeColor = Color.FromName("Black");
            tb_startLAT.ForeColor = Color.FromName("Black");
            tb_endLONG.ForeColor = Color.FromName("Black");
            tb_endLAT.ForeColor = Color.FromName("Black");
            int sign = 0;
            
            //判断输入的值是否为小数
            if (!CheckInfo.isNumber(str_startLONG,3))
            {
                tb_startLONG.ForeColor = Color.FromName("red");
                sign = 1;
            }

            if (!CheckInfo.isNumber(str_startLAT, 3))
            {
                tb_startLAT.ForeColor = Color.FromName("red");
                sign = 1;
            }

            if (!CheckInfo.isNumber(str_endLONG, 3))
            {
                tb_endLONG.ForeColor = Color.FromName("red");
                sign = 1;
            }

            if (!CheckInfo.isNumber(str_endLAT, 3))
            {
                tb_endLAT.ForeColor = Color.FromName("red");
                sign = 1;
            }            

            if (sign == 1)
            {
                MessageBox.Show("请输入正确的数字！");
                return;
            }

            int iStartLONG = (int)Convert.ToDouble(str_startLONG) * UNI_GEO_COOR_MULTI_FACTOR;
            int iStartLAT = (int)Convert.ToDouble(str_startLAT) * UNI_GEO_COOR_MULTI_FACTOR;
            int iEndLONG = (int)Convert.ToDouble(str_endLONG) * UNI_GEO_COOR_MULTI_FACTOR;
            int iEndLAT = (int)Convert.ToDouble(str_endLAT) * UNI_GEO_COOR_MULTI_FACTOR;

            double result = ((FormMain)this.Owner).ymEncCtrl.GetDistBetwTwoPoint(iStartLONG, iStartLAT, iEndLONG, iEndLAT);
            double angle = ((FormMain)this.Owner).ymEncCtrl.GetBearingBetwTwoPoint(iStartLONG, iStartLAT, iEndLONG, iEndLAT);
            this.tb_angle1.Text = Math.Round(angle, 3).ToString();
            this.tb_result.Text = Math.Round(result, 4).ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok2_Click(object sender, EventArgs e)
        {
            string str_startLONG2 = tb_startLONG2.Text.ToString().Trim();//起点：经度
            string str_startLAT2 = tb_startLAT2.Text.ToString().Trim();//起点：纬度
            string tb_angle = this.tb_angle.Text.ToString().Trim();//角度
            string tb_distance = this.tb_distance.Text.ToString().Trim();//距离

            int iLon = Convert.ToInt32(str_startLONG2) * UNI_GEO_COOR_MULTI_FACTOR;
            int iLat = Convert.ToInt32(str_startLAT2) * UNI_GEO_COOR_MULTI_FACTOR;
            double dAngle = Convert.ToDouble(tb_angle);
            double dDistance = Convert.ToDouble(tb_distance);
            int iResultLon = 0;
            int iResultLat = 0;

            ((FormMain)this.Owner).ymEncCtrl.GetDesPointOfCrsAndDist(iLon, iLat, dDistance, dAngle, ref iResultLon, ref iResultLat);
            this.tb_endLAT2.Text = Math.Round((double)iResultLat / UNI_GEO_COOR_MULTI_FACTOR,4).ToString();
            this.tb_endLONG2.Text = Math.Round((double)iResultLon / UNI_GEO_COOR_MULTI_FACTOR,4).ToString();

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string str_startLONG2 = tb_startLONG2.Text.ToString().Trim();//起点：经度
            string str_startLAT2 = tb_startLAT2.Text.ToString().Trim();//起点：纬度
            string tb_angle = this.tb_angle.Text.ToString().Trim();//角度
            string tb_distance = this.tb_distance.Text.ToString().Trim();//距离

            int iLon = Convert.ToInt32(str_startLONG2) * UNI_GEO_COOR_MULTI_FACTOR;
            int iLat = Convert.ToInt32(str_startLAT2) * UNI_GEO_COOR_MULTI_FACTOR;
            double dAngle = Convert.ToDouble(tb_angle);
            double dDistance = Convert.ToDouble(tb_distance);
            int iResultLon = 0;
            int iResultLat = 0;

            ((FormMain)this.Owner).ymEncCtrl.GetDesPointOfCrsAndDist(iLon, iLat, dDistance, dAngle, ref iResultLon, ref iResultLat);
            this.tb_endLAT2.Text = Math.Round((double)iResultLat / UNI_GEO_COOR_MULTI_FACTOR, 4).ToString();
            this.tb_endLONG2.Text = Math.Round((double)iResultLon / UNI_GEO_COOR_MULTI_FACTOR, 4).ToString();

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string str_startLONG2 = tb_startLONG2.Text.ToString().Trim();//起点：经度
            string str_startLAT2 = tb_startLAT2.Text.ToString().Trim();//起点：纬度
            string tb_angle = this.tb_angle.Text.ToString().Trim();//角度
            string tb_distance = this.tb_distance.Text.ToString().Trim();//距离

            int iLon = Convert.ToInt32(str_startLONG2) * UNI_GEO_COOR_MULTI_FACTOR;
            int iLat = Convert.ToInt32(str_startLAT2) * UNI_GEO_COOR_MULTI_FACTOR;
            double dAngle = Convert.ToDouble(tb_angle);
            double dDistance = Convert.ToDouble(tb_distance);
            int iResultLon = 0;
            int iResultLat = 0;

            ((FormMain)this.Owner).ymEncCtrl.GetDesPointOfCrsAndDist(iLon, iLat, dDistance, dAngle, ref iResultLon, ref iResultLat);
            this.tb_endLAT2.Text = Math.Round((double)iResultLat / UNI_GEO_COOR_MULTI_FACTOR, 4).ToString();
            this.tb_endLONG2.Text = Math.Round((double)iResultLon / UNI_GEO_COOR_MULTI_FACTOR, 4).ToString();

        }
    }
}
