namespace PhanMem
{
    partial class qlCongIn
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
            this.gtxtLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtSoluongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKgCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtInHu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtInPhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtInVayMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gtxtLuongSP,
            this.gtSoluong,
            this.gtxtSoluongSP,
            this.gtxtKgCat,
            this.Column1,
            this.Column2,
            this.Column3,
            this.gtInHu,
            this.gtInPhe,
            this.gtInVayMuc});
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
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Danh sách Công In";
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
            // gtxtLuongSP
            // 
            this.gtxtLuongSP.DataPropertyName = "TenCongViec";
            this.gtxtLuongSP.HeaderText = "Công việc";
            this.gtxtLuongSP.Name = "gtxtLuongSP";
            this.gtxtLuongSP.ReadOnly = true;
            // 
            // gtSoluong
            // 
            this.gtSoluong.DataPropertyName = "SanPham";
            this.gtSoluong.HeaderText = "Sản phẩm";
            this.gtSoluong.Name = "gtSoluong";
            this.gtSoluong.ReadOnly = true;
            // 
            // gtxtSoluongSP
            // 
            this.gtxtSoluongSP.DataPropertyName = "KhoVai";
            this.gtxtSoluongSP.HeaderText = "Khổ vải";
            this.gtxtSoluongSP.Name = "gtxtSoluongSP";
            this.gtxtSoluongSP.ReadOnly = true;
            // 
            // gtxtKgCat
            // 
            this.gtxtKgCat.DataPropertyName = "Tho1";
            this.gtxtKgCat.HeaderText = "Thợ 1-Giờ-Giá";
            this.gtxtKgCat.Name = "gtxtKgCat";
            this.gtxtKgCat.ReadOnly = true;
            this.gtxtKgCat.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tho2";
            this.Column1.HeaderText = "Thợ 2-Giờ-Giá";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tho3";
            this.Column2.HeaderText = "Thợ 3-Giờ-Giá";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tho4";
            this.Column3.HeaderText = "Thợ 4-Giờ-Giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // gtInHu
            // 
            this.gtInHu.DataPropertyName = "InHu";
            this.gtInHu.HeaderText = "In Hư";
            this.gtInHu.Name = "gtInHu";
            this.gtInHu.ReadOnly = true;
            this.gtInHu.Width = 120;
            // 
            // gtInPhe
            // 
            this.gtInPhe.DataPropertyName = "InPhe";
            this.gtInPhe.HeaderText = "In Phế";
            this.gtInPhe.Name = "gtInPhe";
            this.gtInPhe.ReadOnly = true;
            this.gtInPhe.Width = 120;
            // 
            // gtInVayMuc
            // 
            this.gtInVayMuc.DataPropertyName = "InVayMuc";
            this.gtInVayMuc.HeaderText = "In Vấy Mực";
            this.gtInVayMuc.Name = "gtInVayMuc";
            this.gtInVayMuc.ReadOnly = true;
            this.gtInVayMuc.Width = 120;
            // 
            // qlCongIn
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
            this.Name = "qlCongIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Công In";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtSoluongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKgCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtInHu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtInPhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtInVayMuc;
    }
}