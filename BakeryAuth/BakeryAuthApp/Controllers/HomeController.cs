using Microsoft.AspNetCore.Mvc;
using BakeryAuth.Models;

namespace BakeryAuth.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryAuthContext _db;
    public HomeController(BakeryAuthContext db)
    {
      _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index() {
      ViewBag.treats = _db.treats.ToList();
      ViewBag.flavors = _db.flavors.ToList();
      return View();
    }
  }
}