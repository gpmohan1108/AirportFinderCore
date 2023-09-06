using System.ComponentModel.DataAnnotations;

namespace AirportFinderCore.Models
{
    public class StateImg
    {
        [Key]
        public string State { get; set; }

        public string Photo { get; set; }
    }
}
