using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupApi.Models;

namespace ParksLookupApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateController : ControllerBase
  {
    private readonly ParksLookupApiContext _db;

    public StateController(ParksLookupApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<State>>> Get(string name)
    {
      IQueryable<State> query = _db.States.AsQueryable();
      if (name != null)
      {
        query = query.Where(st => st.name.Contains(name));
      }
      return await query.ToListAsync();
    }

    [HttpGet("random")]
    public async Task<ActionResult<State>> GetRandom()
    {
      List<State> allStates = await _db.States.ToListAsync();
      Random rnd = new Random();
      State randState = allStates[rnd.Next(0, allStates.Count() - 1)];
      return randState;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<State>> GetState(int id)
    {
      IQueryable<State> query = _db.States.AsQueryable();
      query = query.Where(st => st.state_id == id);
      List<State> stateQuery = await query.ToListAsync();
      if (stateQuery.Count() == 0)
      {
        return NotFound();
      }
      return stateQuery[0];
    }

    [HttpPost]
    public async Task<ActionResult<State>> Post(State state)
    {
      if (state.state_id != null)
      {
        return BadRequest();
      }
      _db.States.Add(state);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetState), new { id = state.state_id }, state);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, State state)
    {
      if (id != state.state_id)
      {
        return BadRequest();
      }

      _db.States.Update(state);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        List<State> allStates = await _db.States.ToListAsync();
        bool stateExists = allStates.Any(st => st.state_id == id);
        if (!stateExists)
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
      List<State> allStates = await _db.States.ToListAsync();
      bool stateExists = allStates.Any(st => st.state_id == id);
      if (!stateExists)
      {
        return NotFound();
      }
      State state = allStates.FirstOrDefault(st => st.state_id == id);
      _db.States.Remove(state);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}