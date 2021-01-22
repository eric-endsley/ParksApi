using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
    public class StatePark
    {
        public int StateParkId { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string State { get; set; }
    }
}