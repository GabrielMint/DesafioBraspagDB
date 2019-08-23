using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesafioDatabase{
    
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase{
        
        public ICalculator _calculator;

        public TransactionController(ICalculator calculator){
            _calculator = calculator;
        }


        [HttpPost]
        public IActionResult Post([FromBody] Transaction transaction){
            
            var result = new { netValue = _calculator.TaxCalculator(transaction) };
           
            return Ok(result);
        }

    }
}