namespace Steganographer
{
    partial class Decrypt
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
            this.imageFile_lbl = new System.Windows.Forms.Label();
            this.imageFile_txt = new System.Windows.Forms.TextBox();
            this.imageFile_btn = new System.Windows.Forms.Button();
            this.saveFile_lbl = new System.Windows.Forms.Label();
            this.saveFile_txt = new System.Windows.Forms.TextBox();
            this.saveFile_btn = new System.Windows.Forms.Button();
            this.imageFile_ofd = new System.Windows.Forms.OpenFileDialog();
            this.File_sfd = new System.Windows.Forms.SaveFileDialog();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageFile_lbl
            // 
            this.imageFile_lbl.AutoSize = true;
            this.imageFile_lbl.Location = new System.Drawing.Point(12, 23);
            this.imageFile_lbl.Name = "imageFile_lbl";
            this.imageFile_lbl.Size = new System.Drawing.Size(109, 17);
            this.imageFile_lbl.TabIndex = 0;
            this.imageFile_lbl.Text = "Image File Path:";
            // 
            // imageFile_txt
            // 
            this.imageFile_txt.Location = new System.Drawing.Point(15, 43);
            this.imageFile_txt.Name = "imageFile_txt";
            this.imageFile_txt.Size = new System.Drawing.Size(458, 22);
            this.imageFile_txt.TabIndex = 1;
            // 
            // imageFile_btn
            // 
            this.imageFile_btn.Location = new System.Drawing.Point(479, 43);
            this.imageFile_btn.Name = "imageFile_btn";
            this.imageFile_btn.Size = new System.Drawing.Size(155, 23);
            this.imageFile_btn.TabIndex = 2;
            this.imageFile_btn.Text = "Browse";
            this.imageFile_btn.UseVisualStyleBackColor = true;
            this.imageFile_btn.Click += new System.EventHandler(this.imageFile_btn_Click);
            // 
            // saveFile_lbl
            // 
            this.saveFile_lbl.AutoSize = true;
            this.saveFile_lbl.Location = new System.Drawing.Point(12, 80);
            this.saveFile_lbl.Name = "saveFile_lbl";
            this.saveFile_lbl.Size = new System.Drawing.Size(103, 17);
            this.saveFile_lbl.TabIndex = 3;
            this.saveFile_lbl.Text = "Save File Path:";
            // 
            // saveFile_txt
            // 
            this.saveFile_txt.Location = new System.Drawing.Point(15, 100);
            this.saveFile_txt.Name = "saveFile_txt";
            this.saveFile_txt.Size = new System.Drawing.Size(457, 22);
            this.saveFile_txt.TabIndex = 4;
            // 
            // saveFile_btn
            // 
            this.saveFile_btn.Location = new System.Drawing.Point(479, 99);
            this.saveFile_btn.Name = "saveFile_btn";
            this.saveFile_btn.Size = new System.Drawing.Size(155, 23);
            this.saveFile_btn.TabIndex = 5;
            this.saveFile_btn.Text = "Browse";
            this.saveFile_btn.UseVisualStyleBackColor = true;
            this.saveFile_btn.Click += new System.EventHandler(this.saveFile_btn_Click);
            // 
            // imageFile_ofd
            // 
            this.imageFile_ofd.FileName = "openFileDialog1";
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Location = new System.Drawing.Point(260, 230);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(128, 44);
            this.decrypt_btn.TabIndex = 6;
            this.decrypt_btn.Text = "Decrypt/Show";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(15, 162);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(457, 22);
            this.password_txt.TabIndex = 7;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(12, 142);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(111, 17);
            this.password_lbl.TabIndex = 8;
            this.password_lbl.Text = "Enter Password:";
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 286);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.decrypt_btn);
            this.Controls.Add(this.saveFile_btn);
            this.Controls.Add(this.saveFile_txt);
            this.Controls.Add(this.saveFile_lbl);
            this.Controls.Add(this.imageFile_btn);
            this.Controls.Add(this.imageFile_txt);
            this.Controls.Add(this.imageFile_lbl);
            this.Name = "Decrypt";
            this.Text = "Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imageFile_lbl;
        private System.Windows.Forms.TextBox imageFile_txt;
        private System.Windows.Forms.Button imageFile_btn;
        private System.Windows.Forms.Label saveFile_lbl;
        private System.Windows.Forms.TextBox saveFile_txt;
        private System.Windows.Forms.Button saveFile_btn;
        private System.Windows.Forms.OpenFileDialog imageFile_ofd;
        private System.Windows.Forms.SaveFileDialog File_sfd;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label password_lbl;
    }
}