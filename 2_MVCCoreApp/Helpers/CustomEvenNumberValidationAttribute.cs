using System.ComponentModel.DataAnnotations;

namespace _2_MVCCoreApp.Helpers
{
    public class CustomEvenNumberValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int num = (int) value;

            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
