using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesafioDatabase{
    
    [Route("/api/acquirer")]
    [ApiController]
    public class AcquirerController : ControllerBase{
        
        private readonly IAcquirerRepository _repository;

        public AcquirerController(IAcquirerRepository repository){
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Acquirer> GetAcquirer(){
            return _repository.GetAllAcquirers();
        }

        [HttpPost]
        public IActionResult CreateAcquirer([FromBody] Acquirer acquirer){

            _repository.CreateAcquirer(acquirer);

            return Ok();
        }

    }
}