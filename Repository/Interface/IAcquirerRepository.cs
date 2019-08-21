using System.Collections.Generic;

namespace DesafioDatabase{
    public interface IAcquirerRepository
    {
        IEnumerable<Acquirer> GetAllAcquirers();

        void CreateAcquirer(Acquirer acquirer);
    }
}