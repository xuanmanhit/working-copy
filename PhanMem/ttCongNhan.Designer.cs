﻿namespace PhanMem
{
    partial class ttCongNhan
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
            this.cbLoaiHinh = new System.Windows.Forms.ComboBox();
            this.cbCongViec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbLoaiHinh
            // 
            this.cbLoaiHinh.FormattingEnabled = true;
            this.cbLoaiHinh.Location = new System.Drawing.Point(119, 89);
            this.cbLoaiHinh.Name = "cbLoaiHinh";
            this.cbLoaiHinh.Size = new System.Drawing.Size(210, 25);
            this.cbLoaiHinh.TabIndex = 2;
            // 
            // cbCongViec
            // 
            this.cbCongViec.FormattingEnabled = true;
            this.cbCongViec.Location = new System.Drawing.Point(119, 54);
            this.cbCongViec.Name = "cbCongViec";
            this.cbCongViec.Size = new System.Drawing.Size(210, 25);
            this.cbCongViec.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loại hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Công việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(119, 20);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(210, 24);
            this.txtHoTen.TabIndex = 0;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(90, 128);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 36);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(199, 128);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(80, 36);
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // ttCongNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 176);
            this.ControlBox = false;
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.cbLoaiHinh);
            this.Controls.Add(this.cbCongViec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ttCongNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Công Nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoaiHinh;
        private System.Windows.Forms.ComboBox cbCongViec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btHuy;
    }
}