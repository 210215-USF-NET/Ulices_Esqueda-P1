namespace SModels
{
    public class OrderItem
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }
    }
}