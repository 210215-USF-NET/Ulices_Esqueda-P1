using System;
using System.Collections.Generic;
using System.Text;

namespace SModels
{
    public class StoreInventory
    {
        public int StoreInventoryID { get; set; }
        public Store Store { get; set; }
        public Product Product { get; set; }
        public int InventoryQuantity { get; set; }
    }
}
