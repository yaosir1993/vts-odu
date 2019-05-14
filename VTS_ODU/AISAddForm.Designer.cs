namespace vts_odu
{
    partial class AISAddForm
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
            this.m_aisGeoPosY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_aisGeoPosX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_aisName = new System.Windows.Forms.TextBox();
            this.m_aisScanRadius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_aisUseOrNot = new System.Windows.Forms.CheckBox();
            this.log = new System.Windows.Forms.Label();
            this.lat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_aisGeoPosY
            // 
            this.m_aisGeoPosY.Enabled = false;
            this.m_aisGeoPosY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_aisGeoPosY.Location = new System.Drawing.Point(231, 193);
            this.m_aisGeoPosY.Name = "m_aisGeoPosY";
            this.m_aisGeoPosY.Size = new System.Drawing.Size(129, 26);
            this.m_aisGeoPosY.TabIndex = 24;
            this.m_aisGeoPosY.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(45, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "AIS基站坐标(Y):";
            // 
            // m_aisGeoPosX
            // 
            this.m_aisGeoPosX.Enabled = false;
            this.m_aisGeoPosX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_aisGeoPosX.Location = new System.Drawing.Point(231, 153);
            this.m_aisGeoPosX.Name = "m_aisGeoPosX";
            this.m_aisGeoPosX.Size = new System.Drawing.Size(129, 26);
            this.m_aisGeoPosX.TabIndex = 21;
            this.m_aisGeoPosX.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(45, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "AIS基站坐标(X):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(69, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "*AIS基站名称:";
            // 
            // m_aisName
            // 
            this.m_aisName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_aisName.Location = new System.Drawing.Point(231, 66);
            this.m_aisName.Name = "m_aisName";
            this.m_aisName.Size = new System.Drawing.Size(129, 26);
            this.m_aisName.TabIndex = 17;
            // 
            // m_aisScanRadius
            // 
            this.m_aisScanRadius.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_aisScanRadius.Location = new System.Drawing.Point(231, 111);
            this.m_aisScanRadius.Name = "m_aisScanRadius";
            this.m_aisScanRadius.Size = new System.Drawing.Size(129, 26);
            this.m_aisScanRadius.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(37, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "*AIS基站覆盖半径:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "取  消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "确  定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(368, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "千米(km)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(50, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "友情提示：*号表示该项为必填项!!!";
            // 
            // m_aisUseOrNot
            // 
            this.m_aisUseOrNot.AutoSize = true;
            this.m_aisUseOrNot.Checked = true;
            this.m_aisUseOrNot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_aisUseOrNot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_aisUseOrNot.Location = new System.Drawing.Point(231, 235);
            this.m_aisUseOrNot.Name = "m_aisUseOrNot";
            this.m_aisUseOrNot.Size = new System.Drawing.Size(147, 20);
            this.m_aisUseOrNot.TabIndex = 34;
            this.m_aisUseOrNot.Text = "是否开启AIS基站";
            this.m_aisUseOrNot.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log.Location = new System.Drawing.Point(38, 303);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(0, 16);
            this.log.TabIndex = 39;
            // 
            // lat
            // 
            this.lat.AutoSize = true;
            this.lat.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lat.Location = new System.Drawing.Point(38, 269);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(0, 16);
            this.lat.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(93, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "显示状态:";
            // 
            // AISAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 394);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.log);
            this.Controls.Add(this.lat);
            this.Controls.Add(this.m_aisUseOrNot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_aisGeoPosY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.m_aisGeoPosX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_aisName);
            this.Controls.Add(this.m_aisScanRadius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AISAddForm";
            this.Text = "添加AIS基站";
            this.Load += new System.EventHandler(this.AISAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox m_aisGeoPosY;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox m_aisGeoPosX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox m_aisName;
        public System.Windows.Forms.TextBox m_aisScanRadius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox m_aisUseOrNot;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label lat;
        private System.Windows.Forms.Label label9;
    }
}