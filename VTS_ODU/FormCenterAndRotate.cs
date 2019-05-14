using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class FormCenterAndRotate : Form
    {          
        public FormCenterAndRotate()
        {
            InitializeComponent();
        }

        private void FormCenterAndRotate_Load(object sender, EventArgs e)        
        {
            FormMain f1 = (FormMain)this.Owner;
            float fGeoCoorMultiFactor = f1.ymEncCtrl.GetGeoCoorMultiFactor();//获取经纬度坐标乘积因子            
            int centerScrnPoX, centerScrnPoY;
            int centerGeoPoX=0, centerGeoPoY=0;

            centerScrnPoX = f1.ymEncCtrl.GetDrawerScreenWidth() / 2;//获取屏幕横坐标，单位为像素;
            centerScrnPoY = f1.ymEncCtrl.GetDrawerScreenHeight() / 2;//获取屏幕纵坐标，单位为像素;

            f1.ymEncCtrl.GetGeoPoFromScrnPo(centerScrnPoX, centerScrnPoY, ref centerGeoPoX, ref centerGeoPoY);//返回地理坐标经度centerGeoPoX、地理坐标纬度centerGeoPoY
            txt_PoX.Text = (centerGeoPoX / fGeoCoorMultiFactor).ToString();
            txt_PoY.Text = (centerGeoPoY / fGeoCoorMultiFactor).ToString();
            txt_rotate.Text = f1.ymEncCtrl.GetMapRoatedAngle().ToString();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            FormMain f1 = (FormMain)this.Owner;
            float fGeoCoorMultiFactor = f1.ymEncCtrl.GetGeoCoorMultiFactor();//获取经纬度坐标乘积因子

            string str_PoX = txt_PoX.Text.ToString();
            string str_PoY = txt_PoY.Text.ToString();
            string str_rotate = txt_rotate.Text.ToString();
            if (!CheckInfo.isNumber(str_PoX, 3))
            {
                MessageBox.Show("请输入正确的数字。");                
                txt_PoX.Focus();
                return;
            }
            if (!CheckInfo.isNumber(str_PoY, 3))
            {
                MessageBox.Show("请输入正确的数字。");
                txt_PoY.Focus();
                return;
            }
            if (!CheckInfo.isNumber(str_rotate, 3))
            {
                MessageBox.Show("请输入正确的数字。");
                txt_rotate.Focus();
                return;
            }

            int centerPoGeoCoorX = (int)(Convert.ToDouble(txt_PoX.Text.ToString()) * fGeoCoorMultiFactor);
            int centerPoGeoCoorY = (int)(Convert.ToDouble(txt_PoY.Text.ToString()) * fGeoCoorMultiFactor);
            Single fRotateAngleByDegree = (Single)Convert.ToDouble(txt_rotate.Text.ToString());

            f1.ymEncCtrl.CenterMap(centerPoGeoCoorX, centerPoGeoCoorY);
            f1.ymEncCtrl.RotateMapByScrnCenter(fRotateAngleByDegree);
            this.Close();
        } 

        private void btn_cancel_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormMain f1 = (FormMain)this.Owner;
            float fGeoCoorMultiFactor = f1.ymEncCtrl.GetGeoCoorMultiFactor();//获取经纬度坐标乘积因子

            string str_PoX = txt_PoX.Text.ToString();
            string str_PoY = txt_PoY.Text.ToString();
            string str_rotate = txt_rotate.Text.ToString();
            if (!CheckInfo.isNumber(str_PoX, 3))
            {
                MessageBox.Show("请输入正确的数字。");
                txt_PoX.Focus();
                return;
            }
            if (!CheckInfo.isNumber(str_PoY, 3))
            {
                MessageBox.Show("请输入正确的数字。");
                txt_PoY.Focus();
                return;
            }
            if (!CheckInfo.isNumber(str_rotate, 3))
            {
                MessageBox.Show("请输入正确的数字。");
                txt_rotate.Focus();
                return;
            }

            int centerPoGeoCoorX = (int)(Convert.ToDouble(txt_PoX.Text.ToString()) * fGeoCoorMultiFactor);
            int centerPoGeoCoorY = (int)(Convert.ToDouble(txt_PoY.Text.ToString()) * fGeoCoorMultiFactor);
            Single fRotateAngleByDegree = (Single)Convert.ToDouble(txt_rotate.Text.ToString());

            f1.ymEncCtrl.CenterMap(centerPoGeoCoorX, centerPoGeoCoorY);
            f1.ymEncCtrl.RotateMapByScrnCenter(fRotateAngleByDegree);
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
