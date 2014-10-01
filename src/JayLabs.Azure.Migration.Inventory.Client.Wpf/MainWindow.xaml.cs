using System.Windows;

namespace JayLabs.Azure.Migration.Inventory.Client.Wpf
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly InventoryViewModel _inventoryViewModel = new InventoryViewModel();

        public MainWindow()
        {
            DataContext = ViewModel;

            InitializeComponent();
        }

        public InventoryViewModel ViewModel
        {
            get { return _inventoryViewModel; }
        }

        async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            await _inventoryViewModel.GetDataAsync();
        }
    }
}