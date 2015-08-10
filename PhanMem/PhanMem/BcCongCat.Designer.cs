namespace PhanMem
{
    partial class BcCongCat
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
            this.gvBaoCaoNgay = new System.Windows.Forms.DataGridView();
            this.txtSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtCongNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKhoVai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKgCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheSuot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtSoluongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtCongNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBack = new System.Windows.Forms.Button();
            this.btXem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            this.dtpNgayCong = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCaoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBaoCaoNgay
            // 
            this.gvBaoCaoNgay.AllowUserToAddRows = false;
            this.gvBaoCaoNgay.AllowUserToDeleteRows = false;
            this.gvBaoCaoNgay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvBaoCaoNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBaoCaoNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtSTT,
            this.gtxtNgayCong,
            this.gtxtCongNhan,
            this.gtxtKhoVai,
            this.gtxtKgCat,
            this.gtxtPheTH,
            this.gtxtPheSuot,
            this.gtxtPheDC,
            this.gtxtSoluongSP,
            this.gtxtLuongSP,
            this.gtxtCongNhat});
            this.gvBaoCaoNgay.Location = new System.Drawing.Point(12, 58);
            this.gvBaoCaoNgay.Name = "gvBaoCaoNgay";
            this.gvBaoCaoNgay.ReadOnly = true;
            this.gvBaoCaoNgay.Size = new System.Drawing.Size(760, 392);
            this.gvBaoCaoNgay.TabIndex = 13;
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
            // gtxtCongNhan
            // 
            this.gtxtCongNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gtxtCongNhan.DataPropertyName = "HoTen";
            this.gtxtCongNhan.HeaderText = "Công Nhân";
            this.gtxtCongNhan.Name = "gtxtCongNhan";
            this.gtxtCongNhan.ReadOnly = true;
            this.gtxtCongNhan.Width = 150;
            // 
            // gtxtKhoVai
            // 
            this.gtxtKhoVai.DataPropertyName = "CongViec";
            this.gtxtKhoVai.HeaderText = "Công Việc";
            this.gtxtKhoVai.Name = "gtxtKhoVai";
            this.gtxtKhoVai.ReadOnly = true;
            this.gtxtKhoVai.Width = 130;
            // 
            // gtxtKgCat
            // 
            this.gtxtKgCat.DataPropertyName = "TongKgCat";
            this.gtxtKgCat.HeaderText = "Tổng Kg Cắt";
            this.gtxtKgCat.Name = "gtxtKgCat";
            this.gtxtKgCat.ReadOnly = true;
            this.gtxtKgCat.Width = 140;
            // 
            // gtxtPheTH
            // 
            this.gtxtPheTH.DataPropertyName = "TongOng";
            this.gtxtPheTH.HeaderText = "Số Ống";
            this.gtxtPheTH.Name = "gtxtPheTH";
            this.gtxtPheTH.ReadOnly = true;
            this.gtxtPheTH.Width = 80;
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
            this.gtxtLuongSP.Width = 121;
            // 
            // gtxtCongNhat
            // 
            this.gtxtCongNhat.DataPropertyName = "TienCongPhu";
            this.gtxtCongNhat.HeaderText = "Tiền Công Phụ";
            this.gtxtCongNhat.Name = "gtxtCongNhat";
            this.gtxtCongNhat.ReadOnly = true;
            this.gtxtCongNhat.Width = 120;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(692, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 40);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "Trở lại";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(270, 12);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(80, 40);
            this.btXem.TabIndex = 15;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày Công";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(356, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(100, 40);
            this.btExport.TabIndex = 16;
            this.btExport.Text = "Xuất Excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // dtpNgayCong
            // 
            this.dtpNgayCong.CustomFormat = "";
            this.dtpNgayCong.Location = new System.Drawing.Point(93, 18);
            this.dtpNgayCong.Name = "dtpNgayCong";
            this.dtpNgayCong.Size = new System.Drawing.Size(171, 24);
            this.dtpNgayCong.TabIndex = 17;
            // 
            // BcCongCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.dtpNgayCong);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gvBaoCaoNgay);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BcCongCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Công Cắt";
            this.Load += new System.EventHandler(this.BcCongCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCaoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBaoCaoNgay;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.DateTimePicker dtpNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtCongNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKhoVai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKgCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheSuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtSoluongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtCongNhat;
    }
}