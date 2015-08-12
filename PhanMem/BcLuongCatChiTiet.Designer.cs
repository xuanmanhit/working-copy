namespace PhanMem
{
    partial class BcLuongCatChiTiet
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
            this.btBack = new System.Windows.Forms.Button();
            this.gvLuongChiTiet = new System.Windows.Forms.DataGridView();
            this.txtSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKhoVai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKgCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtTongPhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheSuot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtSoluongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtCongNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuongChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Chi tiết lương công nhân";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(642, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 36);
            this.btBack.TabIndex = 17;
            this.btBack.Text = "Trở lại";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // gvLuongChiTiet
            // 
            this.gvLuongChiTiet.AllowUserToAddRows = false;
            this.gvLuongChiTiet.AllowUserToDeleteRows = false;
            this.gvLuongChiTiet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvLuongChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLuongChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtSTT,
            this.gtxtNgayCong,
            this.gtxtKhoVai,
            this.gtxtPheTH,
            this.gtxtKgCat,
            this.gtxtTongPhe,
            this.gtxtPheSuot,
            this.gtxtPheDC,
            this.gtxtDonGia,
            this.gtxtSoluongSP,
            this.gtxtLuongSP,
            this.gtxtCongNhat});
            this.gvLuongChiTiet.Location = new System.Drawing.Point(12, 58);
            this.gvLuongChiTiet.Name = "gvLuongChiTiet";
            this.gvLuongChiTiet.ReadOnly = true;
            this.gvLuongChiTiet.Size = new System.Drawing.Size(710, 342);
            this.gvLuongChiTiet.TabIndex = 20;
            // 
            // txtSTT
            // 
            this.txtSTT.DataPropertyName = "STT";
            this.txtSTT.HeaderText = "STT";
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.ReadOnly = true;
            this.txtSTT.Width = 50;
            // 
            // gtxtNgayCong
            // 
            this.gtxtNgayCong.DataPropertyName = "NgayCong";
            this.gtxtNgayCong.HeaderText = "Ngày Công";
            this.gtxtNgayCong.Name = "gtxtNgayCong";
            this.gtxtNgayCong.ReadOnly = true;
            this.gtxtNgayCong.Width = 120;
            // 
            // gtxtKhoVai
            // 
            this.gtxtKhoVai.DataPropertyName = "CongViec";
            this.gtxtKhoVai.HeaderText = "Công Việc";
            this.gtxtKhoVai.Name = "gtxtKhoVai";
            this.gtxtKhoVai.ReadOnly = true;
            this.gtxtKhoVai.Width = 130;
            // 
            // gtxtPheTH
            // 
            this.gtxtPheTH.DataPropertyName = "TongOng";
            this.gtxtPheTH.HeaderText = "Số Ống";
            this.gtxtPheTH.Name = "gtxtPheTH";
            this.gtxtPheTH.ReadOnly = true;
            this.gtxtPheTH.Width = 80;
            // 
            // gtxtKgCat
            // 
            this.gtxtKgCat.DataPropertyName = "TongKgCat";
            this.gtxtKgCat.HeaderText = "Tổng Kg Cắt";
            this.gtxtKgCat.Name = "gtxtKgCat";
            this.gtxtKgCat.ReadOnly = true;
            this.gtxtKgCat.Width = 140;
            // 
            // gtxtTongPhe
            // 
            this.gtxtTongPhe.DataPropertyName = "TongPhe";
            this.gtxtTongPhe.HeaderText = "Tổng Phế";
            this.gtxtTongPhe.Name = "gtxtTongPhe";
            this.gtxtTongPhe.ReadOnly = true;
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
            // gtxtDonGia
            // 
            this.gtxtDonGia.DataPropertyName = "DonGia";
            this.gtxtDonGia.HeaderText = "Đơn Giá";
            this.gtxtDonGia.Name = "gtxtDonGia";
            this.gtxtDonGia.ReadOnly = true;
            // 
            // gtxtSoluongSP
            // 
            this.gtxtSoluongSP.DataPropertyName = "TienSP";
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
            // BcLuongCatChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.ControlBox = false;
            this.Controls.Add(this.gvLuongChiTiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BcLuongCatChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết lương";
            this.Load += new System.EventHandler(this.BcLuongCatChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLuongChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridView gvLuongChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKhoVai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKgCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtTongPhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheSuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtSoluongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtCongNhat;
    }
}