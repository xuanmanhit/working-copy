namespace PhanMem
{
    partial class qlCongMayInN2
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
            this.gvCongN2 = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.gbtEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbtDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gtxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gtSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtInHu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtThoInHu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtInPhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtThoInPhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtInVayMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtThoInVayMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtInLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtThoInLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtGhichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongN2)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCongN2
            // 
            this.gvCongN2.AllowUserToAddRows = false;
            this.gvCongN2.AllowUserToDeleteRows = false;
            this.gvCongN2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvCongN2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCongN2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gbtEdit,
            this.gbtDel,
            this.gtxtID,
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
            this.gtxtCongNhat,
            this.gtSoluong,
            this.gtInHu,
            this.gtThoInHu,
            this.gtInPhe,
            this.gtThoInPhe,
            this.gtInVayMuc,
            this.gtThoInVayMuc,
            this.gtInLoi,
            this.gtThoInLoi,
            this.gtGhichu});
            this.gvCongN2.Location = new System.Drawing.Point(12, 58);
            this.gvCongN2.Name = "gvCongN2";
            this.gvCongN2.ReadOnly = true;
            this.gvCongN2.Size = new System.Drawing.Size(760, 392);
            this.gvCongN2.TabIndex = 15;
            this.gvCongN2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCongN2_CellClick);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(606, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 36);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Danh sách Công Nhóm 2";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(692, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 36);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "Trở lại";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // gbtEdit
            // 
            this.gbtEdit.HeaderText = "";
            this.gbtEdit.Name = "gbtEdit";
            this.gbtEdit.ReadOnly = true;
            this.gbtEdit.Text = "Sửa";
            this.gbtEdit.UseColumnTextForButtonValue = true;
            this.gbtEdit.Width = 50;
            // 
            // gbtDel
            // 
            this.gbtDel.HeaderText = "";
            this.gbtDel.Name = "gbtDel";
            this.gbtDel.ReadOnly = true;
            this.gbtDel.Text = "Xóa";
            this.gbtDel.UseColumnTextForButtonValue = true;
            this.gbtDel.Width = 50;
            // 
            // gtxtID
            // 
            this.gtxtID.DataPropertyName = "ID";
            this.gtxtID.HeaderText = "ID";
            this.gtxtID.Name = "gtxtID";
            this.gtxtID.ReadOnly = true;
            this.gtxtID.Visible = false;
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
            this.gtxtCongNhan.DataPropertyName = "MayIn";
            this.gtxtCongNhan.HeaderText = "Máy In";
            this.gtxtCongNhan.Name = "gtxtCongNhan";
            this.gtxtCongNhan.ReadOnly = true;
            // 
            // gtxtKhoVai
            // 
            this.gtxtKhoVai.DataPropertyName = "ThoChinh";
            this.gtxtKhoVai.HeaderText = "Thợ chính";
            this.gtxtKhoVai.Name = "gtxtKhoVai";
            this.gtxtKhoVai.ReadOnly = true;
            // 
            // gtxtKgCat
            // 
            this.gtxtKgCat.DataPropertyName = "ThoPhu";
            this.gtxtKgCat.HeaderText = "Thợ phụ";
            this.gtxtKgCat.Name = "gtxtKgCat";
            this.gtxtKgCat.ReadOnly = true;
            // 
            // gtxtPheTH
            // 
            this.gtxtPheTH.DataPropertyName = "GioNhanIn";
            this.gtxtPheTH.HeaderText = "Giờ nhận In";
            this.gtxtPheTH.Name = "gtxtPheTH";
            this.gtxtPheTH.ReadOnly = true;
            this.gtxtPheTH.Width = 130;
            // 
            // gtxtPheSuot
            // 
            this.gtxtPheSuot.DataPropertyName = "GioBatDauIn";
            this.gtxtPheSuot.HeaderText = "Giờ In";
            this.gtxtPheSuot.Name = "gtxtPheSuot";
            this.gtxtPheSuot.ReadOnly = true;
            // 
            // gtxtPheDC
            // 
            this.gtxtPheDC.DataPropertyName = "GioInXong";
            this.gtxtPheDC.HeaderText = "Giờ in xong";
            this.gtxtPheDC.Name = "gtxtPheDC";
            this.gtxtPheDC.ReadOnly = true;
            this.gtxtPheDC.Width = 130;
            // 
            // gtxtSoluongSP
            // 
            this.gtxtSoluongSP.DataPropertyName = "KhoVai";
            this.gtxtSoluongSP.HeaderText = "Khổ vải";
            this.gtxtSoluongSP.Name = "gtxtSoluongSP";
            this.gtxtSoluongSP.ReadOnly = true;
            // 
            // gtxtLuongSP
            // 
            this.gtxtLuongSP.DataPropertyName = "TenCongViec";
            this.gtxtLuongSP.HeaderText = "Công việc";
            this.gtxtLuongSP.Name = "gtxtLuongSP";
            this.gtxtLuongSP.ReadOnly = true;
            // 
            // gtxtCongNhat
            // 
            this.gtxtCongNhat.DataPropertyName = "ThoCat";
            this.gtxtCongNhat.HeaderText = "Thợ cắt";
            this.gtxtCongNhat.Name = "gtxtCongNhat";
            this.gtxtCongNhat.ReadOnly = true;
            // 
            // gtSoluong
            // 
            this.gtSoluong.DataPropertyName = "SoLuong";
            this.gtSoluong.HeaderText = "Số lượng";
            this.gtSoluong.Name = "gtSoluong";
            this.gtSoluong.ReadOnly = true;
            // 
            // gtInHu
            // 
            this.gtInHu.DataPropertyName = "InHu";
            this.gtInHu.HeaderText = "In Hư";
            this.gtInHu.Name = "gtInHu";
            this.gtInHu.ReadOnly = true;
            // 
            // gtThoInHu
            // 
            this.gtThoInHu.DataPropertyName = "ThoInHu";
            this.gtThoInHu.HeaderText = "Thợ in hư";
            this.gtThoInHu.Name = "gtThoInHu";
            this.gtThoInHu.ReadOnly = true;
            // 
            // gtInPhe
            // 
            this.gtInPhe.DataPropertyName = "InPhe";
            this.gtInPhe.HeaderText = "In Phế";
            this.gtInPhe.Name = "gtInPhe";
            this.gtInPhe.ReadOnly = true;
            // 
            // gtThoInPhe
            // 
            this.gtThoInPhe.DataPropertyName = "ThoInPhe";
            this.gtThoInPhe.HeaderText = "Thợ in phế";
            this.gtThoInPhe.Name = "gtThoInPhe";
            this.gtThoInPhe.ReadOnly = true;
            // 
            // gtInVayMuc
            // 
            this.gtInVayMuc.DataPropertyName = "InVayMuc";
            this.gtInVayMuc.HeaderText = "In Vấy Mực";
            this.gtInVayMuc.Name = "gtInVayMuc";
            this.gtInVayMuc.ReadOnly = true;
            this.gtInVayMuc.Width = 110;
            // 
            // gtThoInVayMuc
            // 
            this.gtThoInVayMuc.DataPropertyName = "ThoInVayMuc";
            this.gtThoInVayMuc.HeaderText = "Thợ in vấy mực";
            this.gtThoInVayMuc.Name = "gtThoInVayMuc";
            this.gtThoInVayMuc.ReadOnly = true;
            this.gtThoInVayMuc.Width = 125;
            // 
            // gtInLoi
            // 
            this.gtInLoi.DataPropertyName = "InLoi";
            this.gtInLoi.HeaderText = "In Lỗi";
            this.gtInLoi.Name = "gtInLoi";
            this.gtInLoi.ReadOnly = true;
            // 
            // gtThoInLoi
            // 
            this.gtThoInLoi.DataPropertyName = "ThoInLoi";
            this.gtThoInLoi.HeaderText = "Thợ in lỗi";
            this.gtThoInLoi.Name = "gtThoInLoi";
            this.gtThoInLoi.ReadOnly = true;
            // 
            // gtGhichu
            // 
            this.gtGhichu.DataPropertyName = "GhiChu";
            this.gtGhichu.HeaderText = "Ghi chú";
            this.gtGhichu.Name = "gtGhichu";
            this.gtGhichu.ReadOnly = true;
            // 
            // qlCongMayInN2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.gvCongN2);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "qlCongMayInN2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Công Nhóm 2";
            this.Load += new System.EventHandler(this.qlCongMayInN2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCongN2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvCongN2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridViewButtonColumn gbtEdit;
        private System.Windows.Forms.DataGridViewButtonColumn gbtDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtID;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn gtSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtInHu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtThoInHu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtInPhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtThoInPhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtInVayMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtThoInVayMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtInLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtThoInLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtGhichu;
    }
}