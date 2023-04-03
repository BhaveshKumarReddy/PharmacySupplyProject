using System.ComponentModel.DataAnnotations;

namespace PharmacySupplyProject.Models
{
    public class PharmaryMedicineSupply
    {
        public string PharmacyName { get; set; } = string.Empty;
        public string MedicineName { get; set; } = string.Empty;
        public int SupplyCount { get; set; }
    }
}
