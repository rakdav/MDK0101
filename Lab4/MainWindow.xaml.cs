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

namespace Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Monster<int>[]? Monsters { get; set; } = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Monsters = new Monster<int>[int.Parse(tbCount.Text)];
            MessageBox.Show("Массив размером "+Monsters.Length+" элемента создан");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Monsters.Length>Monster<int>.Count)
            {
                AddMonster add = new AddMonster();
                if (add.ShowDialog() == true)
                {
                    Monsters[Monster<int>.Count] = new Monster<int>();
                    Monsters[Monster<int>.Count].Id = add.ID;
                    Monsters[Monster<int>.Count].Name = add.Name;
                    Monsters[Monster<int>.Count].Health = add.Health;
                    Monsters[Monster<int>.Count].Ammo = add.Ammo;
                    Monster<int>.Count++;
                }
                monsterList.ItemsSource = null;
                monsterList.ItemsSource = Monsters;
            }
            else
            {
                MessageBox.Show("Массив полностью заполнен");
            }
        }
    }
}