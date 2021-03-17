using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using SModels;

namespace SMVC.Models
{
    public class StoreListVM
    {
        [DisplayName("Store ID")]
        public int ID { get; set; }
        [DisplayName("Store Name")]
        public string StoreName { get; set; }
        [DisplayName("Store Location")]
        public string StoreLocation { get; set; }
        [DisplayName("Store Manager")]
        public Customer StoreManager { get; set; }
    }
}
