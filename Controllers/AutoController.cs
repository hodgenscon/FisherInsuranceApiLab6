using Microsoft.AspNetCore.Mvc;
    public class AutoController : Controller
    {
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/auto/quotes
        [HttpPost]
        public IActionResult Post([FromBody]string value)

        {

            return Created("", value);

        }

    // GET api/auto/quotes/5
        [HttpGetAttribute("{id}")]

        public IActionResult Get(int id)
        {
            return Ok("The id is : "+id);
        }
    // PUT api/auto/quotes/id
        [HttpPutAttribute("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return NoContent();
        }
    // DELETE api/auto/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Delete(id);
        }
    }
