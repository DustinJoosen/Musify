using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Musify.ValidationRules
{
    public class NotNumberValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (int.TryParse((string)value, out int num))
            {
                return (num > 1900 && num <= DateTime.Now.Year)
                    ? ValidationResult.ValidResult
                    : new ValidationResult(false, $"Number has to between 0 and {DateTime.Now.Year}");
            }
            return new ValidationResult(false, "Field needs to be a number");
        }
    }
}