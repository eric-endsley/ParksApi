using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
    public class NatlPark
    {
        public int NatlParkId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string State { get; set; }
    }
}