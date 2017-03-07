using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;
    public class ClaimsController : Controller
    {
        private readonly FisherContext db;
        public ClaimsController()
        {
            db = context;
        }
        public IActionResult GetClaims()
        {
            return Ok(db.Claims);
        }
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/claims/claim
        [HttpPost]
        public IActionResult Post([FromBody]Claim claim)

        {
            var newClaim = db.Claims.Add(claim);
            db.SaveChanges();

            return CreatedAtRoute("GetClaim", new {id=claim.Id}, claim);

        }

    // GET api/claims/claim/5
        [HttpGetAttribute("{id}", Name = "GetClaim")]

        public IActionResult Get(int id)
        {
            return Ok(db.Claims.Find(id));
        }
    // PUT api/claims/claim/id
        [HttpPutAttribute("{id}")]
        public IActionResult Put(int id, [FromBody]Claim claim)
        {
            var newClaim = db.Claims.Find(id);
            if (newClaim==null)
            {
                return NotFound();
            }
            newClaim = claim;
            db.SaveChanges();

            return Ok(newClaim);
        }
    // DELETE api/claims/claim/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var claimToDelete=db.Claims.Find(id);
            if (claimToDelete==null){
                return NotFound();
            }
            db.Claims.Remove(claimToDelete);
            db.SaveChangesAsync();

            return NoContent();
        }
    }
