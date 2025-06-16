using Microsoft.AspNetCore.Mvc;
using WebApplication1.dataAccess;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShiftsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetShifts()
        {
            var shifts =jsonDataAccess.GetShifts();
            return Ok(shifts);
        }

        [HttpPut]
        public IActionResult UpdateShift([FromBody] Shifts updatedShift)
        {
            var success = jsonDataAccess.UpdateShift(updatedShift);
            if (!success)
                return NotFound($"Shift with id {updatedShift.Id} not found");

            return Ok(updatedShift);
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class RequestsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRequests()
        {
            var requests = jsonDataAccess.GetRequests();
            return Ok(requests);
        }

        [HttpPost]
        [Route("shift-swap")]
        public IActionResult OfferSwap([FromBody] SwapRequest newRequest)
        {
            jsonDataAccess.AddRequest(newRequest);
            return Ok(newRequest);
        }

        [HttpPut]
        [Route("shift-swap")]
        public IActionResult UpdateRequest([FromBody] SwapRequest updatedRequest)
        {
            jsonDataAccess.UpdateRequest(updatedRequest);
            return Ok(updatedRequest);
        }
    }
}
