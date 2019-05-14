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
    public partial class RadarAddForm : Form
    {
        private CRadar editRadar = null;
        public int useOrNot = 0;
        public int showType = 0;
        public Color showColor = Color.Green;
        public RadarAddForm(CRadar _editRadar)
        {
            InitializeComponent();
            this.editRadar = _editRadar;
        }

        private void RadarAddForm_Load(object sender, EventArgs e)
        {
            if (editRadar != null)
            {
                m_radarGeoPosX.Enabled = false;
                m_radarGeoPosY.Enabled = false;
                m_radarName.Text = editRadar.radarName;
                m_radarHigh.Text = Convert.ToString(editRadar.radarHigh);
                m_radarRange.Text = Convert.ToString(editRadar.radarRange);
                m_radarGeoPosX.Text = Convert.ToString(Convert.ToDouble(editRadar.radarGeoPosX * 1.0 / 10000000));
                m_radarGeoPosY.Text = Convert.ToString(Convert.ToDouble(editRadar.radarGeoPosY * 1.0 / 10000000));
                m_radarUseOrNot.Checked = Convert.ToBoolean(editRadar.radarUseOrNot);
                m_radarScanRadius.Text = Convert.ToString(editRadar.radarScanRadius);
                this.lat.Text = "经度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(true, editRadar.radarGeoPosX, 10000000, 3);
                this.log.Text = "纬度:" + InteropEncDotNet.GetDegreeStringFromGeoCoor_new(false, editRadar.radarGeoPosY, 10000000, 3);
                if(editRadar.radarShowType == 0)
                {
                    radarshowtype0.Checked = true;
                }
                else
                {
                    radarshowtype1.Checked = true;
                }
                this.showType = editRadar.radarShowType;
                radarColor.BackColor = editRadar.radarShowColor;
                showColor = editRadar.radarShowColor;
            }
            else
            {
                //默认完全显示
                radarshowtype1.Checked = true;
                radarColor.BackColor = Color.FromArgb(0, 255, 0);
            }
        }

        /// <summary>
        /// 插件控件数据是否合法
        /// </summary>
        /// <returns></returns>
        private bool CheckDataISLegal()
        {
            if (m_radarRange.Text == null || m_radarRange.Text.Equals(""))
            {
                MessageBox.Show("雷达量程不能为空！");
                return false;
            }
            else if (m_radarHigh.Text == null || m_radarHigh.Text.Equals(""))
            {
                MessageBox.Show("雷达高度不能为空！");
                return false;
            }
            return true;
        }

        private void radarshowtype0_CheckedChanged(object sender, EventArgs e)
        {
            if(radarshowtype0.Checked == true)
            {
                radarshowtype1.Checked = false;
                showType = 0;
            }
            else
            {
                radarshowtype1.Checked = true;
                showType = 1;
            }
        }

        private void radarshowtype1_CheckedChanged(object sender, EventArgs e)
        {
            if (radarshowtype1.Checked == true)
            {
                radarshowtype0.Checked = false;
                showType = 1;
            }
            else
            {
                radarshowtype0.Checked = true;
                showType = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resutlt = colorDialog.ShowDialog();
            if (resutlt == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                radarColor.BackColor = color;
                showColor = color;
            }
        }

        private void radarBaseInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckDataISLegal())
            {
                if (editRadar != null)
                {
                    editRadar.radarName = m_radarName.Text;
                    editRadar.radarScanRadius = Convert.ToDouble(m_radarScanRadius.Text);
                    editRadar.radarRange = Convert.ToDouble(m_radarRange.Text);
                    editRadar.radarHigh = Convert.ToDouble(m_radarHigh.Text);
                    editRadar.radarShowType = showType;
                    editRadar.radarShowColor = showColor;
                    if (m_radarUseOrNot.CheckState == CheckState.Checked)
                    {
                        editRadar.radarUseOrNot = 1;
                    }
                }
                if (m_radarUseOrNot.CheckState == CheckState.Checked)
                {
                    useOrNot = 1;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
