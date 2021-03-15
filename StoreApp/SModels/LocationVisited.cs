using System;
using System.Collections.Generic;
using System.Text;

namespace SModels
{
    public class LocationVisited
    {
        public int LocationVisitedID { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
