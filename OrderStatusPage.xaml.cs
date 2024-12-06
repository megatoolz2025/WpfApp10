using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace OrderManagementSystem
{
    public partial class OrderStatusPage : Page
    {
        public OrderStatusPage()
        {
            InitializeComponent(); 

     
            var orders = new List<Order>
            {
                new Order { OrderId = 1, Status = "В обработке", OrderDate = DateTime.Now.AddDays(-2).ToShortDateString() },
                new Order { OrderId = 2, Status = "Доставлен", OrderDate = DateTime.Now.AddDays(-5).ToShortDateString() },
                new Order { OrderId = 3, Status = "Отменен", OrderDate = DateTime.Now.AddDays(-7).ToShortDateString() },
                new Order { OrderId = 4, Status = "Ожидает оплаты", OrderDate = DateTime.Now.AddDays(-1).ToShortDateString() },
                new Order { OrderId = 5, Status = "Отправлен", OrderDate = DateTime.Now.AddDays(-3).ToShortDateString() },
            };
            OrdersListView.ItemsSource = orders;

        }

      
        public class Order
        {
            public int OrderId { get; set; }        
            public string Status { get; set; }     
            public string OrderDate { get; set; }  
        }

    
        private void GoBack(object sender, System.Windows.RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack(); 
            }
        }
    }
}
