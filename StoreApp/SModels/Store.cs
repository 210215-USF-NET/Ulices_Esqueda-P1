using System;

namespace SModels
{
    public class Store
    {
        public int ID { get; set; }
        public string StoreName { get; set; }
        public string StoreLocation { get; set; }
        public Manager StoreManager { get; set; }
    }
}