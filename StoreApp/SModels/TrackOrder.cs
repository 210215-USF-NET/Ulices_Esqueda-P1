using System;
using System.Collections.Generic;
using System.Text;

namespace SModels
{
    public class TrackOrder
    {
        public int TrackOrderID { get; set; }
        public Customer Customer { get; set; }
        public Orders Order { get; set; }
        public OrderItem OrderItem { get; set; }
        public Store Store { get; set; }
    }
}
