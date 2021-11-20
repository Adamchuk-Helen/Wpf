using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FileLibrary;


namespace WindowForDll
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenDirClick(object sender, RoutedEventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                string path = fbd.SelectedPath;

                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lbItemsDir.Items.Clear();
                    var file = Directory.GetDirectories(path);

                    foreach (var fi in file)
                    {
                        string name = System.IO.Path.GetFileName(System.IO.Path.GetFileName(fi));
                        lbItemsDir.Items.Add(name);

                    }
                }
                tbPathDir.Text = path;
            }
        }



        private void OpenFileClick(object sender, RoutedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                string path = fbd.SelectedPath;

                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lbItems.Items.Clear();
                    var file = Directory.GetFiles(path);

                    foreach (var fi in file)
                    {
                        string name = System.IO.Path.GetFileName(System.IO.Path.GetFileName(fi));
                        lbItems.Items.Add(name);

                    }
                }
                tbPath.Text = path;
            }
        }


        private void copySelectedFile(object sender, RoutedEventArgs e)
        {
            try
            {
                string path1 = tbPath.Text + "\\" + lbItems.SelectedItem;
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    string path2 = fbd.SelectedPath + "\\" + lbItems.SelectedItem;
                    try
                    {
                        FileLibrary.Files.copyFile(path1, path2);
                     
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show("File already exists");
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

        }

        private void moveSelectedFile(object sender, RoutedEventArgs e)
        {
            string path1 = tbPath.Text + "\\" + lbItems.SelectedItem;
            try
            {

                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    string path2 = fbd.SelectedPath + "\\" + lbItems.SelectedItem;
                    try
                    {
                        FileLibrary.Files.moveFile(path1, path2);
                       

                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show("File already exists");
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }



        public static void copyFile(string path1, string path2)
        {
            System.IO.File.Copy(path1, path2, true);
        }



        private void deletedFileByName(object sender, RoutedEventArgs e)
        {
            var file = Directory.GetFiles(tbPath.Text);

            foreach (var fi in file)
            {
                string name = System.IO.Path.GetFileName(System.IO.Path.GetFileName(fi));
                if (name.StartsWith(tbFileName.Text))
                {
                    string path = tbPath.Text + "\\" + name;
                    FileLibrary.Files.delFileByName(path);
                }

            }

            System.Windows.MessageBox.Show("File delited");
            tbFileName.Clear();
            refreshList();


        }

        private void refreshList()
        {
            string path = tbPath.Text;
            lbItems.Items.Clear();
            var file = Directory.GetFiles(path);

            foreach (var fi in file)
            {
                string name = System.IO.Path.GetFileName(System.IO.Path.GetFileName(fi));
                lbItems.Items.Add(name);

            }

        }

        private void deletedFileByMask(object sender, RoutedEventArgs e)
        {
            var file = Directory.GetFiles(tbPath.Text);

            foreach (var fi in file)
            {
                string name = System.IO.Path.GetFileName(System.IO.Path.GetFileName(fi));
                if (name.EndsWith(tbFileMask.Text))
                {
                    string path = tbPath.Text + "\\" + name;
                    FileLibrary.Files.delFileByName(path);
                }

            }

            System.Windows.MessageBox.Show("File delited");
            tbFileMask.Clear();
            refreshList();
        }

        private void copySelectedDir(object sender, RoutedEventArgs e)
        {
            try
            {
                string path1 = tbPathDir.Text + "\\" + lbItemsDir.SelectedItem;
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    string path2 = fbd.SelectedPath + "\\" + lbItemsDir.SelectedItem;
                    try
                    {
                        FileLibrary.Files.copyDir(path1, path2);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show("File already exists");
                    }

                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
    }
}
