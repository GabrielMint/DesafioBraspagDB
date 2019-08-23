using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioDatabase{
    public class AcquirerValidValues : ValidationAttribute{
       public List<char> validValues;

        public AcquirerValidValues()
        {
            validValues = new List<char>()
            {
                'A', 'B', 'C'
            };
        }

        public override bool IsValid(object value)
        {
            char acquirerValue = (char) value;

            if (validValues.Contains(acquirerValue))
            {
                return true;
            }

            return false;
        }
    }
}