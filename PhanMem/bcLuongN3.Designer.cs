﻿namespace PhanMem
{
    partial class bcLuongN3
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
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.sfdXuatExcel = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "";
            this.dtpDenNgay.Location = new System.Drawing.Point(104, 48);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(167, 24);
            this.dtpDenNgay.TabIndex = 31;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "";
            this.dtpTuNgay.Location = new System.Drawing.Point(104, 13);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(167, 24);
            this.dtpTuNgay.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Từ ngày";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(157, 94);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(80, 36);
            this.btHuy.TabIndex = 27;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(48, 94);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(86, 36);
            this.btExport.TabIndex = 26;
            this.btExport.Text = "Xuất Excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // bcLuongN3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.ControlBox = false;
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btExport);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bcLuongN3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Lương Nhóm 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.SaveFileDialog sfdXuatExcel;
    }
}