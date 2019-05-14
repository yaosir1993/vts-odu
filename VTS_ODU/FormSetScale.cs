using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YIMAENCLib;


namespace vts_odu
{
    public partial class FormSetScale : Form
    {
        public FormSetScale()
        {
            InitializeComponent();
        }

        private void FormSetScale_Load(object sender, EventArgs e)
        {            
            FormMain f1 = (FormMain)this.Owner;
            setCmbScaleValue(f1.ymEncCtrl.GetCurrentScale().ToString());//获取/显示比例尺
        }

        #region 判断当前显示比例尺是否在combobox的Items值中，在则设置其为当前选中项，否则添加当前比例尺到combobox中，并设置为选择项
        /// <summary>
        /// 判断当前显示比例尺是否在combobox的Items值中，在则设置其为当前选中项，否则添加当前比例尺到combobox中，并设置为选择项.
        /// </summary>
        /// <param name="str_scale">比例尺分母值</param>
        private void setCmbScaleValue(string str_scale)
        {
            int len = cmb_scale.Items.Count;
            int sign = 0;
            for (int i = 0; i < len; i++)
            {
                if (cmb_scale.Items[i].ToString().Equals("1:"+str_scale))
                {
                    cmb_scale.SelectedIndex = i;
                    sign = 1;
                    break;
                }
            }
            if (sign == 0)
            {
                cmb_scale.Items.AddRange(new object[] { "1:" + str_scale });
                cmb_scale.SelectedIndex = len;
            }
            txt_scale.Text = str_scale;
        }
        #endregion

        #region combobox自动提交
        private void cmb_scale_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str_scale = cmb_scale.SelectedItem.ToString();            
            if (!str_scale.Equals(""))
            {
                txt_scale.Text = str_scale;
                string[] scale = str_scale.Split(':');
                txt_scale.Text = scale[1].ToString();
                float scaleValue = (float)Convert.ToDouble(scale[1].ToString());
                ((FormMain)this.Owner).ymEncCtrl.SetCurrentScale(scaleValue);
                ((FormMain)this.Owner).disScale();
            }
        }
        #endregion

        #region 确定比例尺
        private void btn_ok_Click(object sender, EventArgs e)
        {
            string txt_value = txt_scale.Text.ToString().Trim();
            if (CheckInfo.isNumber(txt_value, 2))
            {
                ((FormMain)this.Owner).ymEncCtrl.SetCurrentScale((float)Convert.ToDouble(txt_value));
            }
            else
            {
                MessageBox.Show("请输入一个正确的整数！");
            }
            ((FormMain)this.Owner).disScale();
            this.Close();
        }
        #endregion

        #region 关闭
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string txt_value = txt_scale.Text.ToString().Trim();
            if (CheckInfo.isNumber(txt_value, 2))
            {
                ((FormMain)this.Owner).ymEncCtrl.SetCurrentScale((float)Convert.ToDouble(txt_value));
            }
            else
            {
                MessageBox.Show("请输入一个正确的整数！");
            }
            ((FormMain)this.Owner).disScale();
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
