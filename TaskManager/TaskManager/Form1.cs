using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private List<Process> processes;
        public Form1()
        {
            InitializeComponent();
        }


        private void btStart_Click(object sender, EventArgs e)
        {
           
            processes = Process.GetProcesses().ToList<Process>();
            listView1.Items.Clear();
            
            
               foreach (Process p in processes)
                {
                try
                {
                    string[] row = new string[] { p.Id.ToString(), p.ProcessName.ToString(), p.StartTime.ToString(), p.Threads.Count.ToString(), p.TotalProcessorTime.ToString() };
                    listView1.Items.Add(new ListViewItem(row));
                }
                catch { }

                }
           
        }

        private void btStoptProcName_Click(object sender, EventArgs e)
        {
            processes = Process.GetProcesses().ToList<Process>();
            foreach (Process p in processes)
            {
                if (p.ProcessName.ToString() == textBox1.Text)
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }

                }
                    
                    
            }

        }

        private void btStopProcID_Click(object sender, EventArgs e)
        {
           
                processes = Process.GetProcesses().ToList<Process>();
                foreach (Process p in processes)
                {
                    if (p.Id.ToString() == textBox1.Text)
                    {
                        try
                        {
                            p.Kill();
                        }
                        catch { }

                    }


                }

            
        }

        private void btStartProcName_Click(object sender, EventArgs e)
        {
            //Process pr = new Process();
            string proc = textBox1.Text;
            try 
            {
                Process.Start(proc);
            }

            catch { }
        }
    }
}
