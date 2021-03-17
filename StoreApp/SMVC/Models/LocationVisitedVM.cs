using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMVC.Models
{
    public class LocationVisitedVM
    {
        public int ID { get; set; }

        [DisplayName("Customer")]
        [Required]
        public int CustomerID { get; set; }
        [DisplayName("Store")]
        [Required]
        public int StoreID { get; set; }
    }
}