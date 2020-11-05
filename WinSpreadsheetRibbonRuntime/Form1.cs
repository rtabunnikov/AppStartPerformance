using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSpreadsheetRibbonRuntime {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            var ribbon = spreadsheetControl1.CreateRibbon();
            ribbon.Parent = this;
            ribbon.Dock = DockStyle.Top;
            var sb = spreadsheetControl1.CreateRibbonStatusBar(ribbon);
            sb.Parent = this;
            sb.Dock = DockStyle.Bottom;
            spreadsheetControl1.Dock = DockStyle.Fill;
        }

        private void Form1_Shown(object sender, EventArgs e) {
            Close();
        }
    }
}
