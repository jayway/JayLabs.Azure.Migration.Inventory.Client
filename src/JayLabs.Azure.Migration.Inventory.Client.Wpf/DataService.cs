using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Common;
using JayLabs.Azure.Migration.Inventory.Client.Wpf.InventoryRemoteService;

namespace JayLabs.Azure.Migration.Inventory.Client.Wpf
{
    internal class DataService
    {
        public async Task<IEnumerable<InventoryItem>> GetInventoryItemsAsync()
        {
            var client = new InventoryServiceClient();

            ProductView[] products = await client.GetProductsAsync();

            var list = products
                .Select(product => new InventoryItem(product.ProductId.ToString(), product.Description, true))
                .ToList();

            return list;
        }
    }
}