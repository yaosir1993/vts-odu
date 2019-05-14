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
    public partial class ShipAddForm : Form
    {
        public CShip editShip = null;
        private List<CShipType> shipTypeList = null;
        public CShipType currentShipType = null;
        private List<CShipModel> modelList = null;
        public ShipAddForm(List<CShipType> _shipTypeList,CShip _editShip)
        {
            InitializeComponent();
            shipTypeList = _shipTypeList;
            modelList = new List<CShipModel>();
            this.editShip = _editShip;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_ship.Filter = "*.jpg|*.jpg|*.png|*.png|*.bmp|*.bmp|*.tiff|*.tiff";//图片格式
                if (openFileDialog_ship.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //String pictureRealPos = openFileDialog_ship.FileName;//实际的文件路径+文件名
                        shipPictureBox.BackgroundImage = Image.FromFile(openFileDialog_ship.FileName);//将图片显示在pitureBox控件中
                    }
                    catch
                    {
                        MessageBox.Show("您选择的图片不能被读取或文件类型不对！", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("上传相片出错: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                if (editShip != null)
                {
                    editShip.shipName = shipname.Text;
                    editShip.shipHeading = Convert.ToDouble(shipheading.Text);
                    editShip.shipCourse = Convert.ToDouble(shipcourse.Text);
                    editShip.shipType = currentShipType;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        /// <summary>
        /// 数据检查
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            if(shipname.Text == null || shipname.Text.Equals(""))
            {
                MessageBox.Show("船舶名称不能为空！");
                return false;
            }
            else if (shipcourse.Text == null || shipcourse.Text.Equals(""))
            {
                MessageBox.Show("航向数据不能为空！");
                return false;
            }
            else if(!Common.IsNumeric(shipcourse.Text.ToString()))
            {
                MessageBox.Show("航向数据无效，请检查！");
                return false;
            }
            else if(shipheading.Text == null || shipheading.Text.Equals(""))
            {
                MessageBox.Show("船首向数据不能为空，请检查！");
                return false;
            }
            else if(!Common.IsNumeric(shipheading.Text.ToString()))
            {
                MessageBox.Show("船首向数据无效，请检查！");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ShipAddForm_Load(object sender, EventArgs e)
        {
            shiptype.DataSource = shipTypeList;
            shiptype.ValueMember = "shipTypeId";
            shiptype.DisplayMember = "shipTypeName";
            
            //1:5万吨 2:巡逻30米 3：巡逻40米 4：巡逻60米 5：海监1500
            modelList.Add(new CShipModel(1, "5万吨"));
            modelList.Add(new CShipModel(2, "巡逻30米"));
            modelList.Add(new CShipModel(3, "巡逻40米"));
            modelList.Add(new CShipModel(4, "巡逻60米"));
            modelList.Add(new CShipModel(5, "海监1500"));
            shipmodel.DataSource = modelList;
            shipmodel.ValueMember = "modelID";
            shipmodel.DisplayMember = "modelName";
            if (editShip != null)
            {
                shipcourse.Text = Convert.ToString(editShip.shipCourse);
                shipheading.Text = Convert.ToString(editShip.shipHeading);
                shipname.Text = editShip.shipName;
                shipmmsi.Text = Convert.ToString(editShip.shipMMSI);
                changeContent(editShip.shipType.shipTypeId);
            }
            else
            {
                changeContent(0);
            }
            this.shipmmsi.Text = Convert.ToString(Common.GenerateRandomMMSI());
        }

        private void shiptype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int typeid = Convert.ToInt32(this.shiptype.SelectedValue.ToString());
            changeContent(typeid);
        }

        private void changeContent(int index)
        {
            if(index >= 0)
            {
                CShipType typeObject = shipTypeList[index];
                shiptype.SelectedValue = index;
                shiptypename.Text = typeObject.shipTypeName;
                psl.Text = typeObject.shipDisplacement.ToString();
                maxspeed.Text = typeObject.shipMaxSpeed.ToString();
                shiplength.Text = Convert.ToString(typeObject.shipLength/1852);
                shipwidth.Text = Convert.ToString(typeObject.shipWidth/1852);
                scs.Text = typeObject.shipBowDraught.ToString();
                wcs.Text = typeObject.shipSternDraught.ToString();
                kzsgd.Text = typeObject.shipControlRoomHeight.ToString();
                currentShipType = typeObject;
            }
        }
    }
}
