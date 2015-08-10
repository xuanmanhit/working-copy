namespace PhanMem
{
    partial class qlKhoVai
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
            this.gvKhoVai = new System.Windows.Forms.DataGridView();
            this.btBack = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KVC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcLoaiHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoVai)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Danh sách Khổ Vải";
            // 
            // gvKhoVai
            // 
            this.gvKhoVai.AllowUserToAddRows = false;
            this.gvKhoVai.AllowUserToDeleteRows = false;
            this.gvKhoVai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvKhoVai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKhoVai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSua,
            this.btnDelete,
            this.txtID,
            this.txtSTT,
            this.tbcHoTen,
            this.KVC,
            this.tbcCongViec,
            this.tbcLoaiHinh});
            this.gvKhoVai.Location = new System.Drawing.Point(12, 58);
            this.gvKhoVai.Name = "gvKhoVai";
            this.gvKhoVai.ReadOnly = true;
            this.gvKhoVai.Size = new System.Drawing.Size(760, 392);
            this.gvKhoVai.TabIndex = 10;
            this.gvKhoVai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKhoVai_CellClick);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(692, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 40);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Trở lại";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(606, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 40);
            this.btThem.TabIndex = 1;
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
            this.tbcHoTen.DataPropertyName = "KhoVai";
            this.tbcHoTen.HeaderText = "Khổ Vải";
            this.tbcHoTen.Name = "tbcHoTen";
            this.tbcHoTen.ReadOnly = true;
            this.tbcHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KVC
            // 
            this.KVC.DataPropertyName = "KVC";
            this.KVC.HeaderText = "Khổ Vải Chính";
            this.KVC.Name = "KVC";
            this.KVC.ReadOnly = true;
            this.KVC.Width = 150;
            // 
            // tbcCongViec
            // 
            this.tbcCongViec.DataPropertyName = "DonGiaDet";
            this.tbcCongViec.HeaderText = "Đơn giá Dệt";
            this.tbcCongViec.Name = "tbcCongViec";
            this.tbcCongViec.ReadOnly = true;
            this.tbcCongViec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tbcCongViec.Width = 110;
            // 
            // tbcLoaiHinh
            // 
            this.tbcLoaiHinh.DataPropertyName = "DonGiaCat";
            this.tbcLoaiHinh.HeaderText = "Đơn Giá Cắt";
            this.tbcLoaiHinh.Name = "tbcLoaiHinh";
            this.tbcLoaiHinh.ReadOnly = true;
            this.tbcLoaiHinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tbcLoaiHinh.Width = 110;
            // 
            // qlKhoVai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gvKhoVai);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "qlKhoVai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Khổ Vải";
            this.Load += new System.EventHandler(this.qlKhoVai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoVai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvKhoVai;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn KVC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcLoaiHinh;
    }
}