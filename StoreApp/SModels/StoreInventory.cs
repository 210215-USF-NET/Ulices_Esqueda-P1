using System;
using System.Collections.Generic;
using System.Text;

namespace SModels
{
    public class StoreInventory
    {
        public int ID { get; set; }
        public int StoreID { get; set; }
        public int ProductID { get; set; }
        public int InventoryQuantity { get; set; }
    }
}
