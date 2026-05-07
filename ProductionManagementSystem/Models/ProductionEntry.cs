

using System.ComponentModel.DataAnnotations;

namespace ProductionManagementSystem.Models
{
    public class ProductionEntry
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; } = string.Empty;

        public int QuantityProduced { get; set; }

        public DateTime EntryDate { get; set; } = DateTime.MinValue;
    }
}
