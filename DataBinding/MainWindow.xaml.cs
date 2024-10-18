using DataBinding.Data;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Created a Real Object

        Person person = new Person
        {
            Name = "Sebastian",
            Age = 30
        };

        // Constructor
        public MainWindow()
        {
            InitializeComponent();

            // Inside of our Constructor we want call the data context,
            // The data context is the underlying structure that provides the binding information between the ui elements and the data that they display

            this.DataContext = person;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string personData = person.Name + " is " + person.Age + " years old.";
            MessageBox.Show(personData);
        }
    }
}