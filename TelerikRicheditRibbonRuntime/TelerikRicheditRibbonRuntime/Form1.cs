using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelerikRicheditRibbonRuntime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var richTextEditorRibbonBar1 = new Telerik.WinControls.UI.RichTextEditorRibbonBar();
            richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
            richTextEditorRibbonBar1.AssociatedRichTextEditor = this.radRichTextEditor1;
            richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013;
            richTextEditorRibbonBar1.EnableKeyMap = false;
            this.Controls.Add(richTextEditorRibbonBar1);
        }

        private void Form1_Shown(object sender, EventArgs e) {
            this.Invalidate(true);
            this.Update();
            this.Close();
        }
    }
}
