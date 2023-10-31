using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Musify.ValidationRules
{
    public class NotEmptyValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (string.IsNullOrWhiteSpace(value as string))
            {
                return new ValidationResult(false, "Field cannot be empty.");
            }

            return ValidationResult.ValidResult;
        }
    }
}