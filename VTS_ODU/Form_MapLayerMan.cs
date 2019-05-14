using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vts_odu
{
    public partial class Form_MapLayerMan : Form
    {
        private bool m_bInitOk = false;
        private int m_iCurLayerCount = 0;
        private int m_iShowLayerCount = 0;
        public Form_MapLayerMan()
        {
            InitializeComponent();
        }

        private void Form_MapLayerMan_Load(object sender, EventArgs e)
        {
            BinLayerList("");
        }

        private void BinLayerList(string strSelName)
        {
            AxYIMAENCLib.AxYimaEnc yimaEnc = ((FormMain)this.Owner).ymEncCtrl;
            m_iCurLayerCount = 0;
            m_iShowLayerCount = 0;
            m_bInitOk = false;
            this.dataGridView_List.Rows.Clear();
            int iLayerCount = yimaEnc.GetLayerCount(-1);//mapPos = -1 表示获取S52显示标准的图层

            for (int i = 0; i < iLayerCount; i++)
            {
                string layerName = new string(' ', 255);
                string layerNameToken = new string(' ', 255);
                int attrCount = 0;

                yimaEnc.GetLayerInfo(-1, i, ref layerName, ref layerNameToken, ref attrCount);
                string strLayerName = layerName.Trim();
                if (!strSelName.Equals(""))
                {
                    if (strLayerName.IndexOf(strSelName) == -1)
                    {
                        continue;
                    }
                }

                bool bLayerDrawOrNot = yimaEnc.GetLayerDrawOrNot(-1, i);
                int newRowIndex = this.dataGridView_List.Rows.Add();
                this.dataGridView_List.Rows[newRowIndex].Cells["pos"].Value = i;
                this.dataGridView_List.Rows[newRowIndex].Cells["LayerName"].Value = strLayerName;
                this.dataGridView_List.Rows[newRowIndex].Cells["isDisplay"].Value = bLayerDrawOrNot;
                m_iCurLayerCount++;

                if (bLayerDrawOrNot)
                {
                    m_iShowLayerCount++;
                }
            }

            m_bInitOk = true;
            this.groupBox_Rcd.Text = "查询图层数量:" + m_iCurLayerCount + " = 显示(" + m_iShowLayerCount.ToString() + ")+ 隐藏(" + (m_iCurLayerCount - m_iShowLayerCount).ToString() + ")";
        }

        private void dataGridView_List_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (m_bInitOk)
            {
                ((FormMain)this.Owner).RedrawMapScreen();
            }

        }

        private void button_btnSel_Click(object sender, EventArgs e)
        {
            string strSelLayerName = this.textBox_SelName.Text.Trim();
            BinLayerList(strSelLayerName);
        }

        private void btn_DrawAllLayer_Click(object sender, EventArgs e)
        {
            bool bDrawAllLayer = false;
            string strMsgInfo;
            if (sender == this.btn_DrawAllLayer)
            {
                strMsgInfo = "即将显示当前所有图层，您是否确认显示？";
                bDrawAllLayer = true;
            }
            else
            {
                strMsgInfo = "即将隐藏当前所有图层，您是否确认隐藏？";
            }

            if (MessageBox.Show(strMsgInfo, "图层控制", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            m_bInitOk = false;

            int iRowsCount = this.dataGridView_List.Rows.Count;
            if (iRowsCount > 0)
            {
                AxYIMAENCLib.AxYimaEnc yimaEnc = ((FormMain)this.Owner).ymEncCtrl;
                for (int i = 0; i < iRowsCount; i++)
                {
                    int iLayerPos = Convert.ToInt32(this.dataGridView_List.Rows[i].Cells["pos"].Value);
                    yimaEnc.SetLayerDrawOrNot(-1, iLayerPos, bDrawAllLayer);

                    this.dataGridView_List.Rows[i].Cells["isDisplay"].Value = bDrawAllLayer;
                }
                ((FormMain)this.Owner).RedrawMapScreen();
            }

            m_bInitOk = true;
        }

        private void textBox_SelName_TextChanged(object sender, EventArgs e)
        {
            string strNameKey = this.textBox_SelName.Text.Trim();
            BinLayerList(strNameKey);
            //MessageBox.Show(strNameKey);
        }

        private void dataGridView_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            if (iRow > 0)
            {
                AxYIMAENCLib.AxYimaEnc yimaEnc = ((FormMain)this.Owner).ymEncCtrl;
                int iLayerPos = Convert.ToInt32(this.dataGridView_List.Rows[iRow].Cells["pos"].Value);
                bool bLayerDrawOrNot = !(bool)this.dataGridView_List.Rows[iRow].Cells["isDisplay"].Value;
                this.dataGridView_List.Rows[iRow].Cells["isDisplay"].Value = bLayerDrawOrNot;
                //bool bLayerDrawOrNot = Convert.ToBoolean(this.dataGridView_List.Rows[iRow].Cells["isDisplay"].EditedFormattedValue.ToString());
                bool bCurDrawOrNot = yimaEnc.GetLayerDrawOrNot(-1, iLayerPos);
                yimaEnc.SetLayerDrawOrNot(-1, iLayerPos, bLayerDrawOrNot);

                if (bLayerDrawOrNot)
                {
                    m_iShowLayerCount++;
                }
                else
                {
                    m_iShowLayerCount--;
                }
                this.groupBox_Rcd.Text = "查询图层数量:" + m_iCurLayerCount + " = 显示(" + m_iShowLayerCount.ToString() + ")+ 隐藏(" + (m_iCurLayerCount - m_iShowLayerCount).ToString() + ")";
            }
        }

        private void dataGridView_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            if (iRow > 0 && iCol == 2)
            {
                AxYIMAENCLib.AxYimaEnc yimaEnc = ((FormMain)this.Owner).ymEncCtrl;
                int iLayerPos = Convert.ToInt32(this.dataGridView_List.Rows[iRow].Cells["pos"].Value);
                bool bLayerDrawOrNot = Convert.ToBoolean(this.dataGridView_List.Rows[iRow].Cells["isDisplay"].EditedFormattedValue.ToString());
                bool bCurDrawOrNot = yimaEnc.GetLayerDrawOrNot(-1, iLayerPos);
                yimaEnc.SetLayerDrawOrNot(-1, iLayerPos, bLayerDrawOrNot);
                if (bLayerDrawOrNot)
                {
                    m_iShowLayerCount++;
                }
                else
                {
                    m_iShowLayerCount--;
                }
                this.groupBox_Rcd.Text = "查询图层数量:" + m_iCurLayerCount + " = 显示(" + m_iShowLayerCount.ToString() + ")+ 隐藏(" + (m_iCurLayerCount - m_iShowLayerCount).ToString() + ")";
            }
        }
    }
}
