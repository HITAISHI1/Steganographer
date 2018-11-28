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
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
            
        }




        private void encrpyt_btn_Click(object sender, EventArgs e)
        {
         /*   imageFile_txt.Text = "C:\\Users\\Hitaishi\\Desktop\\New Folder\\12345.jpg";
            inputFile_txt.Text = "C:\\Users\\Hitaishi\\Desktop\\New Folder\\igv.txt";
            saveFile_txt.Text = "C:\\Users\\Hitaishi\\Desktop\\b";*/

            if (imageFile_txt.Text == "")                 //if image file path is not provided
            {
                MessageBox.Show("Image file path is empty!!!!!");
                return;
            }

            if (inputFile_txt.Text == "")                 //if input file path is not provided
            {
                MessageBox.Show("Input file path is empty!!!!!");
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

            if (confirm_password_txt.Text == "")                 //if confirm password is missing
            {
                MessageBox.Show("Please enter password again in Confirm Password !!!!!");
                return;
            }

            if (password_txt.Text.Length <= 5)                 //if password is too short
            {
                MessageBox.Show("Password is too short!!!!!");
                return;
            }

            if (/*String.Compare(*/password_txt.Text!=confirm_password_txt.Text/*)==0*/)                 //if passwords don't match
            {
                MessageBox.Show("Passwords and confirm password don't match!!!!!");
                return;
            }

            Bitmap imageFile;
            Byte[] inputFile;


            try
            {
                imageFile = (Bitmap)Image.FromFile(imageFile_txt.Text);          //try to open the file and Show error on failure
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Couldn't open Image File");
                return;
            }

           // imageFile.Save(saveFile_txt.Text + "a.jpeg");

            try
            {
                inputFile = File.ReadAllBytes(inputFile_txt.Text);        //try to open the file and Show error on failure

            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Couldn't open the File to be Hidden");
                return;
            }

            if(((imageFile.Height)*(imageFile.Width))<((inputFile.Length+10+50)*3))
            {
                MessageBox.Show("Input File to big!!!!!!!!");
                return;
            }
            //MessageBox.Show(""+((imageFile.Height - 1) * (imageFile.Width - 1))+"  "+ ((inputFile.Length + 10 + 50) / 3));
            int m;
            for (m = inputFile_txt.Text.Length - 1; m >= 0; m--)
            {
                if (inputFile_txt.Text[m] == '.')
                    {
                        break;
                    }
            }

            

             //string ext;
            //extension.CopyTo(
          //ext.CopyTo(m,inputFile_txt.Text.ToCharArray, 0, inputFile_txt.Text.Length - m); 
             //inputFile_txt.Text.CopyTo(m, ext.ToCharArray(), 0, inputFile_txt.Text.Length - m);
            char[] extension; 
            if (m > 0)
            {
                 extension= new char[inputFile_txt.Text.Length - m];

                for (int n = m, j = 0; n < inputFile_txt.Text.Length; n++, j++)
                {
                    extension[j] = inputFile_txt.Text[n];
                }
            }
            else
            {
                extension = new char[1];
                extension[0] = '.';

            }

           // MessageBox.Show(extension+"");
            scramble(inputFile, password_txt.Text);
            //File.WriteAllBytes(saveFile_txt.Text + "a.txt", inputFile);
            Bitmap modifiedImage = EncryptImage(imageFile, inputFile,password_txt.Text,extension);
           
           // saveFile_sfd.Filter = "Images|*.bmp";
           // System.Drawing.Imaging.ImageFormat format=System.Drawing.Imaging.ImageFormat.Bmp;
            Color pixel = modifiedImage.GetPixel(0, 0);
           // MessageBox.Show("" + pixel.R + "  " + pixel.G + "  " + pixel.B);
           // Image experimental = (Image)modifiedImage;
            //experimental.Save(saveFile_txt.Text + "halu.jpeg");
            modifiedImage.Save(saveFile_txt.Text + ".bmp",System.Drawing.Imaging.ImageFormat.Bmp);
           

            MessageBox.Show("Done");
        }

        public void scramble(Byte[] inputFile,String pwd)
        {
            char[] temp_pwd=new char[pwd.Length];
            pwd.CopyTo(0, temp_pwd, 0, pwd.Length);
            int[] order = new int[pwd.Length];
            
            for (int i = 0; i < pwd.Length; i++)
                order[i] = i;
            for(int i=0;i<pwd.Length;i++)
                for (int j = 0; j < pwd.Length - 1; j++)
                {
                    if (temp_pwd[j] > temp_pwd[j + 1])
                    {
                        char temp1=temp_pwd[j];
                        temp_pwd[j]=temp_pwd[j+1];
                        temp_pwd[j + 1] = temp1;

                        int temp2 = order[j];
                        order[j] = order[j + 1];
                        order[j + 1] = temp2;
                    }

                }

            Byte[] buffer = new Byte[pwd.Length];
            for (int i = 0; i < inputFile.Length-pwd.Length; i += pwd.Length)
            {
                for (int k = 0; k < pwd.Length; k++)
                {
                    buffer[k] = inputFile[i + k];
                }

                for (int j = 0; j < pwd.Length; j++)
                {
                    int l;
                    for (l = 0; l < pwd.Length; l++)
                    {
                        if (order[l] == j)
                            break;
                    }

                    inputFile[i+j] = buffer[l];
                }
            }
            
        }

        public Bitmap EncryptImage(Bitmap imageFile, Byte[] rawInputFile, String pwd, char[] ext)
        {
            Bitmap modifiedImage = imageFile;           //modified image file
            Color pixel=Color.Black;                                //for accessing each pixel of the image
            Byte[] channel=new Byte [3];                //RGB channels of a pixel 
                    //file size
            int i,j;

            Byte[] password = Encoding.ASCII.GetBytes(pwd);
            Byte[] extension = Encoding.ASCII.GetBytes(ext);
            List<Byte> l1 = new List<Byte>(rawInputFile);
            List<Byte> l2 = new List<Byte>(extension);
            List<Byte> l3 = new List<Byte>(password);

            l1.AddRange(l2);
            l1.AddRange(l3);

            Byte[] inputFile = l1.ToArray();
            //Array.Reverse(inputFile, 0, inputFile.Length);

            int inputFileBytes =0 ;

            for( i=0;(i<modifiedImage.Height)&&(inputFileBytes<inputFile.Length);)           //manipulating the bits
            {
                for (j = 0; (j < modifiedImage.Width)&&(inputFileBytes<inputFile.Length); )
                {
                    /*if(inputFileBytes<10)
                        MessageBox.Show("" + inputFile[inputFileBytes]);*/

                    //pixel = modifiedImage.GetPixel(j,i);                           //getting pixel
                   // try
                   // {
                        pixel = modifiedImage.GetPixel(j, i);                           //getting pixel 
                   // }
                   /* catch
                    {
                        MessageBox.Show("i=" + i + "j=" + j);
                    }*/
                    channel[0] = WriteByte(inputFile[inputFileBytes], pixel.R, 0);
                    channel[1] = WriteByte(inputFile[inputFileBytes], pixel.G, 1);      //modifying each channel
                    channel[2] = WriteByte(inputFile[inputFileBytes], pixel.B, 2);


                   // MessageBox.Show("" + channel[0] + "  " + channel[1] + "  " + channel[2]); 
                   modifiedImage.SetPixel(j, i,Color.FromArgb(channel[0],channel[1],channel[2]));       //setting the pixel
                   
                    if (j == modifiedImage.Width - 1)
                    {
                        j = 0;                          //if the row of pixel is over
                        i++;                            //next line first pixel
                    }
                    else
                        j++;                                                //setting the next pixel

                    pixel = modifiedImage.GetPixel(j, i);

                    
                    channel[0] = WriteByte(inputFile[inputFileBytes], pixel.R, 3);                  
                    channel[1] = WriteByte(inputFile[inputFileBytes], pixel.G, 4);
                    channel[2] = WriteByte(inputFile[inputFileBytes], pixel.B, 5);
                  //  MessageBox.Show("" + channel[0] + "  " + channel[1] + "  " + channel[2]); 
                    modifiedImage.SetPixel(j, i, Color.FromArgb(channel[0], channel[1], channel[2]));

                    

                    if (j == modifiedImage.Width - 1)
                    {
                        j = 0;                          //if the row of pixel is over
                        i++;                            //next line first pixel
                    }
                    else
                        j++;

                    pixel = modifiedImage.GetPixel(j, i);

                    channel[0] = WriteByte(inputFile[inputFileBytes], pixel.R, 6);
                    channel[1] = WriteByte(inputFile[inputFileBytes], pixel.G, 7);
                    //MessageBox.Show("" + channel[0] + "  " + channel[1] + "  " + pixel.B); 
                    modifiedImage.SetPixel(j, i, Color.FromArgb(channel[0], channel[1], pixel.B));

                    inputFileBytes++;

                    if (j == modifiedImage.Width - 1)
                    {
                        //if(i==modifiedImage.Height-1)
                           // MessageBox.Show("i=" + i + "j=" + j + "  " + inputFileBytes + "  " + inputFile.Length);
                        j = 0;                          //if the row of pixel is over
                        i++;                            //next line first pixel
                    }
                    else
                        j++;                    
                }
        }
            //MessageBox.Show("" + inputFile.Length);
        return modifiedImage;
 }



        public Byte WriteByte(Byte inputFileByte, Byte ImageByte, int position)
        {
            
            //MessageBox.Show("" + inputFileByte);
            //char[] a = (Convert.ToString(ImageByte, 2).PadLeft(8, '0')).ToCharArray();
            char[] b = (Convert.ToString(inputFileByte, 2).PadLeft(8, '0')).ToCharArray();      //coverting byte->string->char array
            //MessageBox.Show("" + b[0] + b[1] + b[2] + b[3] + b[4] + b[5] + b[6] + b[7]);
            //MessageBox.Show("" + ImageByte);
            //a[7] = b[position];                 //setting the byte
            //string x = Convert.ToString(ImageByte, 2).PadLeft(8, '0');

            //int y = Convert.ToInt16(x);
            //MessageBox.Show("" + y);
            if (b[position] == '1')
            {
                if ((ImageByte % 2) == 0)
                    ImageByte += 1;
            }

            else
            {
                if ((ImageByte % 2) == 1)
                    ImageByte -= 1;
            }

            //MessageBox.Show("" + inputFileByte);       
             
           // MessageBox.Show("" + a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7]);
            //string c = a.ToString();
            //Byte[] d = Encoding.ASCII.GetBytes(a);
           // MessageBox.Show("" + ImageByte);
            //return d[0];
            return ImageByte;

        }

        private void imageFile_btn_Click(object sender, EventArgs e)
        {
            if (imageFile_ofd.ShowDialog() == DialogResult.OK)
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

        private void inputFile_btn_Click(object sender, EventArgs e)
        {
            if (inputFile_ofd.ShowDialog() == DialogResult.OK)
                try
                {
                    inputFile_txt.Text = inputFile_ofd.FileName;
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Couldn't open Input File");
                    return;
                }
        }

        private void saveFile_btn_Click(object sender, EventArgs e)
        {
            if (saveFile_sfd.ShowDialog() == DialogResult.OK)
                try
                {
                    saveFile_txt.Text = saveFile_sfd.FileName;
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Couldn't save File");
                    return;
                }
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
