using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;

namespace JayLabs.Azure.Migration.Inventory.Client.Wpf
{
    public class InventoryViewModel
    {
        readonly InventoryItemList _inventoryItems = new InventoryItemList();
        readonly DataService _dataService = new DataService();

        public InventoryViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                foreach (var inventoryItem in SampleData.InventoryItems)
                {
                    _inventoryItems.Add(inventoryItem);
                }
            }
            else
            {
                _inventoryItems.Add(new InventoryItem("Real", "Table", true));
            }
        }

        public InventoryItemList InventoryItems
        {
            get { return _inventoryItems; }
        }

        public async Task GetDataAsync()
        {
            var data = await _dataService.GetInventoryItemsAsync();

            foreach (var item in data)
            {
                _inventoryItems.Add(item);
            }
        }

    }
}