using apbd_notes.Models;
using System.ComponentModel.DataAnnotations;

namespace apbd_notes.Models.DTOs
{
    public class NewModelDTO
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string AnimalClass { get; set; } = null!;
        [Required]
        public DateTime AdmissionDate { get; set; }
        [Required]
        public int OwnerID { get; set; }
        [Required]
        public ICollection<Client> Clients { get; set; } = new List<Client>();

    }
}
