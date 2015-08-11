namespace PhanMem
{
    partial class BcLuongCat
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
            this.gvLuong = new System.Windows.Forms.DataGridView();
            this.btBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btExport = new System.Windows.Forms.Button();
            this.btXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbtChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtCongNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtTongPhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKgCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheSuot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtSoluongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtCongNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLuong
            // 
            this.gvLuong.AllowUserToAddRows = false;
            this.gvLuong.AllowUserToDeleteRows = false;
            this.gvLuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gbtChiTiet,
            this.txtSTT,
            this.gtxtCongNhan,
            this.gtxtPheTH,
            this.gtxtTongPhe,
            this.gtxtKgCat,
            this.gtxtPheSuot,
            this.gtxtPheDC,
            this.gtxtSoluongSP,
            this.gtxtLuongSP,
            this.gtxtCongNhat,
            this.gtxtTongTien});
            this.gvLuong.Location = new System.Drawing.Point(12, 58);
            this.gvLuong.Name = "gvLuong";
            this.gvLuong.ReadOnly = true;
            this.gvLuong.Size = new System.Drawing.Size(760, 392);
            this.gvLuong.TabIndex = 15;
            this.gvLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLuong_CellClick);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Danh sách Lương từ";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "";
            this.dtpTuNgay.Location = new System.Drawing.Point(148, 18);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(103, 24);
            this.dtpTuNgay.TabIndex = 18;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "";
            this.dtpDenNgay.Location = new System.Drawing.Point(293, 18);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(103, 24);
            this.dtpDenNgay.TabIndex = 19;
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(488, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(81, 36);
            this.btExport.TabIndex = 21;
            this.btExport.Text = "Xuất Excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(402, 12);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(80, 36);
            this.btXem.TabIndex = 20;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "đến";
            // 
            // gbtChiTiet
            // 
            this.gbtChiTiet.HeaderText = "";
            this.gbtChiTiet.Name = "gbtChiTiet";
            this.gbtChiTiet.ReadOnly = true;
            this.gbtChiTiet.Text = "Chi tiết";
            this.gbtChiTiet.UseColumnTextForButtonValue = true;
            this.gbtChiTiet.Width = 60;
            // 
            // txtSTT
            // 
            this.txtSTT.DataPropertyName = "STT";
            this.txtSTT.HeaderText = "STT";
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.ReadOnly = true;
            this.txtSTT.Width = 50;
            // 
            // gtxtCongNhan
            // 
            this.gtxtCongNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gtxtCongNhan.DataPropertyName = "HoTen";
            this.gtxtCongNhan.HeaderText = "Công Nhân";
            this.gtxtCongNhan.Name = "gtxtCongNhan";
            this.gtxtCongNhan.ReadOnly = true;
            this.gtxtCongNhan.Width = 150;
            // 
            // gtxtPheTH
            // 
            this.gtxtPheTH.DataPropertyName = "TongOng";
            this.gtxtPheTH.HeaderText = "Số Ống";
            this.gtxtPheTH.Name = "gtxtPheTH";
            this.gtxtPheTH.ReadOnly = true;
            this.gtxtPheTH.Width = 80;
            // 
            // gtxtTongPhe
            // 
            this.gtxtTongPhe.DataPropertyName = "TongPhe";
            this.gtxtTongPhe.HeaderText = "Tổng Phế";
            this.gtxtTongPhe.Name = "gtxtTongPhe";
            this.gtxtTongPhe.ReadOnly = true;
            // 
            // gtxtKgCat
            // 
            this.gtxtKgCat.DataPropertyName = "TongKgCat";
            this.gtxtKgCat.HeaderText = "Tổng Kg Cắt";
            this.gtxtKgCat.Name = "gtxtKgCat";
            this.gtxtKgCat.ReadOnly = true;
            this.gtxtKgCat.Width = 140;
            // 
            // gtxtPheSuot
            // 
            this.gtxtPheSuot.DataPropertyName = "TongSpTruPhe";
            this.gtxtPheSuot.HeaderText = "Tổng Kg trừ phế";
            this.gtxtPheSuot.Name = "gtxtPheSuot";
            this.gtxtPheSuot.ReadOnly = true;
            this.gtxtPheSuot.Width = 160;
            // 
            // gtxtPheDC
            // 
            this.gtxtPheDC.DataPropertyName = "TongSoLuongSP";
            this.gtxtPheDC.HeaderText = "Tổng SP";
            this.gtxtPheDC.Name = "gtxtPheDC";
            this.gtxtPheDC.ReadOnly = true;
            // 
            // gtxtSoluongSP
            // 
            this.gtxtSoluongSP.DataPropertyName = "TongTien";
            this.gtxtSoluongSP.HeaderText = "Thành tiền";
            this.gtxtSoluongSP.Name = "gtxtSoluongSP";
            this.gtxtSoluongSP.ReadOnly = true;
            // 
            // gtxtLuongSP
            // 
            this.gtxtLuongSP.DataPropertyName = "TienCong";
            this.gtxtLuongSP.HeaderText = "Tiền Công Nhật";
            this.gtxtLuongSP.Name = "gtxtLuongSP";
            this.gtxtLuongSP.ReadOnly = true;
            this.gtxtLuongSP.Width = 124;
            // 
            // gtxtCongNhat
            // 
            this.gtxtCongNhat.DataPropertyName = "TienCongPhu";
            this.gtxtCongNhat.HeaderText = "Tiền Công Phụ";
            this.gtxtCongNhat.Name = "gtxtCongNhat";
            this.gtxtCongNhat.ReadOnly = true;
            this.gtxtCongNhat.Width = 120;
            // 
            // gtxtTongTien
            // 
            this.gtxtTongTien.DataPropertyName = "TongTien";
            this.gtxtTongTien.HeaderText = "Tổng Tiền";
            this.gtxtTongTien.Name = "gtxtTongTien";
            this.gtxtTongTien.ReadOnly = true;
            // 
            // BcLuongCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gvLuong);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "BcLuongCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng hợp Lương";
            this.Load += new System.EventHandler(this.BcLuongCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLuong;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn gbtChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtCongNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtTongPhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKgCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheSuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtSoluongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtCongNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtTongTien;
    }
}