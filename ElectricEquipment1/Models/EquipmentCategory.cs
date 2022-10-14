using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ElectronicEquipment.Models
{
    public class EquipmentCategory
    {
        [Key]
        public int EquipmentCategoryId { get; set; }
        [Required]
        public string EquipmentCategoryName { get; set; }
    }
}
