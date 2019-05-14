using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class FormSetSafetyDepth : Form
    {
        public FormSetSafetyDepth()
        {
            InitializeComponent();
        }

        private void FormSetSafetyDepth_Load(object sender, EventArgs e)
        {
            float safetyDepth = ((FormMain)this.Owner).ymEncCtrl.GetSafetyDepth();
            lb_oldSafetyDepth.Text  = safetyDepth.ToString().Trim();
        }        

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string str_safetyDepth = tb_newSafetyDepth.Text.ToString().Trim(); 
            if(CheckInfo.isNumber(str_safetyDepth,2))
            {
                float safetyDepth = (float)Convert.ToDouble(str_safetyDepth);
                ((FormMain)this.Owner).ymEncCtrl.SetSafetyDepth(safetyDepth);
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入一个正确的数字！");
            }            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string str_safetyDepth = tb_newSafetyDepth.Text.ToString().Trim();
            if (CheckInfo.isNumber(str_safetyDepth, 2))
            {
                float safetyDepth = (float)Convert.ToDouble(str_safetyDepth);
                ((FormMain)this.Owner).ymEncCtrl.SetSafetyDepth(safetyDepth);
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入一个正确的数字！");
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
