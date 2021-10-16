using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            folder.ShowDialog();
           
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string path = folder.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(path);
                List<ListViewItem> ListViewItemFiles = new List<ListViewItem>();
                List<FileInfo> ListOfFiles = di.GetFiles("*.*", SearchOption.TopDirectoryOnly).ToList();

                foreach (FileInfo directory in ListOfFiles)
                {
                    ListViewItemFiles.Add(new ListViewItem() { Names = directory.Name, Type = (directory.GetType()).ToString(), LastChange = directory.LastAccessTime });
                   
                }
                

                foreach (ListViewItem files in ListViewItemFiles)
                {
                    listView1.Items.Add(files.Names);
                    listView1.Items[0].SubItems.Add(files.Type);
                    listView1.Items[0].SubItems.Add((files.LastChange).ToString());
                    //listView1.Columns.Add(files.Type);
                    //listView1.Columns.Add((files.LastChange).ToString());

                }
            }

            
            
        }
    }
}
