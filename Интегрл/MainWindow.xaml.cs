using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Data;
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
using System.Xaml.Permissions;

namespace Интегрл
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static double Function(double x, double y, string formul)
        {
            string x1 = $"{x}";
            string y1 = $"{x}";
            string zam = formul.Replace("x", x1);
            zam = zam.Replace("y", y1);
            double value = Convert.ToDouble( new DataTable().Compute(zam, null));  

            return value;
        }

        static double DoubleIntegral(double a1, double b1, double a2, double b2, int n1, int n2, string formul)
        {
            double h1 = (b1 - a1) / n1;
            double h2 = (b2 - a2) / n2;
            double sum = 0;

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    double x = a1 + i * h1 + h1 / 2;
                    double y = a2 + j * h2 + h2 / 2;
                    sum += Function(x, y, formul) * h1 * h2;
                }
            }

            return sum;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string formul = InputF.Text;

            double x1 = Convert.ToDouble(Inputx1.Text);
            double x2 = Convert.ToDouble(Inputx2.Text);
            double y1 = Convert.ToDouble(Inputy1.Text);
            double y2 = Convert.ToDouble(Inputy2.Text);

            double rez = DoubleIntegral(x1, x2, y2, y1, 100, 100, formul);
            ReturnResult.Text = Convert.ToString(rez);

        }
    }
}
