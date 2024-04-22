using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace Lab10_11
{
    /// <summary>
    /// Логика взаимодействия для Lab10.xaml
    /// </summary>
    public partial class Lab10 : Page
    {
        public Lab10()
        {
            InitializeComponent();
        }
        private void Create()
        {
            tbEdit.Text = "";
        }
        private async void Open()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt";
            if (ofd.ShowDialog() == true)
            {
                using (StreamReader reader = new StreamReader(ofd.FileName))
                {
                    tbEdit.Text = await reader.ReadToEndAsync();
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Open();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Open();
        }
    }
}
