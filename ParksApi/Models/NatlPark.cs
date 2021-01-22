using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
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