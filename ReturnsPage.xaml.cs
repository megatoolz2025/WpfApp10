using System.Windows.Controls;

namespace OrderManagementSystem
{
    public partial class ReturnsPage : Page
    {
        public ReturnsPage()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
