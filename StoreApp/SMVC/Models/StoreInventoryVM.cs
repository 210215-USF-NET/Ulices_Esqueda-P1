using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMVC.Models
{
    public class StoreInventoryVM
    {
        public int StoreID { get; set; }
        [DisplayName("Product ID")]
        [Required]
        [Range(1, 10)]
        public int ProductID { get; set; }

        [DisplayName("Quantity")]
        [Required]
        [Range(1, 10, ErrorMessage = "Quanitity should not be negative!")]
        public int InventoryQuantity { get; set; }
    }
}