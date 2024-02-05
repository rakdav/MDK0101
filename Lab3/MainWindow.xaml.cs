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

namespace Lab3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Fraction f1 = new Fraction()
            {
                First = long.Parse(FirstOne.Text),
                Second = ushort.Parse(SecondOne.Text)
            };
            Fraction f2 = new Fraction()
            {
                First = long.Parse(FirstTwo.Text),
                Second = ushort.Parse(SecondTwo.Text)
            };
            Fraction res = f1 + f2;
            Result.Text = res.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Fraction f1 = new Fraction()
            {
                First = long.Parse(FirstOne.Text),
                Second = ushort.Parse(SecondOne.Text)
            };
            Fraction f2 = new Fraction()
            {
                First = long.Parse(FirstTwo.Text),
                Second = ushort.Parse(SecondTwo.Text)
            };
            Fraction res = f1 - f2;
            Result.Text = res.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Fraction f1 = new Fraction()
            {
                First = long.Parse(FirstOne.Text),
                Second = ushort.Parse(SecondOne.Text)
            };
            Fraction f2 = new Fraction()
            {
                First = long.Parse(FirstTwo.Text),
                Second = ushort.Parse(SecondTwo.Text)
            };
            Fraction res = f1 * f2;
            Result.Text = res.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Fraction f1 = new Fraction()
            {
                First = long.Parse(FirstOne.Text),
                Second = ushort.Parse(SecondOne.Text)
            };
            Fraction f2 = new Fraction()
            {
                First = long.Parse(FirstTwo.Text),
                Second = ushort.Parse(SecondTwo.Text)
            };
            Result.Text = (f1==f2).ToString();
        }
    }
}