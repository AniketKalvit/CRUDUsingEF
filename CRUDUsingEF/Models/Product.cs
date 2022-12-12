using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDUsingEF.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Company Name is required")]
        [Display(Name="Company Name")]
        public string? CompanyName { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }
    }
}
