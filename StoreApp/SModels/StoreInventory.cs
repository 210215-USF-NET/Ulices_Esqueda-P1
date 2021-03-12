namespace SModels
{
    public class StoreInventory
    {
        public int ID { get; set; }
        public Store Store { get; set; }
        public Product Product { get; set; }
        public int InventoryQuantity { get; set; }
    }
}