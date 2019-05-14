namespace vts_odu
{
    partial class AisShowBox
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
            this.label_height = new System.Windows.Forms.Label();
            this.label_lat = new System.Windows.Forms.Label();
            this.label_radius = new System.Windows.Forms.Label();
            this.label_lon = new System.Windows.Forms.Label();
            this.radar_edit_button = new System.Windows.Forms.Button();
            this.radar_delete_button = new System.Windows.Forms.Button();
            this.radar_stop_button = new System.Windows.Forms.Button();
            this.radar_start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(182, 39);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(89, 12);
            this.label_height.TabIndex = 11;
            this.label_height.Text = "航速:12.45(节)";
            // 
            // label_lat
            // 
            this.label_lat.AutoSize = true;
            this.label_lat.Location = new System.Drawing.Point(18, 39);
            this.label_lat.Name = "label_lat";
            this.label_lat.Size = new System.Drawing.Size(113, 12);
            this.label_lat.TabIndex = 10;
            this.label_lat.Text = "经度:12度32.234分S";
            // 
            // label_radius
            // 
            this.label_radius.AutoSize = true;
            this.label_radius.Location = new System.Drawing.Point(183, 15);
            this.label_radius.Name = "label_radius";
            this.label_radius.Size = new System.Drawing.Size(89, 12);
            this.label_radius.TabIndex = 9;
            this.label_radius.Text = "航向:120.3(度)";
            // 
            // label_lon
            // 
            this.label_lon.AutoSize = true;
            this.label_lon.Location = new System.Drawing.Point(18, 15);
            this.label_lon.Name = "label_lon";
            this.label_lon.Size = new System.Drawing.Size(119, 12);
            this.label_lon.TabIndex = 8;
            this.label_lon.Text = "经度:121度32.234分W";
            // 
            // radar_edit_button
            // 
            this.radar_edit_button.Location = new System.Drawing.Point(18, 65);
            this.radar_edit_button.Name = "radar_edit_button";
            this.radar_edit_button.Size = new System.Drawing.Size(75, 31);
            this.radar_edit_button.TabIndex = 12;
            this.radar_edit_button.Text = "编辑雷达";
            this.radar_edit_button.UseVisualStyleBackColor = true;
            this.radar_edit_button.Click += new System.EventHandler(this.radar_edit_button_Click);
            // 
            // radar_delete_button
            // 
            this.radar_delete_button.Location = new System.Drawing.Point(101, 65);
            this.radar_delete_button.Name = "radar_delete_button";
            this.radar_delete_button.Size = new System.Drawing.Size(75, 31);
            this.radar_delete_button.TabIndex = 13;
            this.radar_delete_button.Text = "删除雷达";
            this.radar_delete_button.UseVisualStyleBackColor = true;
            this.radar_delete_button.Click += new System.EventHandler(this.radar_delete_button_Click);
            // 
            // radar_stop_button
            // 
            this.radar_stop_button.Location = new System.Drawing.Point(185, 65);
            this.radar_stop_button.Name = "radar_stop_button";
            this.radar_stop_button.Size = new System.Drawing.Size(75, 31);
            this.radar_stop_button.TabIndex = 14;
            this.radar_stop_button.Text = "关闭雷达";
            this.radar_stop_button.UseVisualStyleBackColor = true;
            this.radar_stop_button.Click += new System.EventHandler(this.radar_stop_button_Click);
            // 
            // radar_start_button
            // 
            this.radar_start_button.Location = new System.Drawing.Point(185, 65);
            this.radar_start_button.Name = "radar_start_button";
            this.radar_start_button.Size = new System.Drawing.Size(75, 31);
            this.radar_start_button.TabIndex = 15;
            this.radar_start_button.Text = "开启雷达";
            this.radar_start_button.UseVisualStyleBackColor = true;
            this.radar_start_button.Click += new System.EventHandler(this.radar_start_button_Click);
            // 
            // RadarShowBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 108);
            this.Controls.Add(this.radar_start_button);
            this.Controls.Add(this.radar_stop_button);
            this.Controls.Add(this.radar_delete_button);
            this.Controls.Add(this.radar_edit_button);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_lat);
            this.Controls.Add(this.label_radius);
            this.Controls.Add(this.label_lon);
            this.Location = new System.Drawing.Point(-1000, 0);
            this.Name = "RadarShowBox";
            this.Text = "雷达:雷达名称";
            this.Load += new System.EventHandler(this.RadarShowBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_lat;
        private System.Windows.Forms.Label label_radius;
        private System.Windows.Forms.Label label_lon;
        private System.Windows.Forms.Button radar_edit_button;
        private System.Windows.Forms.Button radar_delete_button;
        private System.Windows.Forms.Button radar_stop_button;
        private System.Windows.Forms.Button radar_start_button;
    }
}