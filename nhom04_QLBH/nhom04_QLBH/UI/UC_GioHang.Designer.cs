namespace nhom04_QLBH.UI
{
    partial class UC_GioHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.Blue;
            this.btnDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ForeColor = System.Drawing.Color.Yellow;
            this.btnDatHang.Location = new System.Drawing.Point(0, 582);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(605, 71);
            this.btnDatHang.TabIndex = 0;
            this.btnDatHang.Text = "Đặt Hàng";
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Blue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Yellow;
            this.btnXoa.Location = new System.Drawing.Point(606, 582);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(595, 71);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa Khỏi Giỏ Hàng";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // UC_GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDatHang);
            this.Name = "UC_GioHang";
            this.Size = new System.Drawing.Size(1201, 651);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnXoa;
    }
}
