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

namespace Lab10_11
{
    /// <summary>
    /// Логика взаимодействия для Lab11.xaml
    /// </summary>
    public partial class Lab11 : Page
    {
        private List<Film> films;
        public Lab11()
        {
            InitializeComponent();
            films = new List<Film>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Days> days = new List<Days>();
            if (Sun.IsChecked == true) days.Add(Days.Sunday);
            if (Mon.IsChecked == true) days.Add(Days.Monday);
            if (Thu.IsChecked == true) days.Add(Days.Tuesday);
            if (Wen.IsChecked == true) days.Add(Days.Wednesday);
            if (Thi.IsChecked == true) days.Add(Days.Thursday);
            if (Fri.IsChecked == true) days.Add(Days.Friday);
            if (Sat.IsChecked == true) days.Add(Days.Saturday);
            Film film = new Film()
            {
                Name = NameFilm.Text,
                CountSeria = int.Parse(CountFilm.Text),
                Duration = int.Parse(CountFilm.Text),
                Day=days
            };
            films.Add(film);
            UpdateUI();
        }
        public void UpdateUI()
        {
            foreach(Film i in films)
            {
                FilmsPanel.Children.Add(new FilmControl());
            }
        }
    }
}
