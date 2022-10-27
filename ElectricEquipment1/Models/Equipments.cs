using System.ComponentModel.DataAnnotations;

namespace ElectronicEquipment.Models
{
    public class Equipments
    {
        [Key]
        public int EquipmentId { get; set; }
        [Required]
        public string EquipmentName { get; set; }
        [Required]
        public string PartId { get; set; }
        public int? EquipmentCategoryId { get; set; } 
        public EquipmentCategory EquipmentCategory { get; set; } 
        public int? EquipmentGroupId { get; set; }
        public EquipmentGroup EquipmentGroup { get; set; }
    }
}
