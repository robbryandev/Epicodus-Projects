using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupApi.Models;

namespace ParksLookupApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParkController : ControllerBase
  {
    private readonly ParksLookupApiContext _db;

    public ParkController(ParksLookupApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();
      if (name != null)
      {
        query = query.Where(pa => pa.name.Contains(name));
      }
      return await query.ToListAsync();
    }

    [HttpGet("random")]
    public async Task<ActionResult<Park>> GetRandom()
    {
      List<Park> allParks = await _db.Parks.ToListAsync();
      Random rnd = new Random();
      Park randPark = allParks[rnd.Next(0, allParks.Count() - 1)];
      return randPark;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();
      query = query.Where(pa => pa.park_id == id);
      List<Park> parkQuery = await query.ToListAsync();
      if (parkQuery.Count() == 0)
      {
        return NotFound();
      }
      return parkQuery[0];
    }

    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      if (park.park_id != null)
      {
        return BadRequest();
      }
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.park_id }, park);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.park_id)
      {
        return BadRequest();
      }

      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
      List<Park> allParks = await _db.Parks.ToListAsync();
      bool parkExists = allParks.Any(pa => pa.park_id == id);
      if (!parkExists)
        {
          return NotFound();
        } else {
            throw;
        }
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
      List<Park> allParks = await _db.Parks.ToListAsync();
      bool parkExists = allParks.Any(pa => pa.park_id == id);
      if (!parkExists)
      {
        return NotFound();
      }
      Park park = allParks.FirstOrDefault(pa => pa.park_id == id);
      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}