using System.Collections.Generic;

 namespace DesafioDatabase{

    public interface ITaxRepository
    {
        IEnumerable<Tax> GetAllTaxes();
        void CreateTax(Tax tax);
        Tax GetTaxBasedOnATransaction(Transaction transaction);
    }

 }