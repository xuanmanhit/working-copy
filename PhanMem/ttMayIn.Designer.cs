namespace PhanMem
{
    partial class ttMayIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMayIn = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(200, 64);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(80, 36);
            this.btHuy.TabIndex = 27;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên Máy in";
            // 
            // txtMayIn
            // 
            this.txtMayIn.Location = new System.Drawing.Point(120, 18);
            this.txtMayIn.Name = "txtMayIn";
            this.txtMayIn.Size = new System.Drawing.Size(210, 24);
            this.txtMayIn.TabIndex = 25;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(88, 64);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 36);
            this.btThem.TabIndex = 26;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // ttMayIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 119);
            this.ControlBox = false;
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMayIn);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ttMayIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Máy in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMayIn;
        private System.Windows.Forms.Button btThem;
    }
}