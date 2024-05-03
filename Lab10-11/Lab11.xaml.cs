﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
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
                Duration = int.Parse(DurationFilm.Text),
                Day=days
            };
            films.Add(film);
            UpdateUI();
        }
        public void UpdateUI()
        {
            NameFilm.Text = "";
            CountFilm.Text = "";
            DurationFilm.Text = "";
            Sun.IsChecked = false;
            Mon.IsChecked = false;
            Thu.IsChecked = false;
            Wen.IsChecked = false;
            Thi.IsChecked = false;
            Fri.IsChecked = false;
            Sat.IsChecked = false;
            FilmsPanel.Children.Clear();
            foreach(Film i in films)
            {
                FilmsPanel.Children.Add(new FilmControl(i));
            }
            maxFilm.FontSize = 24;
            maxFilm.Content = MaxFilm().Name+":"+MaxFilm().getPeriod() + " мин";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Бинарные файлы(*.dat)|*.dat";
           
            if (sfd.ShowDialog() == true)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(sfd.FileName, FileMode.OpenOrCreate)))
                {
                    string json = JsonSerializer.Serialize(films);
                    writer.Write(json);
                }
            }
        }

        private Film MaxFilm()
        {
            Film max = films[0];
            foreach (Film f in films)
            {
                if (f.getPeriod() > max.getPeriod()) max = f;
            }
            return max;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Бинарные файлы(*.dat)|*.dat";
            if (ofd.ShowDialog() == true)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(ofd.FileName, FileMode.Open)))
                {
                    string json = reader.ReadString();
                    List<Film> desFilms= JsonSerializer.Deserialize<List<Film>>(json)!;
                    foreach(Film f in desFilms)
                    {
                        films.Add(f);
                    }
                    UpdateUI();
                }
            }
        }
    }
}
