using System;
using System.Collections.Generic;
using System.Text;

namespace SModels
{
    public class LocationVisited
    {
        public int ID { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
