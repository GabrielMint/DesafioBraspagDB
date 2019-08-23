using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesafioDatabase{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaxController : ControllerBase{

        private readonly ITaxRepository _repository;

        public TaxController(ITaxRepository repository){
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Tax> Get(){
            return _repository.GetAllTaxes();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tax tax){

            _repository.CreateTax(tax);

            return Ok();
        }

        [HttpPost]
        public ActionResult<Tax> Post(Transaction transaction){

            var tax = _repository.GetTaxBasedOnATransaction(transaction);

            return Ok(tax);

        }

    }
}