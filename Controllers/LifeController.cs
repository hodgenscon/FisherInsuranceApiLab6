using Microsoft.AspNetCore.Mvc;
    public class LifeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/life/quotes
        [HttpPost]
        public IActionResult Post([FromBody]string value)

        {

            return Created("", value);

        }

    // GET api/life/quotes/5
        [HttpGetAttribute("{id}")]

        public IActionResult Get(int id)
        {
            return Ok("The id is : "+id);
        }
    // PUT api/life/quotes/id
        [HttpPutAttribute("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return NoContent();
        }
    // DELETE api/life/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Delete(id);
        }
    }
