using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UT02_02_Hibrido.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Name")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El campo debe tener entre 3 y 15 caracteres.")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Description")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo debe tener entre 3 y 30 caracteres.")]
        public string Description { get; set; }
       
        
        public int ShipperID { get; set; }
        public Shipper? Shipper { get; set; }
        
        
    }
}
