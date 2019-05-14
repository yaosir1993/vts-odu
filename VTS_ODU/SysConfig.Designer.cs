namespace vts_odu
{
    partial class SysConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysConfig));
            this.CoachStation_ip = new IpTextBoxExt.IpTextBoxExt();
            this.coachStation_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CoachStation_port = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataBase_pass = new System.Windows.Forms.TextBox();
            this.dataBase_user = new System.Windows.Forms.TextBox();
            this.dataBase_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataBase_ip = new IpTextBoxExt.IpTextBoxExt();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.local_ip = new IpTextBoxExt.IpTextBoxExt();
            this.use_local_ip = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aisRecv_Port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radarRecv_Port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SysConfigOK = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoachStation_ip
            // 
            this.CoachStation_ip.BackColor = System.Drawing.Color.Transparent;
            this.CoachStation_ip.Cursor = System.Windows.Forms.Cursors.Default;
            this.CoachStation_ip.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CoachStation_ip.Location = new System.Drawing.Point(149, 37);
            this.CoachStation_ip.Margin = new System.Windows.Forms.Padding(4);
            this.CoachStation_ip.Name = "CoachStation_ip";
            this.CoachStation_ip.Size = new System.Drawing.Size(306, 29);
            this.CoachStation_ip.TabIndex = 0;
            this.CoachStation_ip.Value = ((System.Net.IPAddress)(resources.GetObject("CoachStation_ip.Value")));
            // 
            // coachStation_label
            // 
            this.coachStation_label.AutoSize = true;
            this.coachStation_label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coachStation_label.Location = new System.Drawing.Point(6, 44);
            this.coachStation_label.Name = "coachStation_label";
            this.coachStation_label.Size = new System.Drawing.Size(142, 19);
            this.coachStation_label.TabIndex = 1;
            this.coachStation_label.Text = "与教练站通信：";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(287, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "通信地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(503, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "通信端口";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CoachStation_port);
            this.groupBox1.Controls.Add(this.coachStation_label);
            this.groupBox1.Controls.Add(this.CoachStation_ip);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(27, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "教练站通信设置";
            // 
            // CoachStation_port
            // 
            this.CoachStation_port.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CoachStation_port.Location = new System.Drawing.Point(469, 37);
            this.CoachStation_port.Name = "CoachStation_port";
            this.CoachStation_port.Size = new System.Drawing.Size(100, 26);
            this.CoachStation_port.TabIndex = 2;
            this.CoachStation_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dataBase_pass);
            this.groupBox2.Controls.Add(this.dataBase_user);
            this.groupBox2.Controls.Add(this.dataBase_port);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataBase_ip);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(27, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 131);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据库通信设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(380, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "密 码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(153, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "用户名：";
            // 
            // dataBase_pass
            // 
            this.dataBase_pass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataBase_pass.Location = new System.Drawing.Point(469, 87);
            this.dataBase_pass.Name = "dataBase_pass";
            this.dataBase_pass.Size = new System.Drawing.Size(100, 26);
            this.dataBase_pass.TabIndex = 6;
            this.dataBase_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataBase_user
            // 
            this.dataBase_user.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataBase_user.Location = new System.Drawing.Point(243, 87);
            this.dataBase_user.Name = "dataBase_user";
            this.dataBase_user.Size = new System.Drawing.Size(100, 26);
            this.dataBase_user.TabIndex = 5;
            this.dataBase_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataBase_port
            // 
            this.dataBase_port.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataBase_port.Location = new System.Drawing.Point(469, 37);
            this.dataBase_port.Name = "dataBase_port";
            this.dataBase_port.Size = new System.Drawing.Size(100, 26);
            this.dataBase_port.TabIndex = 2;
            this.dataBase_port.Text = "3306";
            this.dataBase_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据库通信：";
            // 
            // dataBase_ip
            // 
            this.dataBase_ip.BackColor = System.Drawing.Color.Transparent;
            this.dataBase_ip.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataBase_ip.Location = new System.Drawing.Point(149, 38);
            this.dataBase_ip.Margin = new System.Windows.Forms.Padding(4);
            this.dataBase_ip.Name = "dataBase_ip";
            this.dataBase_ip.Size = new System.Drawing.Size(306, 26);
            this.dataBase_ip.TabIndex = 0;
            this.dataBase_ip.Value = ((System.Net.IPAddress)(resources.GetObject("dataBase_ip.Value")));
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.local_ip);
            this.groupBox3.Controls.Add(this.use_local_ip);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.aisRecv_Port);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.radarRecv_Port);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(27, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 168);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "本机通信设置";
            // 
            // local_ip
            // 
            this.local_ip.BackColor = System.Drawing.Color.Transparent;
            this.local_ip.Cursor = System.Windows.Forms.Cursors.Default;
            this.local_ip.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.local_ip.Location = new System.Drawing.Point(263, 102);
            this.local_ip.Margin = new System.Windows.Forms.Padding(4);
            this.local_ip.Name = "local_ip";
            this.local_ip.Size = new System.Drawing.Size(306, 26);
            this.local_ip.TabIndex = 3;
            this.local_ip.Value = ((System.Net.IPAddress)(resources.GetObject("local_ip.Value")));
            // 
            // use_local_ip
            // 
            this.use_local_ip.AutoSize = true;
            this.use_local_ip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.use_local_ip.Location = new System.Drawing.Point(344, 140);
            this.use_local_ip.Name = "use_local_ip";
            this.use_local_ip.Size = new System.Drawing.Size(203, 20);
            this.use_local_ip.TabIndex = 7;
            this.use_local_ip.Text = "启用手动配置本机IP参数";
            this.use_local_ip.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "手动配置本机IP地址：";
            // 
            // aisRecv_Port
            // 
            this.aisRecv_Port.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aisRecv_Port.Location = new System.Drawing.Point(446, 62);
            this.aisRecv_Port.Name = "aisRecv_Port";
            this.aisRecv_Port.Size = new System.Drawing.Size(100, 26);
            this.aisRecv_Port.TabIndex = 4;
            this.aisRecv_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "本机接收AIS船舶数据端口：";
            // 
            // radarRecv_Port
            // 
            this.radarRecv_Port.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radarRecv_Port.Location = new System.Drawing.Point(446, 26);
            this.radarRecv_Port.Name = "radarRecv_Port";
            this.radarRecv_Port.Size = new System.Drawing.Size(100, 26);
            this.radarRecv_Port.TabIndex = 2;
            this.radarRecv_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "本机接收雷达数据端口：";
            // 
            // SysConfigOK
            // 
            this.SysConfigOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SysConfigOK.BackColor = System.Drawing.Color.Transparent;
            this.SysConfigOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SysConfigOK.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.SysConfigOK.BorderColor = System.Drawing.Color.Transparent;
            this.SysConfigOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SysConfigOK.DownBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.SysConfigOK.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.SysConfigOK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SysConfigOK.ForeColor = System.Drawing.Color.Black;
            this.SysConfigOK.Location = new System.Drawing.Point(322, 474);
            this.SysConfigOK.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.SysConfigOK.Name = "SysConfigOK";
            this.SysConfigOK.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.SysConfigOK.Size = new System.Drawing.Size(109, 36);
            this.SysConfigOK.TabIndex = 9;
            this.SysConfigOK.Text = "确  定";
            this.SysConfigOK.UseVisualStyleBackColor = false;
            this.SysConfigOK.Click += new System.EventHandler(this.SysConfigOK_Click_1);
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
            this.skinButton1.Location = new System.Drawing.Point(481, 474);
            this.skinButton1.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.skinButton1.Size = new System.Drawing.Size(109, 36);
            this.skinButton1.TabIndex = 10;
            this.skinButton1.Text = "取  消";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // SysConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 522);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.SysConfigOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SysConfig";
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.SysConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IpTextBoxExt.IpTextBoxExt CoachStation_ip;
        private System.Windows.Forms.Label coachStation_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CoachStation_port;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dataBase_port;
        private System.Windows.Forms.Label label3;
        private IpTextBoxExt.IpTextBoxExt dataBase_ip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox aisRecv_Port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox radarRecv_Port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dataBase_pass;
        private System.Windows.Forms.TextBox dataBase_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox use_local_ip;
        private IpTextBoxExt.IpTextBoxExt local_ip;
        private CCWin.SkinControl.SkinButton SysConfigOK;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}