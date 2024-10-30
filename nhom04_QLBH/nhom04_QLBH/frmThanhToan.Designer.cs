namespace nhom04_QLBH
{
    partial class frmThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.rdbThanhToan = new System.Windows.Forms.RadioButton();
            this.rdbNhanHang = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(282, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN ĐƠN HÀNG";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Blue;
            this.btnXacNhan.Location = new System.Drawing.Point(283, 453);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(272, 53);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // rdbThanhToan
            // 
            this.rdbThanhToan.AutoSize = true;
            this.rdbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThanhToan.Location = new System.Drawing.Point(271, 172);
            this.rdbThanhToan.Name = "rdbThanhToan";
            this.rdbThanhToan.Size = new System.Drawing.Size(448, 24);
            this.rdbThanhToan.TabIndex = 4;
            this.rdbThanhToan.TabStop = true;
            this.rdbThanhToan.Text = "Thanh toán trực tiếp bằng hình thức chuyển khoản";
            this.rdbThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdbNhanHang
            // 
            this.rdbNhanHang.AutoSize = true;
            this.rdbNhanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNhanHang.Location = new System.Drawing.Point(271, 309);
            this.rdbNhanHang.Name = "rdbNhanHang";
            this.rdbNhanHang.Size = new System.Drawing.Size(245, 24);
            this.rdbNhanHang.TabIndex = 4;
            this.rdbNhanHang.TabStop = true;
            this.rdbNhanHang.Text = "Thanh toán khi nhận hàng";
            this.rdbNhanHang.UseVisualStyleBackColor = true;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 563);
            this.Controls.Add(this.rdbNhanHang);
            this.Controls.Add(this.rdbThanhToan);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label1);
            this.Name = "frmThanhToan";
            this.Text = "Thanh Toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.RadioButton rdbThanhToan;
        private System.Windows.Forms.RadioButton rdbNhanHang;
    }
}