using System.Windows.Controls;

namespace OrderManagementSystem
{
    public partial class DeliveryManagementPage : Page
    {
        public DeliveryManagementPage()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
