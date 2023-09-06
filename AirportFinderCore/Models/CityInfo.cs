using System.ComponentModel.DataAnnotations;

namespace AirportFinderCore.Models
{
    public class CityInfo
    {
        [Key]
        public string City { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }
    }
}
