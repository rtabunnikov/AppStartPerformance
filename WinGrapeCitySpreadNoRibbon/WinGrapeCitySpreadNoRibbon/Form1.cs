using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGrapeCitySpreadNoRibbon
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        Thread thread;

        public Form1()
        {
            thread = new Thread(new ThreadStart(KillLic));
            thread.Start();
            sw.Start();
            InitializeComponent();
        }

        void KillLic()
        {
            while (true)
            {
                var proc = Process.GetProcesses().Where(x => x.MainWindowTitle.Contains("About"));
                foreach (var process in proc)
                {
                    try
                    {
                        process.CloseMainWindow();
                    }
                    catch { }
                }
                Thread.Sleep(50);

            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Invalidate();
            Update();
            sw.Stop();
            MessageBox.Show(sw.Elapsed.TotalMilliseconds.ToString());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread.Abort();
        }
    }
}
