using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServiceAPI.Models;

namespace WebServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyDataController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] MyDataModel data)
        {
            if (data == null)
            {
                return BadRequest("Invalid data.");
            }
            return Ok(new { Message = "Data received successfully!", Data = data });
        }
    }
}
