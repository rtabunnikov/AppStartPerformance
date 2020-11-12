using System.Windows.Forms;

namespace DXRichEditRuntime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ribbon = this.richEditControl1.CreateRibbon(DevExpress.XtraRichEdit.RichEditToolbarType.All);
            this.Controls.Add(ribbon);
        }

        void Form1_Shown(object sender, System.EventArgs e)
        {
            this.Invalidate(true);
            this.Update();
            this.Close();
        }
    }
}
