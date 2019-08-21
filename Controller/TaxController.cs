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
        public IEnumerable<Tax> GetAllTaxes(){
            return _repository.GetAllTaxes();
        }

        [HttpPost]
        public IActionResult CreateTax([FromBody] Tax tax){

            _repository.CreateTax(tax);

            return Ok();
        }

        [HttpPost]
        public ActionResult<Tax> GetTaxBasedOnATransaction(Transaction transaction){

            var tax = _repository.GetTaxBasedOnATransaction(transaction);

            return Ok(tax);

        }

    }
}