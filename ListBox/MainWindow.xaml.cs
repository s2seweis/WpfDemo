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

using ListBox.Data;

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Person> People = new List<Person>

        {
            new Person { Name = "Jannick", Age = 30 },
            new Person { Name = "Sebastian", Age = 18 },
            new Person { Name = "Laura", Age = 25 },
            new Person { Name = "Maria", Age = 22 },
            new Person { Name = "Kevin", Age = 35 }
        };


        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;

            foreach (var item in selectedItems)
            {
                //InvalidCastException this into a person
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}