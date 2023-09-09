using System.ComponentModel.DataAnnotations;

namespace DistanceConverter.Models
{
    public class DistanceConverter
    {
        const double CM_PER_IN = 2.54;

        [Required(ErrorMessage = "Please enter number of inches.")]
        [Range(1, 500, ErrorMessage = "Number must be between 1 and 500")]
        public double DistanceInInches { get; set; }

        public double DistanceInCentimeters { get; set; }
        public double ConvertInchesToCentimeters(double inches)
        {
            return inches * CM_PER_IN;
        }
    }
}
