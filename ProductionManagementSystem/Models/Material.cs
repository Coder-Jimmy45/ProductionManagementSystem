using System.ComponentModel.DataAnnotations;

namespace ProductionManagementSystem.Models
{
    public class Material
    {
        public int Id { get; set; }

        [Required]
        public string MaterialName { get; set; } = string.Empty;

        public decimal Quantity { get; set; }
        [Required]

        public string Unit { get; set; } = string.Empty;
        public decimal MinStock { get; set; }
    }
}
