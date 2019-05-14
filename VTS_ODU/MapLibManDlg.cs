using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class MapLibManDlg : Form
    {
        public MapLibManDlg()
        {
            InitializeComponent();
        }

        private void OverviewMapButton_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Owner).ymEncCtrl.OverViewLibMap(this.mapLibList.SelectedIndex);
            ((FormMain)this.Owner).RedrawMapScreen(); 
        }

        private void LoadMapFileToLibButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileNames.ToString().Equals(""))
            {
                return;
            }
            int listBoxItemsCount = this.mapLibList.Items.Count;
            foreach (string fileNamePath in openFileDialog1.FileNames)
            {
                bool isAdded = false;
                for (int i = 0; i < listBoxItemsCount; i++)
                {
                    string fileName = fileNamePath.Substring(fileNamePath.LastIndexOf("\\")+1,fileNamePath.LastIndexOf(".") - fileNamePath.LastIndexOf("\\")-1);
                    string listBoxItemValue = this.mapLibList.Items[i].ToString();
                    string mapLibName;
                    if (listBoxItemValue.LastIndexOf((char)0) > 0)
                    {
                        mapLibName = listBoxItemValue.Substring(0, listBoxItemValue.LastIndexOf((char)0));
                    }
                    else
                    {
                        mapLibName = listBoxItemValue;
                    }
                    
                    if (mapLibName.Equals(fileName))
                    {
                        isAdded = true;
                        break;
                    }
                }
                if (!isAdded)
                {
                    ((FormMain)this.Owner).ymEncCtrl.AddMapToLib(fileNamePath);
                }                
            }            
            RefreshMapList();
        }

        private void DeleteMapButton_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Owner).ymEncCtrl.DeleteLibMap(this.mapLibList.SelectedIndex);
            this.mapLibList.Items.RemoveAt(this.mapLibList.SelectedIndex);

        }

        private void MapLibManDlg_Load(object sender, EventArgs e)
        {
            RefreshMapList();
        }

        private void RefreshMapList()
        {
            mapLibList.Items.Clear();
            int libMapCount = ((FormMain)this.Owner).ymEncCtrl.GetLibMapCount();
            for (int mapNum = 0; mapNum < libMapCount; mapNum++)
            {
                string mapName = new string('1', 255);
                string mapType = new string('1', 50);
                float scale = 0;
                int a1, a2, a3, a4, a5, a6;
                a1 = a2 = a3 = a4 = a5 = a6 = 0;

                int a7, a8, a9, a10;
                a7 = a8 = a9 = a10 = 0;
                string str1 = "1111111111111111111111111";
                ((FormMain)this.Owner).ymEncCtrl.GetLibMapInfo(mapNum, ref mapType, ref mapName, ref  scale, ref  a1, ref  a2, ref a3, ref  a4, ref  a5, ref  a6, ref a7, ref a8, ref a9, ref a10, ref str1);
                mapLibList.Items.Add(mapName);
            }
        }

        private void mapLibList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mapName = new string('1', 255);
            string mapType = new string('1', 50);
            float scale = 0;
            int up, down, left, right, edtion, update;
            up = down = left = right = edtion = update = 0;
            int a7, a8, a9, a10;
            a7 = a8 = a9 = a10 = 0;
            string str1 = "aaaaaaaaaaaaaaaaaaaaaa";
            ((FormMain)this.Owner).ymEncCtrl.GetLibMapInfo(this.mapLibList.SelectedIndex, ref mapType, ref mapName, ref  scale, ref left, ref right, ref up, ref down, ref edtion, ref update, ref a7, ref a8, ref a9, ref a10, ref str1);
  
            this.OrgScaleText.Text = scale.ToString();
            this.editionText.Text = edtion.ToString();
            this.tb_UpdateNum.Text = update.ToString();
            this.upMostText.Text = InteropEncDotNet.GetDegreeStringFromGeoCoor(false, up, ((FormMain)this.Owner).ymEncCtrl.GetGeoCoorMultiFactor());
            this.downMostText.Text = InteropEncDotNet.GetDegreeStringFromGeoCoor(false, down, ((FormMain)this.Owner).ymEncCtrl.GetGeoCoorMultiFactor());
            this.leftMostText.Text = InteropEncDotNet.GetDegreeStringFromGeoCoor(true, left, ((FormMain)this.Owner).ymEncCtrl.GetGeoCoorMultiFactor());
            this.rightMostText.Text = InteropEncDotNet.GetDegreeStringFromGeoCoor(true, right, ((FormMain)this.Owner).ymEncCtrl.GetGeoCoorMultiFactor());
        }

        private void mapLibList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ((FormMain)this.Owner).ymEncCtrl.OverViewLibMap(this.mapLibList.SelectedIndex);
            ((FormMain)this.Owner).RedrawMapScreen(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}