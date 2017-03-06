using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;
    public class QuotesController : Controller
    {

        public QuotesController()
        {

        }
        public IActionResult GetQuotes()
        {
            return Ok();
        }
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/quotes
        [HttpPost]
        public IActionResult Post([FromBody]Quote quote)

        {

            return Ok();

        }

    // GET api/quotes/5
        [HttpGetAttribute("{id}")]

        public IActionResult Get(int id)
        {
            return Ok();
        }
    // PUT api/quotes/id
        [HttpPutAttribute("{id}")]
        public IActionResult Put([FromBody]Quote quote)
        {
            return Ok();
        }
    // DELETE api/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            return Ok();
        }
    }
