using System.ComponentModel.DataAnnotations;

namespace FormsAPI.Models
{
    public class Product
    {
        [Display(Name="Ürün ID")]
        public int ProductId { get; set; }


        [Display(Name = "Ürün Adı")]
        [Required(ErrorMessage = "Gerekli bir alan")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen 0 ila 100000 arasında bir fiyat girin")]
        [Display(Name = "Fiyat")]
        [Range(0,100000)]
        public decimal? Price { get; set; }

      
        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

     
    }
}
