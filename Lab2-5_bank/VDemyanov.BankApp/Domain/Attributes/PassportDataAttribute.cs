using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace VDemyanov.BankApp.Domain.Attributes
{
    public class PassportDataAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string pattern = @"[A-Z0-9]{14}";
                // string pattern = @"[1-6](([0][1-9])|([1-2][0-9])|([3]|[0-1]))(([1][1-2])|([0][1-9]))(([0-9][1-9])|([1-9][0-9]))([A-C]|[H]|[K]|[E]|[M])([0-9]{3})(PB|BA|BI)(1-9)";
                string tts = value.ToString();
                if (Regex.IsMatch(value.ToString(), pattern))
                    return true;
                else
                    this.ErrorMessage = "Введены неправильные паспортные данные";
            }
            return false;
        }
    }
}
