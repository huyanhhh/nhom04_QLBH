namespace nhom04_QLBH
{
    partial class XacNhanOtpForm
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
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnConfirmOTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOTP.Location = new System.Drawing.Point(132, 71);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(139, 27);
            this.txtOTP.TabIndex = 0;
            // 
            // btnConfirmOTP
            // 
            this.btnConfirmOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConfirmOTP.Location = new System.Drawing.Point(301, 65);
            this.btnConfirmOTP.Name = "btnConfirmOTP";
            this.btnConfirmOTP.Size = new System.Drawing.Size(102, 33);
            this.btnConfirmOTP.TabIndex = 1;
            this.btnConfirmOTP.Text = "xác nhận";
            this.btnConfirmOTP.UseVisualStyleBackColor = true;
            this.btnConfirmOTP.Click += new System.EventHandler(this.btnConfirmOTP_Click);
            // 
            // XacNhanOtpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 187);
            this.Controls.Add(this.btnConfirmOTP);
            this.Controls.Add(this.txtOTP);
            this.Name = "XacNhanOtpForm";
            this.Text = "XacNhanOtpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnConfirmOTP;
    }
}