using Microsoft.AspNetCore.Mvc;
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/home/quotes
        [HttpPost]
        public IActionResult Post([FromBody]string value)

        {

            return Created("", value);

        }

    // GET api/home/quotes/5
        [HttpGetAttribute("{id}")]

        public IActionResult Get(int id)
        {
            return Ok("The id is : "+id);
        }
    // PUT api/home/quotes/id
        [HttpPutAttribute("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return NoContent();
        }
    // DELETE api/home/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Delete(id);
        }
    }
