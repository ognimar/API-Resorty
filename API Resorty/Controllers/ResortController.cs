using API_Resorty.Data;
using API_Resorty.Entities;

using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;


namespace API_Resorty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResortController : ControllerBase
    {
        private readonly DataContext Context;

        public ResortController(DataContext context)
        {
            Context = context;
        }
      
        [HttpGet]
        public async Task<ActionResult<List<Resort>>> Get()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok(await Context.Resorts.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Resort>>> AddNewResort(Resort ressort)
        {

            Context.Resorts.Add(ressort);
            await Context.SaveChangesAsync();
            return Ok(ressort.Id);
        }

         [HttpPut]
        public async Task<ActionResult<List<Resort>>> UpdateExistingResort(Resort request)
        {
            var dbResort = await Context.Resorts.FindAsync(request.Id);
            if (dbResort == null)
                return BadRequest("resort not found.");

            dbResort.Name = request.Name;
            dbResort.Destination = request.Destination;
            dbResort.Price = request.Price;
            dbResort.Rating = request.Rating;

            await Context.SaveChangesAsync();
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok(await Context.Resorts.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Resort>>> Delete(int Id)
        {
            var ressort = Context.Resorts.Find(Id);
            if (ressort == null)
                return BadRequest("Resort not found.");

            Context.Resorts.Remove(ressort);
            await Context.SaveChangesAsync();

            return Ok(await Context.Resorts.ToListAsync());
        }

        [HttpOptions]
        public IActionResult Options()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Allow", "OPTIONS,GET,POST,PUT,DELETE");
            return Ok();
        }
    }
}
