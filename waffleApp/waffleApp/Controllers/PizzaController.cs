using Microsoft.AspNetCore.Mvc;
using waffle.Models;

namespace waffle.Controllers
{
  public class PizzaController : Controller
  {
    private readonly waffleContext _db;
    public PizzaController(waffleContext db)
    {
      _db = db;
    }
    
    [HttpGet("/pizza")]
    public ActionResult Index() {
      List<Pizza> pizzaz = _db.pizzas.ToList();
      return View(pizzaz);
    }

    [HttpGet("/pizza/add")]
    public ActionResult Add() {
      return View();
    }

    [HttpPost("/pizza/add")]
    public ActionResult Add(Pizza pz) {
      _db.pizzas.Add(pz);
      _db.SaveChanges();
      return Redirect("/pizza");
    }
  }
}