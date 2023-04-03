using System.ComponentModel.DataAnnotations;

namespace PharmacySupplyProject.Models
{
    public class MedicineStock
    {
        [Key]
        public string Name { get; set; }
        public string ChemicalComposition { get; set; }
        public string TargetAilment { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfExpiry { get; set; }
        public int NumberOfTabletsInStock { get; set; }


    }
}
