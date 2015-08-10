namespace PhanMem
{
    partial class ttCongPhu
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
            this.dtpNgayCong = new System.Windows.Forms.DateTimePicker();
            this.txtGiaCong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCongNhan = new System.Windows.Forms.ComboBox();
            this.txtGioCong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenViec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpNgayCong
            // 
            this.dtpNgayCong.CustomFormat = "";
            this.dtpNgayCong.Location = new System.Drawing.Point(136, 23);
            this.dtpNgayCong.Name = "dtpNgayCong";
            this.dtpNgayCong.Size = new System.Drawing.Size(209, 24);
            this.dtpNgayCong.TabIndex = 23;
            // 
            // txtGiaCong
            // 
            this.txtGiaCong.Location = new System.Drawing.Point(136, 167);
            this.txtGiaCong.Name = "txtGiaCong";
            this.txtGiaCong.Size = new System.Drawing.Size(209, 24);
            this.txtGiaCong.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Giá Công";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Giờ Công";
            // 
            // cbCongNhan
            // 
            this.cbCongNhan.FormattingEnabled = true;
            this.cbCongNhan.Location = new System.Drawing.Point(136, 59);
            this.cbCongNhan.Name = "cbCongNhan";
            this.cbCongNhan.Size = new System.Drawing.Size(209, 25);
            this.cbCongNhan.TabIndex = 24;
            // 
            // txtGioCong
            // 
            this.txtGioCong.Location = new System.Drawing.Point(136, 130);
            this.txtGioCong.Name = "txtGioCong";
            this.txtGioCong.Size = new System.Drawing.Size(209, 24);
            this.txtGioCong.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ngày Công";
            // 
            // cbTenViec
            // 
            this.cbTenViec.FormattingEnabled = true;
            this.cbTenViec.Location = new System.Drawing.Point(136, 94);
            this.cbTenViec.Name = "cbTenViec";
            this.cbTenViec.Size = new System.Drawing.Size(209, 25);
            this.cbTenViec.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Công Việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Công Nhân";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(202, 208);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(100, 40);
            this.btHuy.TabIndex = 29;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(63, 208);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 40);
            this.btThem.TabIndex = 28;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // ttCongPhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 260);
            this.ControlBox = false;
            this.Controls.Add(this.dtpNgayCong);
            this.Controls.Add(this.txtGiaCong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCongNhan);
            this.Controls.Add(this.txtGioCong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTenViec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ttCongPhu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Công Phụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayCong;
        private System.Windows.Forms.TextBox txtGiaCong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCongNhan;
        private System.Windows.Forms.TextBox txtGioCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenViec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btThem;
    }
}