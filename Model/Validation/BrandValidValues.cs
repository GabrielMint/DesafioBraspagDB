using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioDatabase{
    public class BrandValidValues : ValidationAttribute{
        
        public List<string> validValues;

        public BrandValidValues()
        {
            validValues = new List<string>()
            {
                "visa", "master"
            };
        }

        public override bool IsValid(object value)
        {
            string brandValue = (string) value;

            if(validValues.Contains(brandValue))
            {
                return true;
            }

            return false;

        }
    }
}