using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Point_of_Sale
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Opa();
        }

        public void Opa()
        {
            p4.Opacity = 0.5;
            p5.Opacity = 0.5;
            p6.Opacity = 0.5;
            p7.Opacity = 0.5;
            p8.Opacity = 0.5;
            p9.Opacity = 0.5;

        }

        private void p1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            p1.Opacity = 0.5;
            p2.Opacity = 0.5;
            p3.Opacity = 0.5;
            p4.Opacity = 1;
            p5.Opacity = 1;
            p6.Opacity = 1;

        }
        private void p2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            p1.Opacity = 0.5;
            p2.Opacity = 0.5;
            p3.Opacity = 0.5;
            p4.Opacity = 1;
            p5.Opacity = 1;
            p6.Opacity = 1;

        }
        private void p3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            p1.Opacity = 0.5;
            p2.Opacity = 0.5;
            p3.Opacity = 0.5;
            p4.Opacity = 1;
            p5.Opacity = 1;
            p6.Opacity = 1;

        }

        private void p4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            p4.Opacity = 0.5;
            p5.Opacity = 0.5;
            p6.Opacity = 0.5;
            p7.Opacity = 1;
            p8.Opacity = 1;
            p9.Opacity = 1;

        }

        private void p5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            p4.Opacity = 0.5;
            p5.Opacity = 0.5;
            p6.Opacity = 0.5;
            p7.Opacity = 1;
            p8.Opacity = 1;
            p9.Opacity = 1;
        }

        private void p6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            p4.Opacity = 0.5;
            p5.Opacity = 0.5;
            p6.Opacity = 0.5;
            p7.Opacity = 1;
            p8.Opacity = 1;
            p9.Opacity = 1;
        }

        private void p7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            p7.Opacity = 0.5;
            p8.Opacity = 0.5;
            p9.Opacity = 0.5;
        }

        private void p8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            p7.Opacity = 0.5;
            p8.Opacity = 0.5;
            p9.Opacity = 0.5;
        }

        private void p9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            p7.Opacity = 0.5;
            p8.Opacity = 0.5;
            p9.Opacity = 0.5;
        }
    }
}