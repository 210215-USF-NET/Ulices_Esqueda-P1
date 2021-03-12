using System;

namespace SModels
{
    public class LocationVisited
    {
        public int ID { get; set; }
        public Customers Customer { get; set; }
        public Store Store { get; set; }
    }
}