using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Authentication
{
    /// <summary>
    /// Interaktionslogik für LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void OnLoginBtnClicked(object sender, RoutedEventArgs e)
        {
            // The predefined environment password
            var correctPassword = "123456";

            var passwordEntered = PasswordBox.Password;

            // Checking if the entered password matches the predefined one
            if (passwordEntered == correctPassword)
            {
                MessageBox.Show("Login successful!");
                // Proceed with the app logic after successful login
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.");
                // Optionally, you can add logic to handle failed login attempts
            }

        }
            public void OnPasswordChanged(object sender, EventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
