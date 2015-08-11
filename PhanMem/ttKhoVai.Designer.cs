namespace PhanMem
{
    partial class ttKhoVai
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
            this.btHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhoVai = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.txtGiaCat = new System.Windows.Forms.TextBox();
            this.txtGiaDet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKhoVaiChinh = new System.Windows.Forms.ComboBox();
            this.cKhoVaiChinh = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(180, 170);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(80, 36);
            this.btHuy.TabIndex = 6;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Đơn giá Cắt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Đơn giá Dệt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Khổ Vải";
            // 
            // txtKhoVai
            // 
            this.txtKhoVai.Location = new System.Drawing.Point(130, 18);
            this.txtKhoVai.Name = "txtKhoVai";
            this.txtKhoVai.Size = new System.Drawing.Size(191, 24);
            this.txtKhoVai.TabIndex = 0;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(79, 170);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 36);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtGiaCat
            // 
            this.txtGiaCat.Location = new System.Drawing.Point(130, 95);
            this.txtGiaCat.Name = "txtGiaCat";
            this.txtGiaCat.Size = new System.Drawing.Size(191, 24);
            this.txtGiaCat.TabIndex = 2;
            // 
            // txtGiaDet
            // 
            this.txtGiaDet.Location = new System.Drawing.Point(130, 57);
            this.txtGiaDet.Name = "txtGiaDet";
            this.txtGiaDet.Size = new System.Drawing.Size(191, 24);
            this.txtGiaDet.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Khổ Vải Chính";
            // 
            // cbKhoVaiChinh
            // 
            this.cbKhoVaiChinh.FormattingEnabled = true;
            this.cbKhoVaiChinh.Location = new System.Drawing.Point(151, 133);
            this.cbKhoVaiChinh.Name = "cbKhoVaiChinh";
            this.cbKhoVaiChinh.Size = new System.Drawing.Size(170, 25);
            this.cbKhoVaiChinh.TabIndex = 4;
            // 
            // cKhoVaiChinh
            // 
            this.cKhoVaiChinh.AutoSize = true;
            this.cKhoVaiChinh.Location = new System.Drawing.Point(130, 138);
            this.cKhoVaiChinh.Name = "cKhoVaiChinh";
            this.cKhoVaiChinh.Size = new System.Drawing.Size(15, 14);
            this.cKhoVaiChinh.TabIndex = 3;
            this.cKhoVaiChinh.UseVisualStyleBackColor = true;
            // 
            // ttKhoVai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 218);
            this.ControlBox = false;
            this.Controls.Add(this.cKhoVaiChinh);
            this.Controls.Add(this.cbKhoVaiChinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiaCat);
            this.Controls.Add(this.txtGiaDet);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKhoVai);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ttKhoVai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Khổ Vải";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKhoVai;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtGiaCat;
        private System.Windows.Forms.TextBox txtGiaDet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKhoVaiChinh;
        private System.Windows.Forms.CheckBox cKhoVaiChinh;
    }
}