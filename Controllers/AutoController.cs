using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;
    public class AutoController : Controller
    {
        private IMemoryStore db;

        public AutoController(IMemoryStore repo)
        {
            db=repo;
        }
        public IActionResult GetQuotes()
        {
            return Ok(db.RetrieveAllQuotes);
        }
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/auto/quotes
        [HttpPost]
        public IActionResult Post([FromBody]Quote quote)

        {

            return Ok(db.CreateQuote(quote));

        }

    // GET api/auto/quotes/5
        [HttpGetAttribute("{id}")]

        public IActionResult Get(int id)
        {
            return Ok(db.RetrieveQuote(id));
        }
    // PUT api/auto/quotes/id
        [HttpPutAttribute("{id}")]
        public IActionResult Put([FromBody]Quote quote)
        {
            return Ok(db.UpdateQuote(quote));
        }
    // DELETE api/auto/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.DeleteQuote(id);
            return Ok();
        }
    }
