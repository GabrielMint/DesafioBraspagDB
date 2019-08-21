using System.Collections.Generic;
using System.Linq;

namespace DesafioDatabase{
    public class TaxRepository : ITaxRepository{

        private readonly IAcquirerRepository _acquirerRepository;
        private readonly StoreDataContext _context;

        public TaxRepository(IAcquirerRepository acquirerRepository, StoreDataContext context){
            _acquirerRepository = acquirerRepository;
            _context = context;
        }


         public IEnumerable<Tax> GetAllTaxes(){
            return _context.Taxes.ToList(); 
        }

        public void CreateTax(Tax tax){
            _context.Taxes.Add(tax);
            _context.SaveChanges();
        }


        public Tax GetTaxBasedOnATransaction(Transaction transaction){
            Tax Tax = _acquirerRepository.GetAllAcquirers()
                                         .SingleOrDefault(ac => ac.Type == transaction.Acquirer)
                                         .Taxes.SingleOrDefault(tx => tx.Brand == transaction.Brand 
                                         && tx.Type == transaction.Type);

            return Tax;
                                                              
        }

    }
}