using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apbd_notes.Models
{
    [Table("Order")]
    public class Order
    {
        // PRIMARY KEY
        [Key]
        public int ID { get; set; }

        // OBJECT
        public DateTime AcceptedAt { get; set; }

        // NULLABLE OBJECT
        public DateTime? FulfilledAt { get; set; }

        // LENGTH VALIDATION
        // NULLABLE STRING
        [MaxLength(300)]
        public string? Comments { get; set; }
        public int ClientID { get; set; }
        public int EmployeeID { get; set; }

        // RELATIONSHIPS

        // FOREIGN KEY TO 1
        [ForeignKey(nameof(ClientID))]
        public virtual Client Client { get; set; } = null!;

        // FOREIGN KEY TO 1
        [ForeignKey(nameof(EmployeeID))]
        public virtual Employee Employee { get; set; } = null!;

        // ONE TO MANY
        public virtual ICollection<OrderPastry> OrderPastries { get; set; } = new List<OrderPastry>();
    }
}
