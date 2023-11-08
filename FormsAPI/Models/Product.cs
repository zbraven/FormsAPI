using System.ComponentModel.DataAnnotations;

namespace FormsAPI.Models
{
    public class Product
    {
        [Display(Name="Ürün ID")]
        public int ProductId { get; set; }
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        [Display(Name = "Resim")]
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
    }
}
