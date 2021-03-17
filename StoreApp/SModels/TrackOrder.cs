using System;
using System.Collections.Generic;
using System.Text;

namespace SModels
{
    public class TrackOrder
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int OrderItemID { get; set; }
        public int StoreID { get; set; }
    }
}
