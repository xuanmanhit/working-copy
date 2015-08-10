namespace PhanMem
{
    partial class qlViecPhu
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
            this.gvViecPhu = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBack = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvViecPhu)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Danh sách Việc Phụ";
            // 
            // gvViecPhu
            // 
            this.gvViecPhu.AllowUserToAddRows = false;
            this.gvViecPhu.AllowUserToDeleteRows = false;
            this.gvViecPhu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvViecPhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvViecPhu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSua,
            this.btnDelete,
            this.txtID,
            this.txtSTT,
            this.tbcHoTen});
            this.gvViecPhu.Location = new System.Drawing.Point(12, 58);
            this.gvViecPhu.Name = "gvViecPhu";
            this.gvViecPhu.ReadOnly = true;
            this.gvViecPhu.Size = new System.Drawing.Size(760, 392);
            this.gvViecPhu.TabIndex = 2;
            this.gvViecPhu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvViecPhu_CellClick);
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
            this.tbcHoTen.DataPropertyName = "TenViec";
            this.tbcHoTen.HeaderText = "Tên Việc";
            this.tbcHoTen.Name = "tbcHoTen";
            this.tbcHoTen.ReadOnly = true;
            this.tbcHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(692, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 40);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "Trở lại";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(606, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 40);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // qlViecPhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gvViecPhu);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "qlViecPhu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Việc Phụ";
            this.Load += new System.EventHandler(this.qlViecPhu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvViecPhu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvViecPhu;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcHoTen;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btThem;
    }
}