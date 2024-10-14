using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resturent.Application.Resturents;
using Resturent.Models.Repositories;

namespace ResturentProject.Controllers
{
    [Route("api/resturents")]
    [ApiController]
    public class ResturentController(IResturentService resturentService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var resturents= await resturentService.GetAllResturents();
           return Ok(resturents);
        }
    }
}
