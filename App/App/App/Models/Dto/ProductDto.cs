using System.ComponentModel.DataAnnotations;

namespace App.Models.Dto
{
    public class ProductDto
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public static ProductDto From(ProductOrder productOrders)
        {
            return new ProductDto()
            {
                Name = productOrders.Product.Name,
                Price = productOrders.Product.Price,
                Amount = productOrders.Amount
            };
        }
    }
}