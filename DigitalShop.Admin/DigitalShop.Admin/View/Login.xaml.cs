using DigitalShop.Admin.Model;
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

namespace DigitalShop.Admin.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.txtErrorMessage.Content = "";
            if(this.txtUsername.Text=="admin" && this.txtPassword.Password.ToString() == "admin")
            {
                MainPage main = new MainPage();
                MainLayer.Main.Content = main;
            }
            else
            {
                 this.txtErrorMessage.Content = "Username or password incorrect.";
            }
        }
    }
}
