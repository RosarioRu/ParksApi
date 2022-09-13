using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;


namespace ParksApi.Controllers
{
  [Produces("application/json")]
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
    ///<summary>Returns a list of all the Parks in the database, or only those that meet search criteria when it is provided</summary>
    ///<returns>A list of Parks</returns>
    ///<param name="name">name of Park</param>
    ///<param name="city">city where park is located, or closest city if Park is not located in a city</param>
    ///<param name="state">state where park is located</param>
    ///<param name="year">year when Park was established</param>
    ///<param name="acres">park acreage</param>
    ///<param name="type">enter: National Park, or, State Park</param>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string city, string state, int year, double acres, string type)
    {
      var query = _db.Parks.AsQueryable();
      if (name != null)
      {
        query = query.Where(e => e.ParkName.Contains(name)); //using contains over a perfect match in case client only enters part of the name
      }
      if (city != null)
      {
        query = query.Where(e => e.CityOrClosestCity == city);
      }
      if (state != null)
      {
        query = query.Where(e => e.State == state);
      }
      if (year >0)
      {
        query = query.Where(e => e.DateEstablished.Year == year);
      }
      if (acres > 0)
      {
        query = query.Where(e => e.AreaInAcres == acres);
      }
      if (type != null)
      {
        query = query.Where(e => e.StateOrNational.Contains(type));
      }
      return await query.ToListAsync();
    }

    // POST api/Parks
    ///<summary>Adds a Park to the database</summary>
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    //Get api/Parks/{id}
    ///<summary>Returns a specific Park that matches provided ID#</summary>
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
    ///<summary>Updates the entire entry for a specific Park</summary>
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
    ///<summary>Partially updates a specific Park</summary>
    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, [FromBody] JsonPatchDocument<Park> patchParkToPatch)
    {
      var parkToPatch = _db.Parks.FirstOrDefault(e => e.ParkId == id);

      if (parkToPatch == null)
      {
        return NotFound();
      }

      patchParkToPatch.ApplyTo(parkToPatch, ModelState);
      
      _db.Entry(parkToPatch).State = EntityState.Modified;
      await _db.SaveChangesAsync();
    
      return Ok(parkToPatch);
    }

    // DELETE: api/Parks/{id}
    ///<summary>Deletes the specific Park that matches the provided ID#</summary>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      if (!(ParkExists(id)))
      {
        return NotFound();
      }

      _db.Parks.Remove(await _db.Parks.FindAsync(id));
      await _db.SaveChangesAsync();

      return NoContent();
    }

    //Method to check if a Park is already in System
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

  }
}