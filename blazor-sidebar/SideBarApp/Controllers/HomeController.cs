using Microsoft.AspNetCore.Mvc;
using SideBar.Models;

namespace SideBar.Controllers
{
  public class HomeController : Controller
  {
    private readonly SideBarContext _db;
    public HomeController(SideBarContext db)
    {
      _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index() {
      return View();
    }
  }
}