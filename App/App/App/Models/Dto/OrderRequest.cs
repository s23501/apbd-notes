using System.ComponentModel.DataAnnotations;

namespace App.Models.Dto
{
    public class OrderRequest
    {
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? FulfilledAt { get; set; }
    }
}
