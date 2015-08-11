namespace PhanMem
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btViecPhu = new System.Windows.Forms.Button();
            this.btKhoVai = new System.Windows.Forms.Button();
            this.bt_qlCongNhan = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBcTongHop = new System.Windows.Forms.Button();
            this.btBcNgay = new System.Windows.Forms.Button();
            this.btCongPhu = new System.Windows.Forms.Button();
            this.btNhapCat = new System.Windows.Forms.Button();
            this.btLuong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btViecPhu);
            this.groupBox1.Controls.Add(this.btKhoVai);
            this.groupBox1.Controls.Add(this.bt_qlCongNhan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(191, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý thông tin chung";
            // 
            // btViecPhu
            // 
            this.btViecPhu.Location = new System.Drawing.Point(21, 146);
            this.btViecPhu.Margin = new System.Windows.Forms.Padding(5);
            this.btViecPhu.Name = "btViecPhu";
            this.btViecPhu.Size = new System.Drawing.Size(150, 50);
            this.btViecPhu.TabIndex = 3;
            this.btViecPhu.Text = "Quản lý Việc Phụ";
            this.btViecPhu.UseVisualStyleBackColor = true;
            this.btViecPhu.Click += new System.EventHandler(this.btViecPhu_Click);
            // 
            // btKhoVai
            // 
            this.btKhoVai.Location = new System.Drawing.Point(21, 86);
            this.btKhoVai.Margin = new System.Windows.Forms.Padding(5);
            this.btKhoVai.Name = "btKhoVai";
            this.btKhoVai.Size = new System.Drawing.Size(150, 50);
            this.btKhoVai.TabIndex = 1;
            this.btKhoVai.Text = "Quản lý Khổ Vải";
            this.btKhoVai.UseVisualStyleBackColor = true;
            this.btKhoVai.Click += new System.EventHandler(this.btKhoVai_Click);
            // 
            // bt_qlCongNhan
            // 
            this.bt_qlCongNhan.Location = new System.Drawing.Point(21, 26);
            this.bt_qlCongNhan.Margin = new System.Windows.Forms.Padding(5);
            this.bt_qlCongNhan.Name = "bt_qlCongNhan";
            this.bt_qlCongNhan.Size = new System.Drawing.Size(150, 50);
            this.bt_qlCongNhan.TabIndex = 0;
            this.bt_qlCongNhan.Text = "Quản lý Công Nhân";
            this.bt_qlCongNhan.UseVisualStyleBackColor = true;
            this.bt_qlCongNhan.Click += new System.EventHandler(this.bt_qlCongNhan_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(690, 408);
            this.btExit.Margin = new System.Windows.Forms.Padding(5);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(80, 40);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLuong);
            this.groupBox2.Controls.Add(this.btBcTongHop);
            this.groupBox2.Controls.Add(this.btBcNgay);
            this.groupBox2.Controls.Add(this.btCongPhu);
            this.groupBox2.Controls.Add(this.btNhapCat);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(206, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(189, 372);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý thông tin Cắt";
            // 
            // btBcTongHop
            // 
            this.btBcTongHop.Location = new System.Drawing.Point(19, 266);
            this.btBcTongHop.Margin = new System.Windows.Forms.Padding(5);
            this.btBcTongHop.Name = "btBcTongHop";
            this.btBcTongHop.Size = new System.Drawing.Size(150, 50);
            this.btBcTongHop.TabIndex = 3;
            this.btBcTongHop.Text = "Báo cáo Tổng hợp";
            this.btBcTongHop.UseVisualStyleBackColor = true;
            this.btBcTongHop.Click += new System.EventHandler(this.btBcTongHop_Click);
            // 
            // btBcNgay
            // 
            this.btBcNgay.Location = new System.Drawing.Point(19, 146);
            this.btBcNgay.Margin = new System.Windows.Forms.Padding(5);
            this.btBcNgay.Name = "btBcNgay";
            this.btBcNgay.Size = new System.Drawing.Size(150, 50);
            this.btBcNgay.TabIndex = 2;
            this.btBcNgay.Text = "Báo cáo Ngày";
            this.btBcNgay.UseVisualStyleBackColor = true;
            this.btBcNgay.Click += new System.EventHandler(this.btBaoCao_Click);
            // 
            // btCongPhu
            // 
            this.btCongPhu.Location = new System.Drawing.Point(19, 86);
            this.btCongPhu.Margin = new System.Windows.Forms.Padding(5);
            this.btCongPhu.Name = "btCongPhu";
            this.btCongPhu.Size = new System.Drawing.Size(150, 50);
            this.btCongPhu.TabIndex = 1;
            this.btCongPhu.Text = "Quản lý Công Phụ";
            this.btCongPhu.UseVisualStyleBackColor = true;
            this.btCongPhu.Click += new System.EventHandler(this.btCongPhu_Click);
            // 
            // btNhapCat
            // 
            this.btNhapCat.Location = new System.Drawing.Point(19, 26);
            this.btNhapCat.Margin = new System.Windows.Forms.Padding(5);
            this.btNhapCat.Name = "btNhapCat";
            this.btNhapCat.Size = new System.Drawing.Size(150, 50);
            this.btNhapCat.TabIndex = 0;
            this.btNhapCat.Text = "Quản lý Công Cắt";
            this.btNhapCat.UseVisualStyleBackColor = true;
            this.btNhapCat.Click += new System.EventHandler(this.btNhapCat_Click);
            // 
            // btLuong
            // 
            this.btLuong.Location = new System.Drawing.Point(19, 206);
            this.btLuong.Margin = new System.Windows.Forms.Padding(5);
            this.btLuong.Name = "btLuong";
            this.btLuong.Size = new System.Drawing.Size(150, 50);
            this.btLuong.TabIndex = 4;
            this.btLuong.Text = "Tổng hợp Lương";
            this.btLuong.UseVisualStyleBackColor = true;
            this.btLuong.Click += new System.EventHandler(this.btLuong_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_qlCongNhan;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btKhoVai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btNhapCat;
        private System.Windows.Forms.Button btViecPhu;
        private System.Windows.Forms.Button btCongPhu;
        private System.Windows.Forms.Button btBcNgay;
        private System.Windows.Forms.Button btBcTongHop;
        private System.Windows.Forms.Button btLuong;
    }
}

