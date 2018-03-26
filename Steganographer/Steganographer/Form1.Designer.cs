namespace Steganographer
{
    partial class Steganographer
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
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIle Hiding";
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Location = new System.Drawing.Point(12, 120);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(123, 35);
            this.encrypt_btn.TabIndex = 1;
            this.encrypt_btn.Text = "Encrypt/Hide";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Location = new System.Drawing.Point(168, 120);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(123, 35);
            this.decrypt_btn.TabIndex = 2;
            this.decrypt_btn.Text = "Decrypt/Show";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // Steganographer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 167);
            this.Controls.Add(this.decrypt_btn);
            this.Controls.Add(this.encrypt_btn);
            this.Controls.Add(this.label1);
            this.Name = "Steganographer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Steganographer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.Button decrypt_btn;
    }
}

