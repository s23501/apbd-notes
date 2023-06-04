using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [PrimaryKey("Id")]
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }


        public Client Client { get; set; }

        public Status Status { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
