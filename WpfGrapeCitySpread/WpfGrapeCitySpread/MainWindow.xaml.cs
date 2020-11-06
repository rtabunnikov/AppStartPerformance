using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGrapeCitySpread
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stopwatch sw = new Stopwatch();
        Thread thread;

        public MainWindow()
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sw.Stop();
            this.Title = sw.Elapsed.TotalMilliseconds.ToString();
            thread.Abort();
        }
    }
}
