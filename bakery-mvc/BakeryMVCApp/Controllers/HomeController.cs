using Microsoft.AspNetCore.Mvc;
using BakeryMVCApp.Models;

namespace BakeryMVCApp.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() {
      return View();
    }
  }
}