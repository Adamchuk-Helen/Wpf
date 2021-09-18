using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class PazzleForm : Form
    {
        public PazzleForm()
        {
            InitializeComponent();

            List<PictureBox> pb = new List<PictureBox>();
            pb.Add(PictureBox);

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void myPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void myPictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            var mypb = sender as MyPictureBox;
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data !=null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    mypb.Image = Image.FromFile(fileNames[0]);
                }
            }

        }
    }
    
}
