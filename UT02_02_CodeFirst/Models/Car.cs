using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UT02_02_CodeFirst.Models
{
    public class Car
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        //min 3 max 20
        [DisplayName("Modelo")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El campo debe tener entre 3 y 20 caracteres.")]
        public string Model { get; set; }


        [DisplayName("Marca")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El campo debe tener entre 3 y 15 caracteres.")]
        public string Brand { get; set; }


        //Fecha <1/1/2024
        [DisplayName("Fecha")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Range(typeof(DateTime), "1/1/1970", "1/1/2024", ErrorMessage = "El valor tiene que estar entre 1/1/1970 y 1/1/2024")]
        public DateTime ReleaseDate { get; set; }


        [DisplayName("Precio")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Range(5000,30000, ErrorMessage ="El valor tiene que estar entre 5000 y 30000")]
        public Decimal Price { get; set; }

  
    }
}
