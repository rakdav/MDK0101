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

namespace Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AndArray arrayAnd;
        private OrArray arrayOr;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            arrayAnd = new AndArray(int.Parse(FirstSize.Text));
            arrayOr = new OrArray(int.Parse(FirstSize.Text));
            ResFirst.Text += arrayAnd.Print();
            ResFirst.Text += "\n";
            ResFirst.Text += arrayOr.Print();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (IsAndArray.IsChecked == true)
            {
                ResFirst.Text += "\n";
                ResFirst.Text += arrayAnd.Add(arrayOr);
            }
            else if (IsOrArray.IsChecked == true)
            {
                ResFirst.Text += "\n";
                ResFirst.Text += arrayOr.Add(arrayAnd);
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (IsAndArray.IsChecked == true)
            {
                ResFirst.Text += "\n";
                ResFirst.Text += arrayAnd.Foreach();
            }
            else if (IsOrArray.IsChecked == true)
            {
                ResFirst.Text += "\n";
                ResFirst.Text += arrayOr.Foreach();
            }
        }
    }
}