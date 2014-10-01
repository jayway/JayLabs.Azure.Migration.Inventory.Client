namespace JayLabs.Azure.Migration.Inventory.Client.Wpf
{
    public static class SampleData
    {
        public static InventoryItemList InventoryItems
        {
            get
            {
                return new InventoryItemList
                       {
                           new InventoryItem("1", "Sample chair 1", true),
                           new InventoryItem("2", "Sample chair 2", true),
                           new InventoryItem("3", "Sample chair 3", false),
                       };
            }
        }
    }
}