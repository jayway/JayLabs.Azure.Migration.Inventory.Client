namespace JayLabs.Azure.Migration.Inventory.Client.Wpf
{
    public class InventoryItem
    {
        readonly string _description;
        readonly string _id;
        readonly bool _isActive;

        public InventoryItem(string id, string description, bool isActive)
        {
            _id = id;
            _description = description;
            _isActive = isActive;
        }

        public string Id
        {
            get { return _id; }
        }

        public string Description
        {
            get { return _description; }
        }

        public bool IsActive
        {
            get { return _isActive; }
        }
    }
}