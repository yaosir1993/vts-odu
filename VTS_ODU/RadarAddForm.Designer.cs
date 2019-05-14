namespace vts_odu
{
    partial class RadarAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.m_radarName = new System.Windows.Forms.TextBox();
            this.m_radarRange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_radarScanRadius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radarSettingInfo = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radarColor = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radarshowtype1 = new System.Windows.Forms.RadioButton();
            this.m_radarUseOrNot = new System.Windows.Forms.CheckBox();
            this.radarshowtype0 = new System.Windows.Forms.RadioButton();
            this.m_radarHigh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radarBaseInfo = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.Label();
            this.lat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_radarGeoPosY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_radarGeoPosX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.radarSettingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radarColor)).BeginInit();
            this.radarBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "雷达名称:";
            // 
            // m_radarName
            // 
            this.m_radarName.Enabled = false;
            this.m_radarName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_radarName.Location = new System.Drawing.Point(171, 38);
            this.m_radarName.Name = "m_radarName";
            this.m_radarName.Size = new System.Drawing.Size(129, 26);
            this.m_radarName.TabIndex = 1;
            // 
            // m_radarRange
            // 
            this.m_radarRange.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_radarRange.Location = new System.Drawing.Point(180, 35);
            this.m_radarRange.Name = "m_radarRange";
            this.m_radarRange.Size = new System.Drawing.Size(129, 26);
            this.m_radarRange.TabIndex = 5;
            this.m_radarRange.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(58, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "雷达量程:";
            // 
            // m_radarScanRadius
            // 
            this.m_radarScanRadius.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_radarScanRadius.Location = new System.Drawing.Point(171, 83);
            this.m_radarScanRadius.Name = "m_radarScanRadius";
            this.m_radarScanRadius.Size = new System.Drawing.Size(129, 26);
            this.m_radarScanRadius.TabIndex = 7;
            this.m_radarScanRadius.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "雷达扫描半径:";
            // 
            // radarSettingInfo
            // 
            this.radarSettingInfo.Controls.Add(this.label14);
            this.radarSettingInfo.Controls.Add(this.label13);
            this.radarSettingInfo.Controls.Add(this.radarColor);
            this.radarSettingInfo.Controls.Add(this.label12);
            this.radarSettingInfo.Controls.Add(this.radarshowtype1);
            this.radarSettingInfo.Controls.Add(this.m_radarUseOrNot);
            this.radarSettingInfo.Controls.Add(this.radarshowtype0);
            this.radarSettingInfo.Controls.Add(this.label3);
            this.radarSettingInfo.Controls.Add(this.m_radarRange);
            this.radarSettingInfo.Controls.Add(this.m_radarHigh);
            this.radarSettingInfo.Controls.Add(this.label9);
            this.radarSettingInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radarSettingInfo.Location = new System.Drawing.Point(435, 24);
            this.radarSettingInfo.Name = "radarSettingInfo";
            this.radarSettingInfo.Size = new System.Drawing.Size(353, 272);
            this.radarSettingInfo.TabIndex = 8;
            this.radarSettingInfo.TabStop = false;
            this.radarSettingInfo.Text = "雷达参数设置";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(209, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "默认颜色为绿色";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(29, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "雷达显示颜色:";
            // 
            // radarColor
            // 
            this.radarColor.BackColor = System.Drawing.Color.Green;
            this.radarColor.Location = new System.Drawing.Point(183, 190);
            this.radarColor.Name = "radarColor";
            this.radarColor.Size = new System.Drawing.Size(20, 20);
            this.radarColor.TabIndex = 20;
            this.radarColor.TabStop = false;
            this.radarColor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(29, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "雷达显示类型:";
            // 
            // radarshowtype1
            // 
            this.radarshowtype1.AutoSize = true;
            this.radarshowtype1.Location = new System.Drawing.Point(183, 154);
            this.radarshowtype1.Name = "radarshowtype1";
            this.radarshowtype1.Size = new System.Drawing.Size(90, 20);
            this.radarshowtype1.TabIndex = 17;
            this.radarshowtype1.TabStop = true;
            this.radarshowtype1.Text = "完全显示";
            this.radarshowtype1.UseVisualStyleBackColor = true;
            this.radarshowtype1.CheckedChanged += new System.EventHandler(this.radarshowtype1_CheckedChanged);
            // 
            // m_radarUseOrNot
            // 
            this.m_radarUseOrNot.AutoSize = true;
            this.m_radarUseOrNot.Checked = true;
            this.m_radarUseOrNot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_radarUseOrNot.Enabled = false;
            this.m_radarUseOrNot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_radarUseOrNot.Location = new System.Drawing.Point(180, 233);
            this.m_radarUseOrNot.Name = "m_radarUseOrNot";
            this.m_radarUseOrNot.Size = new System.Drawing.Size(123, 20);
            this.m_radarUseOrNot.TabIndex = 35;
            this.m_radarUseOrNot.Text = "是否开启雷达";
            this.m_radarUseOrNot.UseVisualStyleBackColor = true;
            // 
            // radarshowtype0
            // 
            this.radarshowtype0.AutoSize = true;
            this.radarshowtype0.Location = new System.Drawing.Point(183, 122);
            this.radarshowtype0.Name = "radarshowtype0";
            this.radarshowtype0.Size = new System.Drawing.Size(90, 20);
            this.radarshowtype0.TabIndex = 16;
            this.radarshowtype0.TabStop = true;
            this.radarshowtype0.Text = "余晖显示";
            this.radarshowtype0.UseVisualStyleBackColor = true;
            this.radarshowtype0.CheckedChanged += new System.EventHandler(this.radarshowtype0_CheckedChanged);
            // 
            // m_radarHigh
            // 
            this.m_radarHigh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_radarHigh.Location = new System.Drawing.Point(180, 79);
            this.m_radarHigh.Name = "m_radarHigh";
            this.m_radarHigh.Size = new System.Drawing.Size(129, 26);
            this.m_radarHigh.TabIndex = 13;
            this.m_radarHigh.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(58, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "雷达高度:";
            // 
            // radarBaseInfo
            // 
            this.radarBaseInfo.Controls.Add(this.log);
            this.radarBaseInfo.Controls.Add(this.lat);
            this.radarBaseInfo.Controls.Add(this.label11);
            this.radarBaseInfo.Controls.Add(this.label6);
            this.radarBaseInfo.Controls.Add(this.label5);
            this.radarBaseInfo.Controls.Add(this.m_radarGeoPosY);
            this.radarBaseInfo.Controls.Add(this.label8);
            this.radarBaseInfo.Controls.Add(this.m_radarGeoPosX);
            this.radarBaseInfo.Controls.Add(this.label7);
            this.radarBaseInfo.Controls.Add(this.label1);
            this.radarBaseInfo.Controls.Add(this.m_radarName);
            this.radarBaseInfo.Controls.Add(this.m_radarScanRadius);
            this.radarBaseInfo.Controls.Add(this.label4);
            this.radarBaseInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radarBaseInfo.Location = new System.Drawing.Point(22, 24);
            this.radarBaseInfo.Name = "radarBaseInfo";
            this.radarBaseInfo.Size = new System.Drawing.Size(387, 272);
            this.radarBaseInfo.TabIndex = 9;
            this.radarBaseInfo.TabStop = false;
            this.radarBaseInfo.Text = "雷达基本信息";
            this.radarBaseInfo.Enter += new System.EventHandler(this.radarBaseInfo_Enter);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(23, 246);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(0, 16);
            this.log.TabIndex = 37;
            // 
            // lat
            // 
            this.lat.AutoSize = true;
            this.lat.Location = new System.Drawing.Point(23, 212);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(0, 16);
            this.lat.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(307, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(307, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(307, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "米(m)";
            // 
            // m_radarGeoPosY
            // 
            this.m_radarGeoPosY.Enabled = false;
            this.m_radarGeoPosY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_radarGeoPosY.Location = new System.Drawing.Point(171, 165);
            this.m_radarGeoPosY.Name = "m_radarGeoPosY";
            this.m_radarGeoPosY.Size = new System.Drawing.Size(129, 26);
            this.m_radarGeoPosY.TabIndex = 11;
            this.m_radarGeoPosY.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(17, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "雷达位置坐标(Y):";
            // 
            // m_radarGeoPosX
            // 
            this.m_radarGeoPosX.Enabled = false;
            this.m_radarGeoPosX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_radarGeoPosX.Location = new System.Drawing.Point(171, 125);
            this.m_radarGeoPosX.Name = "m_radarGeoPosX";
            this.m_radarGeoPosX.Size = new System.Drawing.Size(129, 26);
            this.m_radarGeoPosX.TabIndex = 9;
            this.m_radarGeoPosX.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(17, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "雷达位置坐标(X):";
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
            this.btnLogin.Location = new System.Drawing.Point(485, 320);
            this.btnLogin.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.btnLogin.Size = new System.Drawing.Size(130, 36);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "确  定";
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
            this.skinButton1.Location = new System.Drawing.Point(647, 320);
            this.skinButton1.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.skinButton1.Size = new System.Drawing.Size(130, 36);
            this.skinButton1.TabIndex = 13;
            this.skinButton1.Text = "取  消";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // RadarAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.radarBaseInfo);
            this.Controls.Add(this.radarSettingInfo);
            this.Name = "RadarAddForm";
            this.Text = "RadarAddForm";
            this.Load += new System.EventHandler(this.RadarAddForm_Load);
            this.radarSettingInfo.ResumeLayout(false);
            this.radarSettingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radarColor)).EndInit();
            this.radarBaseInfo.ResumeLayout(false);
            this.radarBaseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox radarSettingInfo;
        private System.Windows.Forms.GroupBox radarBaseInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox m_radarName;
        public System.Windows.Forms.TextBox m_radarScanRadius;
        public System.Windows.Forms.TextBox m_radarGeoPosX;
        public System.Windows.Forms.TextBox m_radarHigh;
        public System.Windows.Forms.TextBox m_radarGeoPosY;
        public System.Windows.Forms.TextBox m_radarRange;
        public System.Windows.Forms.CheckBox m_radarUseOrNot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label lat;
        private System.Windows.Forms.RadioButton radarshowtype1;
        private System.Windows.Forms.RadioButton radarshowtype0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox radarColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}