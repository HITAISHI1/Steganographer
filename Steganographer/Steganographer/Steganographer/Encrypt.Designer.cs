namespace Steganographer
{
    partial class Encrypt
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
            this.components = new System.ComponentModel.Container();
            this.encrpyt_btn = new System.Windows.Forms.Button();
            this.imageFile_lbl = new System.Windows.Forms.Label();
            this.imageFile_txt = new System.Windows.Forms.TextBox();
            this.imageFile_ofd = new System.Windows.Forms.OpenFileDialog();
            this.imageFile_btn = new System.Windows.Forms.Button();
            this.inputFile_lbl = new System.Windows.Forms.Label();
            this.inputFile_txt = new System.Windows.Forms.TextBox();
            this.inputFile_ofd = new System.Windows.Forms.OpenFileDialog();
            this.inputFile_btn = new System.Windows.Forms.Button();
            this.saveFile_lbl = new System.Windows.Forms.Label();
            this.saveFile_txt = new System.Windows.Forms.TextBox();
            this.saveFile_btn = new System.Windows.Forms.Button();
            this.saveFile_sfd = new System.Windows.Forms.SaveFileDialog();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.confirm_password_txt = new System.Windows.Forms.TextBox();
            this.confirm_passwordd_lbl = new System.Windows.Forms.Label();
            this.password_tip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // encrpyt_btn
            // 
            this.encrpyt_btn.Location = new System.Drawing.Point(252, 335);
            this.encrpyt_btn.Name = "encrpyt_btn";
            this.encrpyt_btn.Size = new System.Drawing.Size(140, 47);
            this.encrpyt_btn.TabIndex = 0;
            this.encrpyt_btn.Text = "Encrypt/Hide";
            this.encrpyt_btn.UseVisualStyleBackColor = true;
            this.encrpyt_btn.Click += new System.EventHandler(this.encrpyt_btn_Click);
            // 
            // imageFile_lbl
            // 
            this.imageFile_lbl.AutoSize = true;
            this.imageFile_lbl.Location = new System.Drawing.Point(12, 25);
            this.imageFile_lbl.Name = "imageFile_lbl";
            this.imageFile_lbl.Size = new System.Drawing.Size(109, 17);
            this.imageFile_lbl.TabIndex = 1;
            this.imageFile_lbl.Text = "Image File Path:";
            // 
            // imageFile_txt
            // 
            this.imageFile_txt.Location = new System.Drawing.Point(12, 45);
            this.imageFile_txt.Name = "imageFile_txt";
            this.imageFile_txt.Size = new System.Drawing.Size(501, 22);
            this.imageFile_txt.TabIndex = 2;
            // 
            // imageFile_ofd
            // 
            this.imageFile_ofd.FileName = "Image File";
            // 
            // imageFile_btn
            // 
            this.imageFile_btn.Location = new System.Drawing.Point(519, 45);
            this.imageFile_btn.Name = "imageFile_btn";
            this.imageFile_btn.Size = new System.Drawing.Size(114, 23);
            this.imageFile_btn.TabIndex = 3;
            this.imageFile_btn.Text = "Browse";
            this.imageFile_btn.UseVisualStyleBackColor = true;
            this.imageFile_btn.Click += new System.EventHandler(this.imageFile_btn_Click);
            // 
            // inputFile_lbl
            // 
            this.inputFile_lbl.AutoSize = true;
            this.inputFile_lbl.Location = new System.Drawing.Point(12, 91);
            this.inputFile_lbl.Name = "inputFile_lbl";
            this.inputFile_lbl.Size = new System.Drawing.Size(102, 17);
            this.inputFile_lbl.TabIndex = 4;
            this.inputFile_lbl.Text = "Input File Path:";
            // 
            // inputFile_txt
            // 
            this.inputFile_txt.Location = new System.Drawing.Point(12, 111);
            this.inputFile_txt.Name = "inputFile_txt";
            this.inputFile_txt.Size = new System.Drawing.Size(501, 22);
            this.inputFile_txt.TabIndex = 5;
            // 
            // inputFile_ofd
            // 
            this.inputFile_ofd.FileName = "Input File";
            // 
            // inputFile_btn
            // 
            this.inputFile_btn.Location = new System.Drawing.Point(519, 110);
            this.inputFile_btn.Name = "inputFile_btn";
            this.inputFile_btn.Size = new System.Drawing.Size(114, 23);
            this.inputFile_btn.TabIndex = 6;
            this.inputFile_btn.Text = "Browse";
            this.inputFile_btn.UseVisualStyleBackColor = true;
            this.inputFile_btn.Click += new System.EventHandler(this.inputFile_btn_Click);
            // 
            // saveFile_lbl
            // 
            this.saveFile_lbl.AutoSize = true;
            this.saveFile_lbl.Location = new System.Drawing.Point(12, 154);
            this.saveFile_lbl.Name = "saveFile_lbl";
            this.saveFile_lbl.Size = new System.Drawing.Size(103, 17);
            this.saveFile_lbl.TabIndex = 7;
            this.saveFile_lbl.Text = "Save File Path:";
            // 
            // saveFile_txt
            // 
            this.saveFile_txt.Location = new System.Drawing.Point(12, 174);
            this.saveFile_txt.Name = "saveFile_txt";
            this.saveFile_txt.Size = new System.Drawing.Size(501, 22);
            this.saveFile_txt.TabIndex = 8;
            // 
            // saveFile_btn
            // 
            this.saveFile_btn.Location = new System.Drawing.Point(519, 173);
            this.saveFile_btn.Name = "saveFile_btn";
            this.saveFile_btn.Size = new System.Drawing.Size(114, 23);
            this.saveFile_btn.TabIndex = 9;
            this.saveFile_btn.Text = "Browse";
            this.saveFile_btn.UseVisualStyleBackColor = true;
            this.saveFile_btn.Click += new System.EventHandler(this.saveFile_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(12, 234);
            this.password_txt.MaxLength = 50;
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(501, 22);
            this.password_txt.TabIndex = 10;
            this.password_tip.SetToolTip(this.password_txt, "Password must be more than or equal to 6 characters!!");
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(9, 214);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(73, 17);
            this.password_lbl.TabIndex = 11;
            this.password_lbl.Text = "Password:";
            // 
            // confirm_password_txt
            // 
            this.confirm_password_txt.Location = new System.Drawing.Point(12, 297);
            this.confirm_password_txt.MaxLength = 50;
            this.confirm_password_txt.Name = "confirm_password_txt";
            this.confirm_password_txt.PasswordChar = '*';
            this.confirm_password_txt.Size = new System.Drawing.Size(501, 22);
            this.confirm_password_txt.TabIndex = 12;
            this.password_tip.SetToolTip(this.confirm_password_txt, "Passwords must match!!");
            // 
            // confirm_passwordd_lbl
            // 
            this.confirm_passwordd_lbl.AutoSize = true;
            this.confirm_passwordd_lbl.Location = new System.Drawing.Point(12, 277);
            this.confirm_passwordd_lbl.Name = "confirm_passwordd_lbl";
            this.confirm_passwordd_lbl.Size = new System.Drawing.Size(125, 17);
            this.confirm_passwordd_lbl.TabIndex = 13;
            this.confirm_passwordd_lbl.Text = "Confirm Password:";
            // 
            // password_tip
            // 
            this.password_tip.IsBalloon = true;
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 394);
            this.Controls.Add(this.confirm_passwordd_lbl);
            this.Controls.Add(this.confirm_password_txt);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.saveFile_btn);
            this.Controls.Add(this.saveFile_txt);
            this.Controls.Add(this.saveFile_lbl);
            this.Controls.Add(this.inputFile_btn);
            this.Controls.Add(this.inputFile_txt);
            this.Controls.Add(this.inputFile_lbl);
            this.Controls.Add(this.imageFile_btn);
            this.Controls.Add(this.imageFile_txt);
            this.Controls.Add(this.imageFile_lbl);
            this.Controls.Add(this.encrpyt_btn);
            this.Name = "Encrypt";
            this.Text = "Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrpyt_btn;
        private System.Windows.Forms.Label imageFile_lbl;
        private System.Windows.Forms.TextBox imageFile_txt;
        private System.Windows.Forms.OpenFileDialog imageFile_ofd;
        private System.Windows.Forms.Button imageFile_btn;
        private System.Windows.Forms.Label inputFile_lbl;
        private System.Windows.Forms.TextBox inputFile_txt;
        private System.Windows.Forms.OpenFileDialog inputFile_ofd;
        private System.Windows.Forms.Button inputFile_btn;
        private System.Windows.Forms.Label saveFile_lbl;
        private System.Windows.Forms.TextBox saveFile_txt;
        private System.Windows.Forms.Button saveFile_btn;
        private System.Windows.Forms.SaveFileDialog saveFile_sfd;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox confirm_password_txt;
        private System.Windows.Forms.Label confirm_passwordd_lbl;
        private System.Windows.Forms.ToolTip password_tip;
    }
}