namespace PhanMem
{
    partial class qlCongMayInN3
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
            this.gtxtCongNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtSoluongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheSuot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKgCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKhoVai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtCongNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbtDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbtEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gvCongN3 = new System.Windows.Forms.DataGridView();
            this.gtxtLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongN3)).BeginInit();
            this.SuspendLayout();
            // 
            // gtxtCongNhat
            // 
            this.gtxtCongNhat.DataPropertyName = "PhutCongNhat";
            this.gtxtCongNhat.HeaderText = "Phút CN";
            this.gtxtCongNhat.Name = "gtxtCongNhat";
            this.gtxtCongNhat.ReadOnly = true;
            // 
            // gtxtSoluongSP
            // 
            this.gtxtSoluongSP.DataPropertyName = "SoLuongSP";
            this.gtxtSoluongSP.HeaderText = "Số lượng SP";
            this.gtxtSoluongSP.Name = "gtxtSoluongSP";
            this.gtxtSoluongSP.ReadOnly = true;
            this.gtxtSoluongSP.Width = 110;
            // 
            // gtxtPheDC
            // 
            this.gtxtPheDC.DataPropertyName = "PheDC";
            this.gtxtPheDC.HeaderText = "Phế ĐC";
            this.gtxtPheDC.Name = "gtxtPheDC";
            this.gtxtPheDC.ReadOnly = true;
            this.gtxtPheDC.Width = 80;
            // 
            // gtxtPheSuot
            // 
            this.gtxtPheSuot.DataPropertyName = "PheSuot";
            this.gtxtPheSuot.HeaderText = "Phế Suốt";
            this.gtxtPheSuot.Name = "gtxtPheSuot";
            this.gtxtPheSuot.ReadOnly = true;
            this.gtxtPheSuot.Width = 90;
            // 
            // gtxtPheTH
            // 
            this.gtxtPheTH.DataPropertyName = "PheTH";
            this.gtxtPheTH.HeaderText = "Phế TH";
            this.gtxtPheTH.Name = "gtxtPheTH";
            this.gtxtPheTH.ReadOnly = true;
            this.gtxtPheTH.Width = 80;
            // 
            // gtxtKgCat
            // 
            this.gtxtKgCat.DataPropertyName = "SoKgCat";
            this.gtxtKgCat.HeaderText = "Số Kg Cắt";
            this.gtxtKgCat.Name = "gtxtKgCat";
            this.gtxtKgCat.ReadOnly = true;
            // 
            // gtxtKhoVai
            // 
            this.gtxtKhoVai.DataPropertyName = "KhoVai";
            this.gtxtKhoVai.HeaderText = "Khổ Vải";
            this.gtxtKhoVai.Name = "gtxtKhoVai";
            this.gtxtKhoVai.ReadOnly = true;
            this.gtxtKhoVai.Width = 130;
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
            // gtxtNgayCong
            // 
            this.gtxtNgayCong.DataPropertyName = "NgayCat";
            this.gtxtNgayCong.HeaderText = "Ngày Công";
            this.gtxtNgayCong.Name = "gtxtNgayCong";
            this.gtxtNgayCong.ReadOnly = true;
            this.gtxtNgayCong.Width = 120;
            // 
            // txtSTT
            // 
            this.txtSTT.DataPropertyName = "STT";
            this.txtSTT.HeaderText = "STT";
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.ReadOnly = true;
            this.txtSTT.Width = 50;
            // 
            // gtxtID
            // 
            this.gtxtID.DataPropertyName = "ID";
            this.gtxtID.HeaderText = "ID";
            this.gtxtID.Name = "gtxtID";
            this.gtxtID.ReadOnly = true;
            this.gtxtID.Visible = false;
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
            // gbtEdit
            // 
            this.gbtEdit.HeaderText = "";
            this.gbtEdit.Name = "gbtEdit";
            this.gbtEdit.ReadOnly = true;
            this.gbtEdit.Text = "Sửa";
            this.gbtEdit.UseColumnTextForButtonValue = true;
            this.gbtEdit.Width = 50;
            // 
            // gvCongN3
            // 
            this.gvCongN3.AllowUserToAddRows = false;
            this.gvCongN3.AllowUserToDeleteRows = false;
            this.gvCongN3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvCongN3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCongN3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.gtxtCongNhat});
            this.gvCongN3.Location = new System.Drawing.Point(12, 58);
            this.gvCongN3.Name = "gvCongN3";
            this.gvCongN3.ReadOnly = true;
            this.gvCongN3.Size = new System.Drawing.Size(760, 392);
            this.gvCongN3.TabIndex = 15;
            // 
            // gtxtLuongSP
            // 
            this.gtxtLuongSP.DataPropertyName = "PhutSP";
            this.gtxtLuongSP.HeaderText = "Phút SP";
            this.gtxtLuongSP.Name = "gtxtLuongSP";
            this.gtxtLuongSP.ReadOnly = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(606, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 36);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Danh sách Công Cắt";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(692, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 36);
            this.btBack.TabIndex = 12;
            this.btBack.Text = "Trở lại";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // qlCongMayInN3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.gvCongN3);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "qlCongMayInN3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Công Phụ";
            ((System.ComponentModel.ISupportInitialize)(this.gvCongN3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtCongNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtSoluongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheSuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKgCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKhoVai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtCongNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtID;
        private System.Windows.Forms.DataGridViewButtonColumn gbtDel;
        private System.Windows.Forms.DataGridViewButtonColumn gbtEdit;
        private System.Windows.Forms.DataGridView gvCongN3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtLuongSP;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBack;
    }
}