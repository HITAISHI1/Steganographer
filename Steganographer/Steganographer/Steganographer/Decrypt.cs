using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace Steganographer
{
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
          /*  imageFile_txt.Text = "C:\\Users\\Hitaishi\\Desktop\\b.bmp";
            saveFile_txt.Text = "C:\\Users\\Hitaishi\\Desktop\\b.txt";*/

            if (imageFile_txt.Text == "")                 //if image file path is not provided
            {
                MessageBox.Show("Image file path is empty!!!!!");
                return;
            }

            
            if (saveFile_txt.Text == "")                 //if save folder path is not provided
            {
                MessageBox.Show("Save file path is empty!!!!!");
                return;
            }

            if (password_txt.Text == "")                 //if password is missing 
            {
                MessageBox.Show("Please enter password!!!!!");
                return;
            }

            Bitmap imageFile;
           
            try
            {
                imageFile = (Bitmap)Image.FromFile(imageFile_txt.Text);          //try to open the file and Show error on failure
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Couldn't open Image File");
                return;
            }

            Color pixel = imageFile.GetPixel(0, 0);
          //  MessageBox.Show("" + pixel.R + "  " + pixel.G + "  " + pixel.B);
          //  string s = "12345";
            char[] password = password_txt.Text.ToArray();
            List<Byte> saveFileList = DecryptImage(imageFile);
            Byte[] saveFile = saveFileList.ToArray();


            //File_sfd.Filter = "*.txt";

            /*for(int l=0;l<10;l++)
                MessageBox.Show("" + saveFile[saveFile.Length-l-1]);*/
           // Array.Reverse(saveFile, 0, saveFile.Length);
            /*for (int l = 0; l < password.Length; l++)
                saveFileList.RemoveAt(saveFileList.Count-l-1);*/
            Array.Resize(ref saveFile, saveFile.Length - password.Length);


            int m;
            for (m = saveFile.Length - 1; m >= 0; m--)
            {
                if (((char)saveFile[m] == '.')||((char)saveFile[m] == '\\'))
                {
                    break;
                }
            }
           char[] extension;

                extension = new char[saveFile.Length - m];

                for (int n = m+1, j = 0; n < saveFile.Length; n++, j++)
                {
                    extension[j] = (char)saveFile[n];
                }



                String ext = new String(extension);
            
            Array.Resize(ref saveFile, saveFile.Length - extension.Length);


            File.WriteAllBytes(saveFile_txt.Text,saveFile);

           // foreach (char ch in extension)
          //  {
                MessageBox.Show("Done\n" + "Possible extenion of the decoded file :" + ext);
           // }


        }

        public List<Byte> DecryptImage(Bitmap imageFile)
        {
            Color pixel;                                //for accessing each pixel of the image
            Byte FileByte=0;               //RGB channels of a pixel 
            List<Byte> saveFileList= new List<Byte>();
          //  Byte[] saveFile;
            char[] FileBits=new char[8];
           // string s = "12345";
            char[] password = password_txt.Text.ToArray();
            //int k=0;
            int count = 44;
            bool eof = false;
            for (int i = 0; (i < imageFile.Height); )           //manipulating the bits
            {   
                //i++;
                for (int j = 0; (j < imageFile.Width) ; )
                {
                    pixel = imageFile.GetPixel(j, i);                           //getting pixel
                    FileByte = 0;
                    //MessageBox.Show("" + pixel.R + "  " + pixel.G + "  " + pixel.B);
                    FileByte = GetBits(pixel.R, 0, FileByte);
                    FileByte = GetBits(pixel.G, 1, FileByte);
                    FileByte = GetBits(pixel.B, 2, FileByte);

                    if (j == imageFile.Width - 1) 
                    {
                        j = 0;                          //if the row of pixel is over
                        if (i == imageFile.Height - 1)
                        {
                            eof = true;
                            return saveFileList;
                        }
                        else                          
                            i++;                            //next line first pixel
                    }
                    else
                        j++;                                                //setting the next pixel

                    pixel = imageFile.GetPixel(j, i);
                    //MessageBox.Show("" + pixel.R + "  " + pixel.G + "  " + pixel.B);
                    FileByte = GetBits(pixel.R, 3, FileByte);
                    FileByte = GetBits(pixel.G, 4, FileByte);
                    FileByte = GetBits(pixel.B, 5, FileByte);

                    if (j == imageFile.Width - 1)
                    {
                        j = 0;                          //if the row of pixel is over
                        if (i == imageFile.Height - 1)
                        {
                            eof = true;
                            return saveFileList;
                        }
                        else 
                            i++;                            //next line first pixel
                    }
                    else
                        j++;                                                //setting the next pixel

                    pixel = imageFile.GetPixel(j, i);
                    //MessageBox.Show("" + pixel.R + "  " + pixel.G + "  " + pixel.B);
                    FileByte = GetBits(pixel.R, 6, FileByte);
                    FileByte = GetBits(pixel.G, 7, FileByte);

                    if (j == imageFile.Width - 1)
                    {
                        j = 0;                          //if the row of pixel is over
                        if (i == imageFile.Height - 1)
                        {
                            eof = true;
                            return saveFileList;
                        }
                        else 
                            i++;                            //next line first pixel
                    }
                    else
                        j++; 
                                               //setting the next pixel
                    //MessageBox.Show(""+FileByte);
                    count--;
                    saveFileList.Add(FileByte);
                    bool eof2= CheckEOF(saveFileList.ToArray(), password);
                    if (eof | eof2)
                    {
                        //MessageBox.Show("" + saveFileList.Count);
                        return saveFileList;

                    }

                    //saveFileList.Add(
                }
               // MessageBox.Show("qwertyuiop");

                                
            }
           /* for (int l = 0; l < 10; l++)
                MessageBox.Show("" + saveFileList[saveFileList.Count - l - 1]);*/
            /*for (int l = 0; l < password.Length;l++ ) 
                saveFileList.RemoveAt(saveFileList.Count-l-1);*/
            
            //MessageBox.Show("qwertyuiop");

            return saveFileList;       
        }

        public Byte GetBits(Byte inputPixel,int Index,Byte FileByte)
        {
           // MessageBox.Show("" + inputPixel);
            //MessageBox.Show("" + FileByte+" 1");
            FileByte <<= 1;
           // MessageBox.Show("" + FileByte+"   2");
            char[] a = (Convert.ToString(inputPixel, 2).PadLeft(8, '0')).ToCharArray();
            if (a[7] == '0')
            {
               // MessageBox.Show("" + FileByte+"   3");
                return FileByte;
            }
            else
            {
                int y = (int)FileByte + 1;
                // MessageBox.Show("" + y);
                // MessageBox.Show("" + FileByte + "  " + Index +"   "+ (2 ^ Index));
             //   MessageBox.Show("" + (Byte)y + "   4");
                return (Byte)y;
            }
        }

        public bool CheckEOF(Byte[] File,char[] password)
        {
            if (File.Length < password.Length)
                return false;
            else
            {
                for (int i = File.Length-1, j = password.Length-1;(i>=0)&&(j >=0) ; i--, j--)
                {
                    if (password[j] != (char)File[i])
                        return false;
                }
                return true;
            }
        }

        private void imageFile_btn_Click(object sender, EventArgs e)
        {
            if(imageFile_ofd.ShowDialog()==DialogResult.OK)
                try
                {
                    imageFile_txt.Text = imageFile_ofd.FileName;
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Couldn't open Image File");
                    return;
                }
        }

        private void saveFile_btn_Click(object sender, EventArgs e)
        {
            if (File_sfd.ShowDialog() == DialogResult.OK)
                try
                {
                    saveFile_txt.Text = File_sfd.FileName;
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Couldn't save File");
                    return;
                }
        }
    }
}
