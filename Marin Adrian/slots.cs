using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Curs_10_CSharp_graph_pacanele
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //probabilitatea este de 1000 de numere posibile (total de numere) impartit la cazuri favorabile 10
        private void Startbutton_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int currentvalue1 =  r.Next(10);
            number1.Content = Convert.ToString(currentvalue1);
            int currentvalue2 =  r.Next(10);
            number2.Content = Convert.ToString(currentvalue2);
            int currentvalue3 =  r.Next(10);
            number3.Content = Convert.ToString(currentvalue3);

            if(currentvalue1 == 0 && currentvalue2 == 0 && currentvalue3 == 0)
            {                
                ShowResult.Content = "You won the third prize";
                return;
            }

            if (currentvalue1 == currentvalue2 && currentvalue1 == currentvalue3)
            {
                ShowResult.Foreground = Brushes.Blue;
                ShowResult.Background = Brushes.Red;
                ShowResult.Content = "You won the big prize";
            }
            else
                if (currentvalue1 == currentvalue2 || currentvalue1 == currentvalue3 || currentvalue2 == currentvalue3)
            {
                ShowResult.Foreground = Brushes.Yellow;
                ShowResult.Background = Brushes.Green;
                ShowResult.Content = "You won the second prize";
            }

            else
            {
                ShowResult.Foreground = Brushes.Black;
                ShowResult.Background = Brushes.DimGray;
                ShowResult.Content = "Try again";
            }
        }
    }
}
