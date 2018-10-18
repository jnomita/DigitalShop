using DigitalShop.Admin.Data;
using DigitalShop.Admin.Repository;
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
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        private OrderRepository ordRes = new OrderRepository();
        public OrderPage()
        {
            InitializeComponent();
            this.tblData.ItemsSource = ordRes.GetAllOrders().Select(p=> new {
                OrderID  = p.OrderID,
                OrderCode =p.OrderCode,
                DateCreate =p.DateCreate.ToString("dd/MM/yyyy HH:mm"),
                ShippingAddress = p.ShippingAddress,
                Status = p.Status==1?"New":p.Status==2?"Plan":p.Status==3?"Delivering":"Delivered",
                CustomerName= p.Customer.Title+" "+ p.Customer.FirstName + " "+ p.Customer.LastName
            });
        }
    }
}
