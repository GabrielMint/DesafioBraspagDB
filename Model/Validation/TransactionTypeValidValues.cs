using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioDatabase{
    public class TransactionTypeValidValues : ValidationAttribute{
        
        public List<string> validValues;

        public TransactionTypeValidValues()
        {
            validValues = new List<string>()
            {
                "credito", "debito"
            };
        }

        public override bool IsValid(object value)
        {
            string typeValue = (string)value;

            if (validValues.Contains(typeValue))
            {
                return true;
            }

            return false;

        }
    }
}