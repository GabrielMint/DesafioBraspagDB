using System.Linq;

namespace DesafioDatabase{
    public class Calculator : ICalculator{
        
        public ITaxRepository _taxRepository;

        public Calculator(ITaxRepository taxRepository){
            _taxRepository = taxRepository;
        }

        public double TaxCalculator(Transaction transaction){
            
            var Tax = _taxRepository.GetTaxBasedOnATransaction(transaction);
            
            return transaction.Value - (transaction.Value * Tax.Value / 100);

        }

    }
}