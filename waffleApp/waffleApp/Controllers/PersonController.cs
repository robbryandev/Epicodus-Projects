using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using waffle.Models;

namespace waffle.Controllers
{
  public class PersonController : Controller
  {
    private readonly waffleContext _db;
    public PersonController(waffleContext db)
    {
      _db = db;
    }
    
    [HttpGet("/person")]
    public ActionResult Index() {
      List<People> peoples = _db.peoples.ToList();
      return View(peoples);
    }

    [HttpGet("/person/add")]
    public ActionResult Add() {
      return View();
    }

    [HttpGet("/person/update/{id}")]
    public ActionResult Update(int id) {
      People thisPerson = _db.peoples.FirstOrDefault(pz => pz.person_id == id);
      return View(thisPerson);
    }

    [HttpPost("/person/add")]
    public ActionResult Add(People person) {
      _db.peoples.Add(person);
      _db.SaveChanges();
      return Redirect("/person");
    }
  }
}