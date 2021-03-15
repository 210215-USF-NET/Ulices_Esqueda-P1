using System;
using System.Collections.Generic;
using System.Text;

namespace SModels
{
    public class Store
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string StoreLocation { get; set; }
        public Manager StoreManager { get; set; }
    }
}
