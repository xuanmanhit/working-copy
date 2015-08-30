namespace PhanMem
{
    partial class bcMayIn
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
            this.bt_bcLuongN1 = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_bcLuongN1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(510, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo Nhóm 1";
            // 
            // bt_bcLuongN1
            // 
            this.bt_bcLuongN1.Location = new System.Drawing.Point(21, 26);
            this.bt_bcLuongN1.Margin = new System.Windows.Forms.Padding(5);
            this.bt_bcLuongN1.Name = "bt_bcLuongN1";
            this.bt_bcLuongN1.Size = new System.Drawing.Size(150, 50);
            this.bt_bcLuongN1.TabIndex = 0;
            this.bt_bcLuongN1.Text = "Báo cáo Lương";
            this.bt_bcLuongN1.UseVisualStyleBackColor = true;
            this.bt_bcLuongN1.Click += new System.EventHandler(this.bt_bcLuongN1_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(446, 286);
            this.btBack.Margin = new System.Windows.Forms.Padding(5);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 40);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Trở lại";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // bcMayIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 340);
            this.ControlBox = false;
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "bcMayIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo May - In";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_bcLuongN1;
        private System.Windows.Forms.Button btBack;
    }
}