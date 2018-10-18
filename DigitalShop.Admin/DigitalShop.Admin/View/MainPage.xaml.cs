using DigitalShop.Admin.Data;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
             this.MainContent.Content = new OrderPage();
            this.btnOrder.Background = Brushes.Aqua;
            MainLayer.Main.Width = 1240;
            MainLayer.Main.Height = 600;
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Content = new OrderPage();
            this.btnOrder.Background = Brushes.Aqua;
            this.btnProduct.Background = null;
            this.btnCategory.Background =null;
            
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Content = new CategoryPage();
            this.btnCategory.Background = Brushes.Aqua;
            this.btnProduct.Background = null;
            this.btnOrder.Background =null;
            
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Content = new ProductPage();
            this.btnProduct.Background = Brushes.Aqua;
            this.btnCategory.Background = null;
            this.btnOrder.Background =null;
        }
    }
}
