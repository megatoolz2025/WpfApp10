using System.Windows.Controls;

namespace OrderManagementSystem
{
    public partial class OrderStatusPage : Page
    {
        public OrderStatusPage()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
