namespace PhanMem
{
    partial class BcTongHopMay
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
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btHuy = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.sfdXuatExcel = new System.Windows.Forms.SaveFileDialog();
            this.btXNT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "";
            this.dtpDenNgay.Location = new System.Drawing.Point(104, 48);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(167, 24);
            this.dtpDenNgay.TabIndex = 37;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "";
            this.dtpTuNgay.Location = new System.Drawing.Point(104, 13);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(167, 24);
            this.dtpTuNgay.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Từ ngày";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(201, 94);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(71, 36);
            this.btHuy.TabIndex = 33;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(17, 94);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(86, 36);
            this.btExport.TabIndex = 32;
            this.btExport.Text = "Sản phẩm";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btXNT
            // 
            this.btXNT.Location = new System.Drawing.Point(109, 94);
            this.btXNT.Name = "btXNT";
            this.btXNT.Size = new System.Drawing.Size(86, 36);
            this.btXNT.TabIndex = 38;
            this.btXNT.Text = "XNT";
            this.btXNT.UseVisualStyleBackColor = true;
            this.btXNT.Click += new System.EventHandler(this.btXNT_Click);
            // 
            // BcTongHopMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.ControlBox = false;
            this.Controls.Add(this.btXNT);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btExport);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BcTongHopMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sản phẩm May";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.SaveFileDialog sfdXuatExcel;
        private System.Windows.Forms.Button btXNT;
    }
}