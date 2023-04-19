using Microsoft.AspNetCore.Mvc;
using BakeryMVCApp.Models;

namespace BakeryMVCApp.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor/all")]
    public ActionResult All() {
        return View();
    }

    [HttpGet("/vendor/new")]
    public ActionResult New() {
      return View();
    }

    [HttpPost("/vendor/new/submit")]
    public RedirectResult New(string name, string description) {
        new Vendor(name, description);
        return Redirect("/vendor/all");
    }
  }
}