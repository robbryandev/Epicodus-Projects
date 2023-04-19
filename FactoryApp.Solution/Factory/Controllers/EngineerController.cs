using Microsoft.AspNetCore.Mvc;
using Factory.Models;

namespace Factory.Controllers
{
  public class EngineerController : Controller
  {
    private readonly FactoryContext _db;
    public EngineerController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/engineer")]
    public ActionResult Index()
    {
      List<Engineer> allEngineers = _db.Engineers.ToList();
      return View(allEngineers);
    }

    [HttpGet("/engineer/{id}")]
    public ActionResult View(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(eng => eng.engineer_id == id);
      List<Machine> machines = new List<Machine> { };
      List<EngineerMachine> matchList = _db.EngineerMachines.Where(engmac => engmac.engineer_id == id).ToList();
      List<Machine> matches = new List<Machine> { };
      foreach (EngineerMachine engmac in matchList)
      {
        Machine thisMachine = _db.Machines.FirstOrDefault(mac => mac.machine_id == engmac.machine_id);
        matches.Add(thisMachine);
      }
      foreach (Machine mac in _db.Machines.ToList())
      {
        if (matches.Contains(mac) == false)
        {
          machines.Add(mac);
        }
      }
      ViewBag.matches = matches;
      ViewBag.machines = machines;
      return View(thisEngineer);
    }

    [HttpPost("/engineer/{id}/add")]
    public ActionResult ViewMachine(int id, string machine)
    {
      EngineerMachine newMatch = new EngineerMachine();
      newMatch.engineer_id = id;
      newMatch.machine_id = int.Parse(machine);
      if (_db.EngineerMachines.Contains(newMatch) == false)
      {
        _db.EngineerMachines.Add(newMatch);
        _db.SaveChanges();
      }
      return Redirect($"/engineer/{id}");
    }

    [HttpGet("/engineer/add")]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost("/engineer/add")]
    public ActionResult AddConfirm(Engineer engineer)
    {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      return Redirect("/engineer");
    }

    [HttpGet("/engineer/delete/{id}")]
    public ActionResult Delete(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(eng => eng.engineer_id == id);
      return View(thisEngineer);
    }

    [HttpPost("/engineer/delete/{id}")]
    public ActionResult DeleteConfirm(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(eng => eng.engineer_id == id);
      List<EngineerMachine> thisMatches = _db.EngineerMachines.Where(engmac => engmac.engineer_id == id).ToList();
      foreach (EngineerMachine engmac in thisMatches)
      {
        _db.EngineerMachines.Remove(engmac);
      }
      _db.Engineers.Remove(thisEngineer);
      _db.SaveChanges();
      return Redirect("/engineer");
    }

    [HttpPost("/engineer/{id}/remove/{mac}")]
    public ActionResult Remove(int id, string mac)
    {
      EngineerMachine thisLink = _db.EngineerMachines.FirstOrDefault(engmac =>
        engmac.engineer_id == id &&
        engmac.machine_id == int.Parse(mac)
       );
      _db.EngineerMachines.Remove(thisLink);
      _db.SaveChanges();
      return Redirect($"/engineer/{id}");
    }

    [HttpGet("/engineer/update/{id}")]
    public ActionResult Update(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(eng => eng.engineer_id == id);
      return View(thisEngineer);
    }

    [HttpPost("/engineer/update/{id}")]
    public ActionResult UpdateConfirm(int id, string name)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(eng => eng.engineer_id == id);
      thisEngineer.name = name;
      _db.Engineers.Update(thisEngineer);
      _db.SaveChanges();
      return Redirect($"/engineer/{id}");
    }
  }
}