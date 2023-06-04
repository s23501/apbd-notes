using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [PrimaryKey("Id")]
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        
        public decimal Price { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
