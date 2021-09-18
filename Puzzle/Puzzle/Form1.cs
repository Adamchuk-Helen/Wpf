using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Move);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            var img = sender as PictureBox;
            e.Effect = DragDropEffects.Move;
            img.Image = null;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            //var img = e.Data.GetData(DataFormats.FileDrop);
            //if (img != null)
            //{
            //    var FileNames = img as string[];
            //    if (FileNames.Length > 0)
            //    {
            //        pictureBox1.Image = Image.FromFile(FileNames[0]);
            //    }
            //}

            pictureBox1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
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
    }
}
