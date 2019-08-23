using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace DesafioDatabase{
    public class AcquirerRepository : IAcquirerRepository{

        private readonly StoreDataContext _context;
        
        public AcquirerRepository(StoreDataContext context){
            _context = context;
        }

        public IEnumerable<Acquirer> GetAllAcquirers(){
                    return _context.Acquirers
                            .Include(x => x.Taxes)
                            .ToList();  
        }

        public void CreateAcquirer(Acquirer acquirer){
                    _context.Acquirers.Add(acquirer);
                    _context.SaveChanges();
            }
        }

    }