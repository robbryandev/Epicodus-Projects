using Microsoft.AspNetCore.Mvc;
using BakeryAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BakeryAuth.Controllers
{
  [Authorize]
  public class TreatController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly BakeryAuthContext _db;
    public TreatController(UserManager<ApplicationUser> userManager, BakeryAuthContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    
    [AllowAnonymous]
    [HttpGet("/treat")]
    public async Task<ActionResult> Index() {
      List<Treat> treats = _db.treats.ToList();
      ViewBag.treats = treats;
      string? userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      if (userId != null)
      {
        ApplicationUser user = await _userManager.FindByIdAsync(userId);
        List<Treat> my_treats = _db.treats
          .Where(tr => tr.user_id == user.Id)
          .ToList();
        ViewBag.my_treats = my_treats;        
        return View(user);
      } else {
        return View();
      }
    }

    [HttpGet("/treat/create")]
    public ActionResult Create() {
      return View();
    }

    [HttpPost("/treat/create")]
    public ActionResult CreateConfirm(Treat treat) {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      Treat newTreat = treat;
      newTreat.user_id = userId;
      _db.treats.Add(newTreat);
      _db.SaveChanges();
      return Redirect("/treat");
    }

    [AllowAnonymous]
    [HttpGet("/treat/details/{id}")]
    public ActionResult Details(int id) {
      Treat thisTreat = _db.treats.FirstOrDefault(tr => tr.treat_id == id);
      List<TreatFlavor> joins = _db.treatFlavors
        .Where(join => join.treat_id == thisTreat.treat_id)
        .ToList();
      List<Flavor> flavors = new List<Flavor>{};
      foreach (Flavor flavor in _db.flavors.ToList())
      {
        bool inJoin = joins.Any(j => j.flavor_id == flavor.flavor_id);
        if (inJoin == true)
        {
          flavors.Add(flavor);
        }
      }
      ViewBag.flavors = flavors;
      return View(thisTreat);
    }

    [HttpGet("/treat/update/{id}")]
    public ActionResult Update(int id) {
      Treat thisTreat = _db.treats.FirstOrDefault(tr => tr.treat_id == id);
      List<TreatFlavor> joins = _db.treatFlavors
        .Where(join => join.treat_id == thisTreat.treat_id)
        .ToList();
      List<Flavor> AllFlavors = _db.flavors.ToList();
      List<Flavor> flavors = new List<Flavor>{};
      foreach (Flavor flavor in AllFlavors)
      {
        bool inJoin = joins.Any(j => j.flavor_id == flavor.flavor_id);
        if (inJoin == false)
        {
          flavors.Add(flavor);
        }
      }
      ViewBag.flavors = flavors;
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Update(Treat treat) {
      _db.treats.Update(treat);
      _db.SaveChanges();
      return Redirect("/treat");
    }

    [HttpPost("/treat/update/{id}/flavor")]
    public ActionResult AddFlavor(int id, int flavor_id) {
      TreatFlavor newJoin = new TreatFlavor();
      newJoin.treat_id = id;
      newJoin.flavor_id = flavor_id;
      _db.treatFlavors.Add(newJoin);
      _db.SaveChanges();
      return Redirect("/treat");
    }

    [HttpGet("/treat/delete/{id}")]
    public ActionResult Delete(int id) {
      Treat thisTreat = _db.treats.FirstOrDefault(tr => tr.treat_id == id);
      return View(thisTreat);
    }

    [HttpPost("/treat/delete/{id}")]
    public ActionResult DeleteConfirm(int id) {
      Treat thisTreat = _db.treats.FirstOrDefault(tr => tr.treat_id == id);
      List<TreatFlavor> joins = _db.treatFlavors.Where(join => join.treat_id == thisTreat.treat_id).ToList();
      foreach (TreatFlavor join in joins)
      {
        _db.treatFlavors.Remove(join);
      }
      _db.treats.Remove(thisTreat);
      _db.SaveChanges();
      return Redirect("/treat");
    }

    [HttpPost("/treat/delete/join/{id}/{flavor_id}")]
    public ActionResult DeleteFlavor(int id, int flavor_id) {
      List<TreatFlavor> joins = _db.treatFlavors
        .Where(join => join.treat_id == id &&
        join.flavor_id == flavor_id)
        .ToList();
      foreach (TreatFlavor join in joins)
      {
        _db.treatFlavors.Remove(join);
      }
      _db.SaveChanges();
      return Redirect($"/treat/details/{id}");
    }
  }
}