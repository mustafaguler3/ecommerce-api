using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuggyController : ControllerBase
    {
        private readonly StoreContext _context;

        public BuggyController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("not found")]
        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.Products.Find(99);

            if (thing == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return Ok();
        }
    }
}
