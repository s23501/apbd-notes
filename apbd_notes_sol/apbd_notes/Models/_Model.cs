using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apbd_notes.Models
{
    [Table("_Model")]
    public class _Model
    {
        [Key]
        public int ID { get; set; }

        public int EmployeeID { get; set; }

        // RELATIONSHIP

        // FOREIGN KEY TO 1
        [ForeignKey(nameof(EmployeeID))]
        public virtual Employee Employee { get; set; } = null!;

        // ONE TO MANY
        public virtual ICollection<OrderPastry> OrderPastries { get; set; } = new List<OrderPastry>();

    }
}
