﻿namespace PhanMem
{
    partial class qlViecMayIn
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
            this.label4 = new System.Windows.Forms.Label();
            this.gvViecMayIn = new System.Windows.Forms.DataGridView();
            this.btBack = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvViecMayIn)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Danh sách Công việc May - In";
            // 
            // gvViecMayIn
            // 
            this.gvViecMayIn.AllowUserToAddRows = false;
            this.gvViecMayIn.AllowUserToDeleteRows = false;
            this.gvViecMayIn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvViecMayIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvViecMayIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSua,
            this.btnDelete,
            this.txtID,
            this.txtSTT,
            this.tbcHoTen,
            this.gtxtDonGia});
            this.gvViecMayIn.Location = new System.Drawing.Point(12, 58);
            this.gvViecMayIn.Name = "gvViecMayIn";
            this.gvViecMayIn.ReadOnly = true;
            this.gvViecMayIn.Size = new System.Drawing.Size(760, 392);
            this.gvViecMayIn.TabIndex = 15;
            this.gvViecMayIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvViecMayIn_CellClick);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(692, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 36);
            this.btBack.TabIndex = 14;
            this.btBack.Text = "Trở lại";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(606, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 36);
            this.btThem.TabIndex = 13;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.HeaderText = "";
            this.btnSua.Name = "btnSua";
            this.btnSua.ReadOnly = true;
            this.btnSua.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseColumnTextForButtonValue = true;
            this.btnSua.Width = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 50;
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "ID";
            this.txtID.HeaderText = "ID";
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtID.Visible = false;
            // 
            // txtSTT
            // 
            this.txtSTT.DataPropertyName = "STT";
            this.txtSTT.HeaderText = "STT";
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.ReadOnly = true;
            this.txtSTT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtSTT.Width = 70;
            // 
            // tbcHoTen
            // 
            this.tbcHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcHoTen.DataPropertyName = "TenCongViec";
            this.tbcHoTen.HeaderText = "Tên Công Việc";
            this.tbcHoTen.Name = "tbcHoTen";
            this.tbcHoTen.ReadOnly = true;
            this.tbcHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gtxtDonGia
            // 
            this.gtxtDonGia.DataPropertyName = "DonGia";
            this.gtxtDonGia.HeaderText = "Đơn giá";
            this.gtxtDonGia.Name = "gtxtDonGia";
            this.gtxtDonGia.ReadOnly = true;
            this.gtxtDonGia.Width = 170;
            // 
            // qlViecMayIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gvViecMayIn);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "qlViecMayIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Công việc May - In";
            this.Load += new System.EventHandler(this.qlViecMayIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvViecMayIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvViecMayIn;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtDonGia;
    }
}