using Microsoft.AspNetCore.Mvc;
using GalleryGram.Models;

namespace GalleryGram.Controllers
{
  public class HomeController : Controller
  {
    private readonly GalleryGramContext _db;
    public HomeController(GalleryGramContext db)
    {
      _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index() {
      return View();
    }
  }
}