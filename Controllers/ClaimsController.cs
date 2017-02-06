using Microsoft.AspNetCore.Mvc;
    public class ClaimsController : Controller
    {
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/claims/claim
        [HttpPost]
        public IActionResult Post([FromBody]string value)

        {

            return Created("", value);

        }

    // GET api/claims/claim/5
        [HttpGetAttribute("{id}")]

        public IActionResult Get(int id)
        {
            return Ok("The id is : "+id);
        }
    // PUT api/claims/claim/id
        [HttpPutAttribute("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return NoContent();
        }
    // DELETE api/claims/claim/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Delete(id);
        }
    }
