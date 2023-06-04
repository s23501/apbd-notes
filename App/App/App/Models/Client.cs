using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [PrimaryKey("Id")]
    [Table("Client")]
    public class Client
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
