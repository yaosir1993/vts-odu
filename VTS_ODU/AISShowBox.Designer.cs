﻿namespace vts_odu
{
    partial class AISShowSmallBox
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
            this.ais_start_button = new System.Windows.Forms.Button();
            this.ais_stop_button = new System.Windows.Forms.Button();
            this.ais_delete_button = new System.Windows.Forms.Button();
            this.ais_edit_button = new System.Windows.Forms.Button();
            this.label_lat = new System.Windows.Forms.Label();
            this.label_radius = new System.Windows.Forms.Label();
            this.label_lon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ais_start_button
            // 
            this.ais_start_button.Location = new System.Drawing.Point(185, 65);
            this.ais_start_button.Name = "ais_start_button";
            this.ais_start_button.Size = new System.Drawing.Size(75, 31);
            this.ais_start_button.TabIndex = 23;
            this.ais_start_button.Text = "开启雷达";
            this.ais_start_button.UseVisualStyleBackColor = true;
            this.ais_start_button.Click += new System.EventHandler(this.ais_start_button_Click);
            // 
            // ais_stop_button
            // 
            this.ais_stop_button.Location = new System.Drawing.Point(185, 65);
            this.ais_stop_button.Name = "ais_stop_button";
            this.ais_stop_button.Size = new System.Drawing.Size(75, 31);
            this.ais_stop_button.TabIndex = 22;
            this.ais_stop_button.Text = "关闭雷达";
            this.ais_stop_button.UseVisualStyleBackColor = true;
            this.ais_stop_button.Click += new System.EventHandler(this.ais_stop_button_Click);
            // 
            // ais_delete_button
            // 
            this.ais_delete_button.Location = new System.Drawing.Point(101, 65);
            this.ais_delete_button.Name = "ais_delete_button";
            this.ais_delete_button.Size = new System.Drawing.Size(75, 31);
            this.ais_delete_button.TabIndex = 21;
            this.ais_delete_button.Text = "删除雷达";
            this.ais_delete_button.UseVisualStyleBackColor = true;
            this.ais_delete_button.Click += new System.EventHandler(this.ais_delete_button_Click);
            // 
            // ais_edit_button
            // 
            this.ais_edit_button.Location = new System.Drawing.Point(18, 65);
            this.ais_edit_button.Name = "ais_edit_button";
            this.ais_edit_button.Size = new System.Drawing.Size(75, 31);
            this.ais_edit_button.TabIndex = 20;
            this.ais_edit_button.Text = "编辑雷达";
            this.ais_edit_button.UseVisualStyleBackColor = true;
            this.ais_edit_button.Click += new System.EventHandler(this.ais_edit_button_Click);
            // 
            // label_lat
            // 
            this.label_lat.AutoSize = true;
            this.label_lat.Location = new System.Drawing.Point(18, 39);
            this.label_lat.Name = "label_lat";
            this.label_lat.Size = new System.Drawing.Size(113, 12);
            this.label_lat.TabIndex = 18;
            this.label_lat.Text = "经度:12度32.234分S";
            // 
            // label_radius
            // 
            this.label_radius.AutoSize = true;
            this.label_radius.Location = new System.Drawing.Point(183, 15);
            this.label_radius.Name = "label_radius";
            this.label_radius.Size = new System.Drawing.Size(89, 12);
            this.label_radius.TabIndex = 17;
            this.label_radius.Text = "航向:120.3(度)";
            // 
            // label_lon
            // 
            this.label_lon.AutoSize = true;
            this.label_lon.Location = new System.Drawing.Point(18, 15);
            this.label_lon.Name = "label_lon";
            this.label_lon.Size = new System.Drawing.Size(119, 12);
            this.label_lon.TabIndex = 16;
            this.label_lon.Text = "经度:121度32.234分W";
            // 
            // AISShowSmallBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 108);
            this.Controls.Add(this.ais_start_button);
            this.Controls.Add(this.ais_stop_button);
            this.Controls.Add(this.ais_delete_button);
            this.Controls.Add(this.ais_edit_button);
            this.Controls.Add(this.label_lat);
            this.Controls.Add(this.label_radius);
            this.Controls.Add(this.label_lon);
            this.Name = "AISShowSmallBox";
            this.Text = "AIS:AIS基站";
            this.Load += new System.EventHandler(this.AISShowBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ais_start_button;
        private System.Windows.Forms.Button ais_stop_button;
        private System.Windows.Forms.Button ais_delete_button;
        private System.Windows.Forms.Button ais_edit_button;
        private System.Windows.Forms.Label label_lat;
        private System.Windows.Forms.Label label_radius;
        private System.Windows.Forms.Label label_lon;
    }
}