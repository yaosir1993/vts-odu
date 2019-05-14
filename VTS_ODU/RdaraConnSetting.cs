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
    public partial class RdaraConnSetting : Form
    {
        public RdaraConnSetting()
        {
            InitializeComponent();
            this.radarecvrport.Text = "9006";
            this.radarrecvip.Text = "127.0.0.1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
