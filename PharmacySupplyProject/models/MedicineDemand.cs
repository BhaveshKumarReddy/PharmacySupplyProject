using System.ComponentModel.DataAnnotations;

namespace PharmacySupplyProject.Models
{
    public class MedicineDemand
    {
        [Key]
        public string MedicineName { get; set; } = string.Empty;
        public int DemandCount { get; set; }
    }
}
