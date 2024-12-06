using System;
using System.Windows.Controls;

namespace OrderManagementSystem
{
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void GoToOrderStatus(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderStatusPage());
        }

        private void GoToDeliveryManagement(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeliveryManagementPage());
        }
     
        private void GoToReturns(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReturnsPage());
        }
    }
}
