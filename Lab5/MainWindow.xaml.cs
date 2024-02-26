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

namespace Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
        }

        private void Button_Click ( object sender, RoutedEventArgs e )
        {
            try
            {
                double a = double.Parse(SideA.Text);
                double b = double.Parse(SideB.Text);
                double c = double.Parse(SideC.Text);
                double x = ( a - b ) / 2;
                double h = Math.Sqrt(c*c-x*x);
                double s = ( a - b ) * h / 2;
                Result.Text = $"Площадь трапеции {s:F2}";
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }

        private void Button_Click_1 ( object sender, RoutedEventArgs e )
        {
            try
            {
                double a = double.Parse(SideA.Text);
                if (a == 0) throw new Exception("Введите сторону A отличную от нуля");
                double b = double.Parse(SideB.Text);
                if (b == 0) throw new Exception("Введите сторону B отличную от нуля");
                double c = double.Parse(SideC.Text);
                if (c == 0) throw new Exception("Введите сторону C отличную от нуля");
                double x = ( a - b ) / 2;
                double h = Math.Sqrt(c * c - x * x);
                double s = ( a - b ) * h / 2;
                Result.Text = $"Площадь трапеции {s:F2}";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Button_Click_2 ( object sender, RoutedEventArgs e )
        {
            try
            {
                double a = double.Parse(SideA.Text);
                if (a == 0) throw new Exception("Введите сторону A отличную от нуля");
                double b = double.Parse(SideB.Text);
                if (b == 0) throw new Exception("Введите сторону B отличную от нуля");
                double c = double.Parse(SideC.Text);
                if (c == 0) throw new Exception("Введите сторону C отличную от нуля");
                double x = ( a - b ) / 2;
                double h = Math.Sqrt(c * c - x * x);
                double s = ( a - b ) * h / 2;
                Result.Text = $"Площадь трапеции {s:F2}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Button_Click_3 ( object sender, RoutedEventArgs e )
        {
            try
            {
                double a = double.Parse(SideA.Text);
                if (a == 0) throw new TrapeciaExeption("Введите сторону A отличную от нуля");
                double b = double.Parse(SideB.Text);
                if (b == 0) throw new TrapeciaExeption("Введите сторону B отличную от нуля");
                double c = double.Parse(SideC.Text);
                if (c == 0) throw new TrapeciaExeption("Введите сторону C отличную от нуля");
                double x = ( a - b ) / 2;
                double h = Math.Sqrt(c * c - x * x);
                double s = ( a - b ) * h / 2;
                Result.Text = $"Площадь трапеции {s:F2}";
            }
            catch (TrapeciaExeption ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}