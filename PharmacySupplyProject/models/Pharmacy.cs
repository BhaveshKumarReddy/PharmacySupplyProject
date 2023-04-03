using System.ComponentModel.DataAnnotations;

namespace PharmacySupplyProject.Models
{
    public class Pharmacy
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }=string.Empty;
    }
}
