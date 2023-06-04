using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [PrimaryKey("ProductId", "OrderId")]
    [Table("Product_Order")]
    public class ProductOrder
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        
        public Order Order { get; set; }

        public int Amount { get; set; }
    }
}
