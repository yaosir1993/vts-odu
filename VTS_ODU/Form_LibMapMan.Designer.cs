namespace vts_odu
{
    partial class Form_LibMapMan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_MapNameKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_MapList = new System.Windows.Forms.DataGridView();
            this.groupBox_List = new System.Windows.Forms.GroupBox();
            this.mapUpdateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapMaxLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapMinLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapMaxLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapMinLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapScale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MapList)).BeginInit();
            this.groupBox_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_MapNameKey
            // 
            this.textBox_MapNameKey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_MapNameKey.Location = new System.Drawing.Point(112, 15);
            this.textBox_MapNameKey.Name = "textBox_MapNameKey";
            this.textBox_MapNameKey.Size = new System.Drawing.Size(159, 26);
            this.textBox_MapNameKey.TabIndex = 5;
            this.textBox_MapNameKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "图幅名称:";
            // 
            // dataGridView_MapList
            // 
            this.dataGridView_MapList.AllowUserToAddRows = false;
            this.dataGridView_MapList.AllowUserToDeleteRows = false;
            this.dataGridView_MapList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MapList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapPos,
            this.mapName,
            this.mapScale,
            this.mapMinLon,
            this.mapMaxLon,
            this.mapMinLat,
            this.mapMaxLat,
            this.MapNumber,
            this.mapUpdateNum});
            this.dataGridView_MapList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MapList.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_MapList.MultiSelect = false;
            this.dataGridView_MapList.Name = "dataGridView_MapList";
            this.dataGridView_MapList.ReadOnly = true;
            this.dataGridView_MapList.RowTemplate.Height = 23;
            this.dataGridView_MapList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MapList.Size = new System.Drawing.Size(716, 415);
            this.dataGridView_MapList.TabIndex = 3;
            this.dataGridView_MapList.DoubleClick += new System.EventHandler(this.dataGridView_MapList_DoubleClick);
            // 
            // groupBox_List
            // 
            this.groupBox_List.Controls.Add(this.dataGridView_MapList);
            this.groupBox_List.Location = new System.Drawing.Point(12, 107);
            this.groupBox_List.Name = "groupBox_List";
            this.groupBox_List.Size = new System.Drawing.Size(722, 435);
            this.groupBox_List.TabIndex = 6;
            this.groupBox_List.TabStop = false;
            this.groupBox_List.Text = "当前图幅数量(100)";
            // 
            // mapUpdateNum
            // 
            this.mapUpdateNum.HeaderText = "更新号";
            this.mapUpdateNum.Name = "mapUpdateNum";
            this.mapUpdateNum.ReadOnly = true;
            this.mapUpdateNum.Width = 70;
            // 
            // MapNumber
            // 
            this.MapNumber.HeaderText = "版本号";
            this.MapNumber.Name = "MapNumber";
            this.MapNumber.ReadOnly = true;
            this.MapNumber.Width = 70;
            // 
            // mapMaxLat
            // 
            this.mapMaxLat.HeaderText = "最大纬度";
            this.mapMaxLat.Name = "mapMaxLat";
            this.mapMaxLat.ReadOnly = true;
            this.mapMaxLat.Width = 80;
            // 
            // mapMinLat
            // 
            this.mapMinLat.HeaderText = "最小纬度";
            this.mapMinLat.Name = "mapMinLat";
            this.mapMinLat.ReadOnly = true;
            this.mapMinLat.Width = 80;
            // 
            // mapMaxLon
            // 
            this.mapMaxLon.HeaderText = "最大经度";
            this.mapMaxLon.Name = "mapMaxLon";
            this.mapMaxLon.ReadOnly = true;
            this.mapMaxLon.Width = 80;
            // 
            // mapMinLon
            // 
            this.mapMinLon.HeaderText = "最小经度";
            this.mapMinLon.Name = "mapMinLon";
            this.mapMinLon.ReadOnly = true;
            this.mapMinLon.Width = 80;
            // 
            // mapScale
            // 
            this.mapScale.HeaderText = "比例尺";
            this.mapScale.Name = "mapScale";
            this.mapScale.ReadOnly = true;
            this.mapScale.Width = 70;
            // 
            // mapName
            // 
            this.mapName.HeaderText = "图幅名称";
            this.mapName.Name = "mapName";
            this.mapName.ReadOnly = true;
            this.mapName.Width = 80;
            // 
            // mapPos
            // 
            this.mapPos.HeaderText = "索引";
            this.mapPos.Name = "mapPos";
            this.mapPos.ReadOnly = true;
            this.mapPos.Width = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "加密密钥:";
            // 
            // textBox_key
            // 
            this.textBox_key.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_key.Location = new System.Drawing.Point(112, 63);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(159, 26);
            this.textBox_key.TabIndex = 11;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.DownBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.btnLogin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(290, 13);
            this.btnLogin.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.btnLogin.Size = new System.Drawing.Size(101, 31);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "加载图幅";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton1.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.skinButton1.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.Black;
            this.skinButton1.Location = new System.Drawing.Point(420, 13);
            this.skinButton1.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.skinButton1.Size = new System.Drawing.Size(101, 31);
            this.skinButton1.TabIndex = 17;
            this.skinButton1.Text = "定位图幅";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton2.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.skinButton2.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton2.ForeColor = System.Drawing.Color.Black;
            this.skinButton2.Location = new System.Drawing.Point(550, 13);
            this.skinButton2.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.skinButton2.Size = new System.Drawing.Size(101, 31);
            this.skinButton2.TabIndex = 18;
            this.skinButton2.Text = "删除图幅";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton3
            // 
            this.skinButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton3.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.skinButton3.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton3.ForeColor = System.Drawing.Color.Black;
            this.skinButton3.Location = new System.Drawing.Point(290, 61);
            this.skinButton3.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.skinButton3.Size = new System.Drawing.Size(101, 31);
            this.skinButton3.TabIndex = 19;
            this.skinButton3.Text = "设置密钥";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // Form_LibMapMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 559);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox_List);
            this.Controls.Add(this.textBox_MapNameKey);
            this.Controls.Add(this.label1);
            this.Name = "Form_LibMapMan";
            this.Text = "海图管理";
            this.Load += new System.EventHandler(this.Form_LibMapMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MapList)).EndInit();
            this.groupBox_List.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MapNameKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_MapList;
        private System.Windows.Forms.GroupBox groupBox_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapScale;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapMinLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapMaxLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapMinLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapMaxLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapUpdateNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_key;
        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton3;
    }
}