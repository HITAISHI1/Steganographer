using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganographer
{
    public partial class Steganographer : Form
    {
        public Steganographer()
        {
            InitializeComponent();
        }

        private void Steganographer_Load(object sender, EventArgs e)
        {

        }

        private void encrypt_btn_Click(object sender, EventArgs e)
        {
            Encrypt encryptDialog=new Encrypt();
            Hide();
            encryptDialog.ShowDialog();
            Show();
            encryptDialog.Dispose();
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
            Decrypt decryptDialog = new Decrypt();
            Hide();
            decryptDialog.ShowDialog();
            Show();
            decryptDialog.Dispose();
        }
    }
}
