﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectCollections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> people = new List<string>{ "Маша","Дудка","Леша"};
        public MainWindow ()
        {
            InitializeComponent();
            people.Add("Боря");
            lbPeople.ItemsSource = people;
        }
    }
}