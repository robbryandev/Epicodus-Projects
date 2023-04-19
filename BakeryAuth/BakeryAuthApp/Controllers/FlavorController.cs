using Microsoft.AspNetCore.Mvc;
using BakeryAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BakeryAuth.Controllers
{
  [Authorize]
  public class FlavorController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly BakeryAuthContext _db;
    public FlavorController(UserManager<ApplicationUser> userManager, BakeryAuthContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    
    [AllowAnonymous]
    [HttpGet("/flavor")]
    public async Task<ActionResult> Index() {
      List<Flavor> flavors = _db.flavors.ToList();
      ViewBag.flavors = flavors;
      string? userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      if (userId != null)
      {
        ApplicationUser user = await _userManager.FindByIdAsync(userId);
        List<Flavor> my_flavors = _db.flavors
          .Where(fl => fl.user_id == user.Id)
          .ToList();
        ViewBag.my_flavors = my_flavors;        
        return View(user);
      } else {
        return View();
      }
    }

    [HttpGet("/flavor/create")]
    public ActionResult Create() {
      return View();
    }

    [HttpPost("/flavor/create")]
    public ActionResult CreateConfirm(Flavor flavor) {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      Flavor newFlavor = flavor;
      newFlavor.user_id = userId;
      _db.flavors.Add(newFlavor);
      _db.SaveChanges();
      return Redirect("/flavor");
    }

    [AllowAnonymous]
    [HttpGet("/flavor/details/{id}")]
    public ActionResult Details(int id) {
      Flavor thisFlavor = _db.flavors.FirstOrDefault(fl => fl.flavor_id == id);
      List<TreatFlavor> joins = _db.treatFlavors
        .Where(join => join.flavor_id == id)
        .ToList();
      List<Treat> treats = new List<Treat>{};
      foreach (Treat treat in _db.treats.ToList())
      {
        bool inJoin = joins.Any(join => join.treat_id == treat.treat_id);
        if (inJoin == true)
        {
          treats.Add(treat);
        }
      }
      ViewBag.treats = treats;
      return View(thisFlavor);
    }

    [HttpGet("/flavor/update/{id}")]
    public ActionResult Update(int id) {
      Flavor thisFlavor = _db.flavors.FirstOrDefault(fl => fl.flavor_id == id);
      List<TreatFlavor> joins = _db.treatFlavors
        .Where(join => join.flavor_id == thisFlavor.flavor_id)
        .ToList();
      List<Treat> AllTreats = _db.treats.ToList();
      List<Treat> treats = new List<Treat>{};
      foreach (Treat treat in AllTreats)
      {
        bool inJoin = joins.Any(j => j.treat_id == treat.treat_id);
        if (inJoin == false)
        {
          treats.Add(treat);
        }
      }
      ViewBag.treats = treats;
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Update(Flavor flavor) {
      _db.flavors.Update(flavor);
      _db.SaveChanges();
      return Redirect("/flavor");
    }

    [HttpPost("/flavor/update/{id}/treat")]
    public ActionResult AddFlavor(int id, int treat_id) {
      TreatFlavor newJoin = new TreatFlavor();
      newJoin.flavor_id = id;
      newJoin.treat_id = treat_id;
      _db.treatFlavors.Add(newJoin);
      _db.SaveChanges();
      return Redirect("/flavor");
    }

    [HttpGet("/flavor/delete/{id}")]
    public ActionResult Delete(int id) {
      Flavor thisFlavor = _db.flavors.FirstOrDefault(fl => fl.flavor_id == id);
      return View(thisFlavor);
    }

    [HttpPost("/flavor/delete/{id}")]
    public ActionResult DeleteConfirm(int id) {
      Flavor thisFlavor = _db.flavors.FirstOrDefault(fl => fl.flavor_id == id);
      List<TreatFlavor> joins = _db.treatFlavors.Where(join => join.flavor_id == thisFlavor.flavor_id).ToList();
      foreach (TreatFlavor join in joins)
      {
        _db.treatFlavors.Remove(join);
      }
      _db.flavors.Remove(thisFlavor);
      _db.SaveChanges();
      return Redirect("/flavor");
    }

    [HttpPost("/flavor/delete/join/{id}/{treat_id}")]
    public ActionResult DeleteTreat(int id, int treat_id) {
      List<TreatFlavor> joins = _db.treatFlavors
        .Where(join => join.flavor_id == id &&
        join.treat_id == treat_id)
        .ToList();
      foreach (TreatFlavor join in joins)
      {
        _db.treatFlavors.Remove(join);
      }
      _db.SaveChanges();
      return Redirect($"/flavor/details/{id}");
    }
  }
}