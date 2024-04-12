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

namespace Lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> listLab1;
        private Queue<int> queue;
        private LinkedList<int> listLab3;
        public MainWindow ()
        {
            InitializeComponent();
            listLab1 = new List<int>();
            queue = new Queue<int>();
            listLab3 = new LinkedList<int>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listLab1.Add(int.Parse(tbElement.Text));
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
            tbElement.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index = lbList.SelectedIndex;
            listLab1.RemoveAt(index);
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int count = 0;
            foreach(int l in listLab1)
            {
                if (l < 0) count++;
            }
            Result.Text ="Количество отрицательных:"+count.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            queue.Enqueue(int.Parse(tbElementQueue.Text));
            lbQueue.ItemsSource = null;
            lbQueue.ItemsSource = queue;
            tbElementQueue.Text = "";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(tbCount.Text);
            string result = "";
            for(int i = 0; i < n; i++)
            {
                result += queue.Dequeue() + " ";
            }
            tbResultQueue.Text = result;
            lbQueue.ItemsSource = null;
            lbQueue.ItemsSource = queue;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            listLab3.Add(int.Parse(tbElementAdd.Text));
            lbList3.Items.Clear();
            foreach (int item in listLab3)
            {
                lbList3.Items.Add(item);
            }
            tbElementAdd.Text = "";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int i = 0;
            foreach(var index in listLab3)
            {
                if (index < 2) listLab3.Insert(i+1, 15);
                i++;
            }
            lbList3.Items.Clear();
            foreach (int item in listLab3)
            {
                lbList3.Items.Add(item);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            listLab3.Clear();
            lbList3.Items.Clear();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            List<Bone> list = new List<Bone>();
            for (int i = 1; i <= 1000; i++)
            {
                list.Add(new Bone(i));
            }
            Ishod.ItemsSource = list;

        }
    }
}