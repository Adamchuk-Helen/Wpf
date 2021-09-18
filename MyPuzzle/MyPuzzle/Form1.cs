using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPuzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox [] pb = new PictureBox [16];
            int y = 0;

            
            for (int i = 0; i<16; i++)
            {
                if (i < 4)
                {
                    PictureBox pb1 = new PictureBox();
                    pb1.Location = new Point(pb1.Location.X + (i * 90), pb1.Location.Y + y);
                    pb1.BorderStyle = BorderStyle.Fixed3D;
                    pb1.Name = "pbox" + i;
                    pb1.Height = 90;
                    pb1.Width = 90;
                    pb1.AllowDrop = true;
                    pb1.DragDrop += new DragEventHandler(pictureBox17_DragDrop);
                    pb1.DragDrop += new DragEventHandler(pictureBox17_DragEnter);
                    pb1.MouseDown += pictureBox1_MouseDown;
                    pb[i] = pb1;
                    Controls.AddRange(pb);
                }
                else if (i >= 4 && i < 8)
                {
                    y = 90;
                    PictureBox pb1 = new PictureBox();
                    pb1.Location = new Point(pb1.Location.X + (i * 90)-360, pb1.Location.Y + y);
                    pb1.BorderStyle = BorderStyle.Fixed3D;
                    pb1.Name = "pbox" + i;
                    pb1.Height = 90;
                    pb1.Width = 90;
                    pb1.AllowDrop = true;
                    pb1.DragDrop += pictureBox17_DragDrop;
                    pb1.DragDrop += pictureBox17_DragEnter;
                    pb[i] = pb1;
                    Controls.AddRange(pb);
                }
                else if (i >= 8 && i < 12)
                {
                    y = 180;
                    PictureBox pb1 = new PictureBox();
                    pb1.Location = new Point(pb1.Location.X + (i * 90) - 720, pb1.Location.Y + y);
                    pb1.BorderStyle = BorderStyle.Fixed3D;
                    pb1.Name = "pbox" + i;
                    pb1.Height = 90;
                    pb1.Width = 90;
                    pb1.AllowDrop = true;
                    pb1.DragDrop += pictureBox17_DragDrop;
                    pb1.DragDrop += pictureBox17_DragEnter;
                    pb[i] = pb1;
                    Controls.AddRange(pb);
                }
                else if (i >= 12 && i < 16)
                {
                    y = 270;
                    PictureBox pb1 = new PictureBox();
                    pb1.Location = new Point(pb1.Location.X + (i * 90) - 1080, pb1.Location.Y + y);
                    pb1.BorderStyle = BorderStyle.Fixed3D;
                    pb1.Name = "pbox" + i;
                    pb1.Height = 90;
                    pb1.Width = 90;
                    pb1.AllowDrop = true;
                    pb1.DragDrop += pictureBox17_DragDrop;
                    pb1.DragDrop += pictureBox17_DragEnter;
                    pb[i] = pb1;
                    Controls.AddRange(pb);
                }

                


            }
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox14.AllowDrop = true;
            pictureBox15.AllowDrop = true;
            pictureBox16.AllowDrop = true;

        }

        private void Pb1_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_DragDrop(object sender, DragEventArgs e)
        {
            var pb = sender as PictureBox;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
        }

        private void pictureBox17_DragEnter(object sender, DragEventArgs e)
        {

        
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Move) != 0)
            {
                e.Effect = DragDropEffects.Move;
            }
            else 
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var myPB = sender as PictureBox;
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileName = data as string[];
                if (fileName.Length > 0)
                {
                    myPB.Image = Image.FromFile(fileName[0]);
                }
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var pbox = sender as PictureBox;
            if (e.Button == MouseButtons.Left)
            {
                pbox.DoDragDrop(pbox.Image, DragDropEffects.Move);
            }
        }
    }
}
