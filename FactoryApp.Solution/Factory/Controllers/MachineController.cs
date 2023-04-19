using Microsoft.AspNetCore.Mvc;
using Factory.Models;

namespace Factory.Controllers
{
  public class MachineController : Controller
  {
    private readonly FactoryContext _db;
    public MachineController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/machine")]
    public ActionResult Index()
    {
      List<Machine> allMachines = _db.Machines.ToList();
      return View(allMachines);
    }

    [HttpGet("/machine/{id}")]
    public ActionResult View(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(mac => mac.machine_id == id);
      List<Engineer> engineers = new List<Engineer> { };
      List<EngineerMachine> matchList = _db.EngineerMachines.Where(engmac => engmac.machine_id == id).ToList();
      List<Engineer> matches = new List<Engineer> { };
      foreach (EngineerMachine engmac in matchList)
      {
        Engineer thisEngineer = _db.Engineers.FirstOrDefault(eng => eng.engineer_id == engmac.engineer_id);
        matches.Add(thisEngineer);
      }
      foreach (Engineer eng in _db.Engineers.ToList())
      {
        if (matches.Contains(eng) == false)
        {
          engineers.Add(eng);
        }
      }
      ViewBag.matches = matches;
      ViewBag.engineers = engineers;
      return View(thisMachine);
    }

    [HttpPost("/machine/{id}/add")]
    public ActionResult ViewEngineer(int id, string engineer)
    {
      EngineerMachine newMatch = new EngineerMachine();
      newMatch.machine_id = id;
      newMatch.engineer_id = int.Parse(engineer);
      if (_db.EngineerMachines.Contains(newMatch) == false)
      {
        _db.EngineerMachines.Add(newMatch);
        _db.SaveChanges();
      }
      return Redirect($"/machine/{id}");
    }

    [HttpGet("/machine/add")]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost("/machine/add")]
    public ActionResult AddConfirm(Machine machine)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      return Redirect("/machine");
    }

    [HttpGet("/machine/delete/{id}")]
    public ActionResult Delete(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(mac => mac.machine_id == id);
      return View(thisMachine);
    }

    [HttpPost("/machine/delete/{id}")]
    public ActionResult DeleteConfirm(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(mac => mac.machine_id == id);
      List<EngineerMachine> thisMatches = _db.EngineerMachines.Where(engmac => engmac.machine_id == id).ToList();
      foreach (EngineerMachine engmac in thisMatches)
      {
        _db.EngineerMachines.Remove(engmac);
      }
      _db.Machines.Remove(thisMachine);
      _db.SaveChanges();
      return Redirect("/machine");
    }

    [HttpPost("/machine/{id}/remove/{eng}")]
    public ActionResult Remove(int id, string eng)
    {
      EngineerMachine thisLink = _db.EngineerMachines.FirstOrDefault(engmac =>
        engmac.machine_id == id &&
        engmac.engineer_id == int.Parse(eng)
       );
      _db.EngineerMachines.Remove(thisLink);
      _db.SaveChanges();
      return Redirect($"/machine/{id}");
    }

    [HttpGet("/machine/update/{id}")]
    public ActionResult Update(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(mac => mac.machine_id == id);
      return View(thisMachine);
    }

    [HttpPost("/machine/update/{id}")]
    public ActionResult UpdateConfirm(int id, string name)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(mac => mac.machine_id == id);
      thisMachine.name = name;
      _db.Machines.Update(thisMachine);
      _db.SaveChanges();
      return Redirect($"/machine/{id}");
    }
  }
}