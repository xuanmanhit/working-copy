namespace PhanMem
{
    partial class qlCongMayInN1
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
            this.gvCongN1 = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.gbtEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbtDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gtxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtCongNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKgCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtKhoVai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheSuot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtPheDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongN1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCongN1
            // 
            this.gvCongN1.AllowUserToAddRows = false;
            this.gvCongN1.AllowUserToDeleteRows = false;
            this.gvCongN1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvCongN1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCongN1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gbtEdit,
            this.gbtDel,
            this.gtxtID,
            this.txtSTT,
            this.gtxtNgayCong,
            this.gtxtCongNhan,
            this.gtxtKgCat,
            this.gtxtKhoVai,
            this.gtxtPheTH,
            this.gtxtPheSuot,
            this.gtxtPheDC});
            this.gvCongN1.Location = new System.Drawing.Point(12, 58);
            this.gvCongN1.Name = "gvCongN1";
            this.gvCongN1.ReadOnly = true;
            this.gvCongN1.Size = new System.Drawing.Size(760, 392);
            this.gvCongN1.TabIndex = 15;
            this.gvCongN1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCongN1_CellClick);
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
            this.label4.Text = "Danh sách Công Nhóm 1";
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
            this.gtxtCongNhan.DataPropertyName = "Tho";
            this.gtxtCongNhan.HeaderText = "Thợ";
            this.gtxtCongNhan.Name = "gtxtCongNhan";
            this.gtxtCongNhan.ReadOnly = true;
            this.gtxtCongNhan.Width = 150;
            // 
            // gtxtKgCat
            // 
            this.gtxtKgCat.DataPropertyName = "TenCongViec";
            this.gtxtKgCat.HeaderText = "Công việc";
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
            // gtxtPheTH
            // 
            this.gtxtPheTH.DataPropertyName = "Khg";
            this.gtxtPheTH.HeaderText = "Khách hàng";
            this.gtxtPheTH.Name = "gtxtPheTH";
            this.gtxtPheTH.ReadOnly = true;
            this.gtxtPheTH.Width = 130;
            // 
            // gtxtPheSuot
            // 
            this.gtxtPheSuot.DataPropertyName = "SoLuong";
            this.gtxtPheSuot.HeaderText = "Số lượng SP";
            this.gtxtPheSuot.Name = "gtxtPheSuot";
            this.gtxtPheSuot.ReadOnly = true;
            this.gtxtPheSuot.Width = 105;
            // 
            // gtxtPheDC
            // 
            this.gtxtPheDC.DataPropertyName = "GhiChu";
            this.gtxtPheDC.HeaderText = "Ghi chú";
            this.gtxtPheDC.Name = "gtxtPheDC";
            this.gtxtPheDC.ReadOnly = true;
            this.gtxtPheDC.Width = 200;
            // 
            // qlCongMayInN1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.gvCongN1);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "qlCongMayInN1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Công Nhóm 1";
            this.Load += new System.EventHandler(this.qlCongMayInN1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCongN1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvCongN1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridViewButtonColumn gbtEdit;
        private System.Windows.Forms.DataGridViewButtonColumn gbtDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtCongNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKgCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtKhoVai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheSuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPheDC;
    }
}