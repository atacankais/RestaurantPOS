using System.Windows.Forms;

namespace UI
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            Opa();
        }

        public void Opa()
        {
            p1.BackColor = Color.FromArgb(1, 1, 1); // En n�stan helt transparent nyans av svart

            // Ange TransparencyKey-egenskapen f�r PictureBox f�r att simulera opacitet
            p1.TransparencyKey = p1.BackColor;

        }

    }
}
