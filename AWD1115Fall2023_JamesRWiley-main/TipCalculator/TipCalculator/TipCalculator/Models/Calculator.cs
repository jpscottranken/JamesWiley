using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage ="Please enter the value of meal.")]
        [Range(1, 1000000, ErrorMessage = "Cost of meal must be between 1 and 1000000" )]

        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {
            if(MealCost.HasValue)
            {
                var tip = MealCost.Value * percent;
                return tip;
            }
            else 
            {
                return 0.0;
            }
        }
    }
}
