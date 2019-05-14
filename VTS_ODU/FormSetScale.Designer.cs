namespace vts_odu
{
    partial class FormSetScale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetScale));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_scale = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_scale = new System.Windows.Forms.TextBox();
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择比例尺:";
            // 
            // cmb_scale
            // 
            this.cmb_scale.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_scale.FormattingEnabled = true;
            this.cmb_scale.Items.AddRange(new object[] {
            "1:1000",
            "1:5000",
            "1:10000",
            "1:50000",
            "1:100000",
            "1:500000",
            "1:1000000",
            "1:5000000",
            "1:10000000"});
            this.cmb_scale.Location = new System.Drawing.Point(34, 41);
            this.cmb_scale.Name = "cmb_scale";
            this.cmb_scale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_scale.Size = new System.Drawing.Size(188, 24);
            this.cmb_scale.TabIndex = 1;
            this.cmb_scale.SelectedIndexChanged += new System.EventHandler(this.cmb_scale_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "指定比例尺:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "1 :";
            // 
            // txt_scale
            // 
            this.txt_scale.Location = new System.Drawing.Point(68, 117);
            this.txt_scale.Name = "txt_scale";
            this.txt_scale.Size = new System.Drawing.Size(154, 21);
            this.txt_scale.TabIndex = 4;
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
            this.btnLogin.Location = new System.Drawing.Point(265, 35);
            this.btnLogin.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.btnLogin.Size = new System.Drawing.Size(98, 34);
            this.btnLogin.TabIndex = 13;
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
            this.skinButton1.Location = new System.Drawing.Point(265, 107);
            this.skinButton1.MouseBack = global::vts_odu.Properties.Resources.小按钮2选中_2x;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = global::vts_odu.Properties.Resources.小按钮2未选中_2x;
            this.skinButton1.Size = new System.Drawing.Size(98, 34);
            this.skinButton1.TabIndex = 14;
            this.skinButton1.Text = "取  消";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // FormSetScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 150);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txt_scale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_scale);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetScale";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "指定比例尺";
            this.Load += new System.EventHandler(this.FormSetScale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_scale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_scale;
        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}