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
            this.btKhoVai = new System.Windows.Forms.Button();
            this.bt_qlCongNhan = new System.Windows.Forms.Button();
            this.btViecPhu = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLuong = new System.Windows.Forms.Button();
            this.btBcTongHop = new System.Windows.Forms.Button();
            this.btBcNgay = new System.Windows.Forms.Button();
            this.btCongPhu = new System.Windows.Forms.Button();
            this.btNhapCat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_qlMayIn = new System.Windows.Forms.Button();
            this.bt_qlTho = new System.Windows.Forms.Button();
            this.bt_qlCongViec = new System.Windows.Forms.Button();
            this.bt_qlKH = new System.Windows.Forms.Button();
            this.bt_qlCongN2 = new System.Windows.Forms.Button();
            this.bt_bcMayIn = new System.Windows.Forms.Button();
            this.bt_qlCongPhu = new System.Windows.Forms.Button();
            this.bt_qlCongN1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btKhoVai);
            this.groupBox1.Controls.Add(this.bt_qlCongNhan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(191, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý thông tin chung";
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
            // btViecPhu
            // 
            this.btViecPhu.Location = new System.Drawing.Point(339, 26);
            this.btViecPhu.Margin = new System.Windows.Forms.Padding(5);
            this.btViecPhu.Name = "btViecPhu";
            this.btViecPhu.Size = new System.Drawing.Size(150, 50);
            this.btViecPhu.TabIndex = 3;
            this.btViecPhu.Text = "Quản lý Việc Phụ";
            this.btViecPhu.UseVisualStyleBackColor = true;
            this.btViecPhu.Click += new System.EventHandler(this.btViecPhu_Click);
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
            this.groupBox2.Controls.Add(this.btViecPhu);
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
            this.groupBox2.Size = new System.Drawing.Size(564, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý thông tin Cắt";
            // 
            // btLuong
            // 
            this.btLuong.Location = new System.Drawing.Point(179, 86);
            this.btLuong.Margin = new System.Windows.Forms.Padding(5);
            this.btLuong.Name = "btLuong";
            this.btLuong.Size = new System.Drawing.Size(150, 50);
            this.btLuong.TabIndex = 4;
            this.btLuong.Text = "Tổng hợp Lương";
            this.btLuong.UseVisualStyleBackColor = true;
            this.btLuong.Click += new System.EventHandler(this.btLuong_Click);
            // 
            // btBcTongHop
            // 
            this.btBcTongHop.Location = new System.Drawing.Point(339, 86);
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
            this.btBcNgay.Location = new System.Drawing.Point(19, 86);
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
            this.btCongPhu.Location = new System.Drawing.Point(179, 26);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_qlMayIn);
            this.groupBox3.Controls.Add(this.bt_qlTho);
            this.groupBox3.Controls.Add(this.bt_qlCongViec);
            this.groupBox3.Controls.Add(this.bt_qlKH);
            this.groupBox3.Controls.Add(this.bt_qlCongN2);
            this.groupBox3.Controls.Add(this.bt_bcMayIn);
            this.groupBox3.Controls.Add(this.bt_qlCongPhu);
            this.groupBox3.Controls.Add(this.bt_qlCongN1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 183);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(756, 160);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản lý thông tin May - In";
            // 
            // bt_qlMayIn
            // 
            this.bt_qlMayIn.Location = new System.Drawing.Point(499, 26);
            this.bt_qlMayIn.Margin = new System.Windows.Forms.Padding(5);
            this.bt_qlMayIn.Name = "bt_qlMayIn";
            this.bt_qlMayIn.Size = new System.Drawing.Size(150, 50);
            this.bt_qlMayIn.TabIndex = 7;
            this.bt_qlMayIn.Text = "Quản lý Máy In";
            this.bt_qlMayIn.UseVisualStyleBackColor = true;
            this.bt_qlMayIn.Click += new System.EventHandler(this.bt_qlMayIn_Click);
            // 
            // bt_qlTho
            // 
            this.bt_qlTho.Location = new System.Drawing.Point(19, 26);
            this.bt_qlTho.Margin = new System.Windows.Forms.Padding(5);
            this.bt_qlTho.Name = "bt_qlTho";
            this.bt_qlTho.Size = new System.Drawing.Size(150, 50);
            this.bt_qlTho.TabIndex = 4;
            this.bt_qlTho.Text = "Quản lý Thợ";
            this.bt_qlTho.UseVisualStyleBackColor = true;
            this.bt_qlTho.Click += new System.EventHandler(this.bt_qlTho_Click);
            // 
            // bt_qlCongViec
            // 
            this.bt_qlCongViec.Location = new System.Drawing.Point(339, 26);
            this.bt_qlCongViec.Margin = new System.Windows.Forms.Padding(5);
            this.bt_qlCongViec.Name = "bt_qlCongViec";
            this.bt_qlCongViec.Size = new System.Drawing.Size(150, 50);
            this.bt_qlCongViec.TabIndex = 6;
            this.bt_qlCongViec.Text = "Quản lý Công Việc";
            this.bt_qlCongViec.UseVisualStyleBackColor = true;
            this.bt_qlCongViec.Click += new System.EventHandler(this.bt_qlCongViec_Click);
            // 
            // bt_qlKH
            // 
            this.bt_qlKH.Location = new System.Drawing.Point(179, 26);
            this.bt_qlKH.Margin = new System.Windows.Forms.Padding(5);
            this.bt_qlKH.Name = "bt_qlKH";
            this.bt_qlKH.Size = new System.Drawing.Size(150, 50);
            this.bt_qlKH.TabIndex = 4;
            this.bt_qlKH.Text = "Quản lý Khách Hàng";
            this.bt_qlKH.UseVisualStyleBackColor = true;
            this.bt_qlKH.Click += new System.EventHandler(this.bt_qlKH_Click);
            // 
            // bt_qlCongN2
            // 
            this.bt_qlCongN2.Location = new System.Drawing.Point(179, 86);
            this.bt_qlCongN2.Margin = new System.Windows.Forms.Padding(5);
            this.bt_qlCongN2.Name = "bt_qlCongN2";
            this.bt_qlCongN2.Size = new System.Drawing.Size(150, 50);
            this.bt_qlCongN2.TabIndex = 5;
            this.bt_qlCongN2.Text = "Quản lý Công Nhóm 2";
            this.bt_qlCongN2.UseVisualStyleBackColor = true;
            this.bt_qlCongN2.Click += new System.EventHandler(this.bt_qlCongN2_Click);
            // 
            // bt_bcMayIn
            // 
            this.bt_bcMayIn.Location = new System.Drawing.Point(499, 86);
            this.bt_bcMayIn.Margin = new System.Windows.Forms.Padding(5);
            this.bt_bcMayIn.Name = "bt_bcMayIn";
            this.bt_bcMayIn.Size = new System.Drawing.Size(150, 50);
            this.bt_bcMayIn.TabIndex = 2;
            this.bt_bcMayIn.Text = "Báo cáo";
            this.bt_bcMayIn.UseVisualStyleBackColor = true;
            this.bt_bcMayIn.Click += new System.EventHandler(this.bt_bcMayIn_Click);
            // 
            // bt_qlCongPhu
            // 
            this.bt_qlCongPhu.Location = new System.Drawing.Point(339, 86);
            this.bt_qlCongPhu.Margin = new System.Windows.Forms.Padding(5);
            this.bt_qlCongPhu.Name = "bt_qlCongPhu";
            this.bt_qlCongPhu.Size = new System.Drawing.Size(150, 50);
            this.bt_qlCongPhu.TabIndex = 1;
            this.bt_qlCongPhu.Text = "Quản lý Công Phụ";
            this.bt_qlCongPhu.UseVisualStyleBackColor = true;
            this.bt_qlCongPhu.Click += new System.EventHandler(this.bt_qlCongPhu_Click);
            // 
            // bt_qlCongN1
            // 
            this.bt_qlCongN1.Location = new System.Drawing.Point(19, 86);
            this.bt_qlCongN1.Margin = new System.Windows.Forms.Padding(5);
            this.bt_qlCongN1.Name = "bt_qlCongN1";
            this.bt_qlCongN1.Size = new System.Drawing.Size(150, 50);
            this.bt_qlCongN1.TabIndex = 0;
            this.bt_qlCongN1.Text = "Quản lý Công Nhóm 1";
            this.bt_qlCongN1.UseVisualStyleBackColor = true;
            this.bt_qlCongN1.Click += new System.EventHandler(this.bt_qlCongN1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_bcMayIn;
        private System.Windows.Forms.Button bt_qlCongPhu;
        private System.Windows.Forms.Button bt_qlCongN1;
        private System.Windows.Forms.Button bt_qlCongN2;
        private System.Windows.Forms.Button bt_qlKH;
        private System.Windows.Forms.Button bt_qlTho;
        private System.Windows.Forms.Button bt_qlCongViec;
        private System.Windows.Forms.Button bt_qlMayIn;
    }
}

