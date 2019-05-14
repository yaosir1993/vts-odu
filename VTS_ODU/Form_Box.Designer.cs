namespace vts_odu
{
    partial class Form_Box
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
            this.label_time = new System.Windows.Forms.Label();
            this.label_head = new System.Windows.Forms.Label();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_lat = new System.Windows.Forms.Label();
            this.label_lon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(12, 58);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(143, 12);
            this.label_time.TabIndex = 9;
            this.label_time.Text = "时间:2017/4/12 12:21:20";
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Location = new System.Drawing.Point(140, 35);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(89, 12);
            this.label_head.TabIndex = 8;
            this.label_head.Text = "航向:129.3(度)";
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(140, 9);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(89, 12);
            this.label_speed.TabIndex = 7;
            this.label_speed.Text = "航速:12.34(节)";
            // 
            // label_lat
            // 
            this.label_lat.AutoSize = true;
            this.label_lat.Location = new System.Drawing.Point(12, 35);
            this.label_lat.Name = "label_lat";
            this.label_lat.Size = new System.Drawing.Size(107, 12);
            this.label_lat.TabIndex = 6;
            this.label_lat.Text = "纬度:21度21.234分";
            // 
            // label_lon
            // 
            this.label_lon.AutoSize = true;
            this.label_lon.Location = new System.Drawing.Point(12, 9);
            this.label_lon.Name = "label_lon";
            this.label_lon.Size = new System.Drawing.Size(113, 12);
            this.label_lon.TabIndex = 5;
            this.label_lon.Text = "经度:121度21.234分";
            // 
            // Form_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 79);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_head);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.label_lat);
            this.Controls.Add(this.label_lon);
            this.Name = "Form_Box";
            this.Text = "Form_Box";
            this.Load += new System.EventHandler(this.Form_Box_Load);
            this.LocationChanged += new System.EventHandler(this.Form_Box_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label_lat;
        private System.Windows.Forms.Label label_lon;
    }
}