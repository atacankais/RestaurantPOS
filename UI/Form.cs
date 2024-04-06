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
            p1.BackColor = Color.FromArgb(1, 1, 1); // En nästan helt transparent nyans av svart

            // Ange TransparencyKey-egenskapen för PictureBox för att simulera opacitet
            p1.TransparencyKey = p1.BackColor;

        }

    }
}
