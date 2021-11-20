using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLibrary
{
    public class Files
    {
        public static int Math(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public static void copyFile(string path1, string path2)
        {
            System.IO.File.Copy(path1, path2, true);
        }


        public static void moveFile(string path1, string path2)
        {
            System.IO.File.Move(path1, path2);
        }

        public static void delFileByName(string path)
        {


            if (System.IO.File.Exists(path))
            {
                try
                {
                    System.IO.File.Delete(path);
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }


        }

        public static void copyDir(string path1, string path2)
        {
            DirectoryInfo dir = new DirectoryInfo(path1);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + path1);
            }
            DirectoryInfo[] dirs = dir.GetDirectories();

            Directory.CreateDirectory(path2);

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = System.IO.Path.Combine(path2, file.Name);
                file.CopyTo(tempPath, false);
            }
        }
    }
}
