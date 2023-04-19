using Microsoft.AspNetCore.Mvc;
using waffle.Models;

namespace waffle.Controllers
{
  public class HomeController : Controller
  {
    private readonly waffleContext _db;
    public HomeController(waffleContext db)
    {
      _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index() {
      return View();
    }
  }
}