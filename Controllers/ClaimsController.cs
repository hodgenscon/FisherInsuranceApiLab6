using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;
    public class ClaimsController : Controller
    {

        public ClaimsController()
        {
            
        }
        public IActionResult GetClaims()
        {
            return Ok();
        }
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/claims/claim
        [HttpPost]
        public IActionResult Post([FromBody]Claim claim)

        {

            return Ok();

        }

    // GET api/claims/claim/5
        [HttpGetAttribute("{id}")]

        public IActionResult Get(int id)
        {
            return Ok();
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
            
            return Ok();
        }
    }
