using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace ZipCode
{
    public class ValidZipCode : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            string zip = value as string;
            var usEEZipRegex = new Regex(@"^\d{5}(?:[-\s]\d{4})?$");
            var caZipRegex = new Regex(@"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$");
            if (zip != null)
            {
                if (usEEZipRegex.IsMatch(zip) || caZipRegex.IsMatch(zip))
                    return ValidationResult.ValidResult;
            }
            return new ValidationResult(false, Message);
        }

        public String Message { get; set; }
    }
}
