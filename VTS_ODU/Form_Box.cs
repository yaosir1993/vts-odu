using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class Form_Box : Form
    {
        public M_POINT m_mOffsetScrnPo;
        public M_POINT m_curShipScrnPo;
        public bool m_bDragFormForLocationChanged;

        public string m_strName;


        public Form_Box()
        {
            InitializeComponent();
        }

        private void Form_Box_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.ShowInTaskbar = false;//不在底部栏显示
            this.m_mOffsetScrnPo = new M_POINT(50, -50);
            this.m_curShipScrnPo = new M_POINT();
            this.m_strName = "";
        }

        private void Form_Box_LocationChanged(object sender, EventArgs e)
        {
            if (this.m_bDragFormForLocationChanged == true)
            {
                m_mOffsetScrnPo.x = this.Location.X - this.m_curShipScrnPo.x;
                m_mOffsetScrnPo.y = this.Location.Y - this.m_curShipScrnPo.y;

                ((FormMain)this.Owner).RedrawMapScreen();
            }
        }

        public void SetFormLocation(M_POINT scrnPo)
        {
            this.m_bDragFormForLocationChanged = false;
            this.Location = new System.Drawing.Point(scrnPo.x, scrnPo.y);
            this.m_bDragFormForLocationChanged = true;
        }
    }
}
