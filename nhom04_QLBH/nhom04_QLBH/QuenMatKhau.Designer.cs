namespace nhom04_QLBH
{
    partial class QuenMatKhau
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbketqua = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtShowpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(124, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(219, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(122, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSend.Location = new System.Drawing.Point(197, 253);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(155, 33);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Lấy Mật Khẩu";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbketqua.Location = new System.Drawing.Point(124, 195);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(70, 20);
            this.lbketqua.TabIndex = 0;
            this.lbketqua.Text = "Kết Quả";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel1.Location = new System.Drawing.Point(418, 266);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng Nhập";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtShowpass
            // 
            this.txtShowpass.Location = new System.Drawing.Point(219, 193);
            this.txtShowpass.Name = "txtShowpass";
            this.txtShowpass.ReadOnly = true;
            this.txtShowpass.Size = new System.Drawing.Size(122, 22);
            this.txtShowpass.TabIndex = 4;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 316);
            this.Controls.Add(this.txtShowpass);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.label1);
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbketqua;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtShowpass;
    }
}