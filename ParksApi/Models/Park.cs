using System;
using System.ComponentModel.DataAnnotations;


namespace ParksApi.Models
{
    public class Park
    {
        public int ParkId{ get; init; }

        [Required]
        public string ParkName { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(12)]
        public string State { get; set; }

        [Required]
        public DateTime DateEstablished { get; init; }

        [Required]
        public int AreaInAcres { get; set; }
    } 
}

