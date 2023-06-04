using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [PrimaryKey("Id")]
    [Table("Status")]
    public class Status
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
