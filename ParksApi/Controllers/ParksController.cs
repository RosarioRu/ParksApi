using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;
using Microsoft.AspNetCore.JsonPatch;


namespace ParksApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {

    private readonly ParksApiContext _db;

    public ParksController(ParksApiContext db)
    {
      _db = db;
    }

    // GET api/Parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      return await _db.Parks.ToListAsync();
    }

    // POST api/Parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    //Get api/Parks/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark (int id)
    {
      var park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    // PUT: api/Parks/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    { 
      if ((id != park.ParkId) || (park.AreaInAcres <= 0) || (park.DateEstablished.Year <1872))
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }


    // PATCH: api/Parks/{id}
    [HttpPatch("{id}")]
    public IActionResult Patch(int id, [FromBody] JsonPatchDocument<Park> patchParkToPatch)
    {
      var parkToPatch = Parks.FirstOrDefault(park => park.Id == id);
 
      if (parkToPatch == null)
      {
        return NotFound();
      }
 
      patchParkToPatch.ApplyTo(parkToPatch, ModelState); // Must have Microsoft.AspNetCore.Mvc.NewtonsoftJson installed
    
      return Ok(parkToPatch);
    }


    // // PATCH: api/Parks/{id}
    // [HttpPatch("{id}")]
    // public async Task<IActionResult> Patch(int id)
    // { 
    //   if (!ParkExists(id))
    //   {
    //     return NotFound();
    //   }
    //   else
    //   {
    //   var parkToPatch = await _db.Parks.FindAsync(id);
    //   return (parkToPatch;
    //   }
    
    // }


    //Method to check if a Park is already in System
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

  }
}