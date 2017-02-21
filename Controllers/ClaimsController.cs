using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;
    public class ClaimsController : Controller
    {
        private IMemoryStore db;
        public ClaimsController(IMemoryStore repo)
        {
            db=repo;
        }
        public IActionResult GetClaims()
        {
            return Ok(db.RetrieveAllClaims);
        }
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/claims/claim
        [HttpPost]
        public IActionResult Post([FromBody]Claim claim)

        {

            return Ok(db.CreateClaim(claim));

        }

    // GET api/claims/claim/5
        [HttpGetAttribute("{id}")]

        public IActionResult Get(int id)
        {
            return Ok(db.RetrieveClaim(id));
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
            db.DeleteClaim(id);
            return Ok();
        }
    }
