using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JayLabs.Azure.Migration.Inventory.Client.Wpf
{
    internal class DataService
    {
        public Task<IEnumerable<InventoryItem>> GetInventoryItemsAsync()
        {
            return Task.FromResult(Enumerable.Empty<InventoryItem>());
        }
    }
}