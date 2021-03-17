namespace SModels
{
    public class Customer
    {
        public int ID { get; set; }
        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string Email { get; set; }

        public string CustomerPhoneNumber { get; set; }
        public bool IsManager { get; set; }

        public string getCustomerFullName()
        {
            return CustomerFirstName + " " + CustomerLastName;
        }
    }
}