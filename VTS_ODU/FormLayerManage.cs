using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class FormLayerManage : Form
    {
        public FormLayerManage()
        {
            InitializeComponent();
        }

        private void FormLayerManage_Load(object sender, EventArgs e)
        {
            int layerCount = ((FormMain)this.Owner).ymEncCtrl.GetLayerCount(-1);
            for (int i = 0; i < layerCount; i++)
            {
                string layerName = new string(' ', 255);
                string layerNameToken = new string(' ', 255);
                int attrCount = 0;

                ((FormMain)this.Owner).ymEncCtrl.GetLayerInfo(-1, i, ref layerName, ref layerNameToken, ref attrCount);
                this.lb_layersInfo.Items.Add(layerName);
            }
            this.lb_layersInfo.SetSelected(0, true);
            displayLayerInfo(-1, 0);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_layersInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = this.lb_layersInfo.SelectedIndex;
            displayLayerInfo(-1, selectedItem);
        }

        private void displayLayerInfo(int mapPos, int layerPos)
        {
            bool layerDrawOrNot = ((FormMain)this.Owner).ymEncCtrl.GetLayerDrawOrNot(mapPos, layerPos);
            if (layerDrawOrNot)
            {
                this.cb_isDisplay.Checked = true;
            }
            else
            {
                this.cb_isDisplay.Checked = false;
            }
        }

        private void btn_allHide_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Owner).ymEncCtrl.SetAllLayerDrawOrNot(-1, false);
            this.cb_isDisplay.Checked = false;
        }

        private void btn_allDisplay_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Owner).ymEncCtrl.SetAllLayerDrawOrNot(-1, true);
            this.cb_isDisplay.Checked = true;
        }

        private void cb_isDisplay_CheckedChanged(object sender, EventArgs e)
        {
            bool layerDrawOrNot = this.cb_isDisplay.Checked;
            int layerPos = this.lb_layersInfo.SelectedIndex;
            ((FormMain)this.Owner).ymEncCtrl.SetLayerDrawOrNot(-1, layerPos, layerDrawOrNot);
        }
    }
}
