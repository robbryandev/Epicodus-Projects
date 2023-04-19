using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using GalleryGram.Models;
using System.Threading.Tasks;
using GalleryGram.ViewModels;
using System.Security.Claims;

namespace GalleryGram.Controllers
{
  public class AccountController : Controller
  {
    private readonly GalleryGramContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, GalleryGramContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      
      if (userId != null)
      {
        List<Picture> pictures = _db.Pictures
          .Where(pic => pic.user_id == userId)
          .ToList();
        ViewBag.pictures = pictures;
        List<Likes> userLikes = _db.Likes
          .Where(like => like.user_id == userId)
          .ToList();
        List<Picture> likedPictures = _db.Pictures
          .ToList()
          .Where(pic => userLikes.Any(like => like.picture_id == pic.picture_id))
          .ToList();
        ViewBag.likes = likedPictures;
      }

      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      else
      {
        ApplicationUser user = new ApplicationUser { UserName = model.Email };
        IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
          return RedirectToAction("Index");
        }
        else
        {
          foreach (IdentityError error in result.Errors)
          {
            ModelState.AddModelError("", error.Description);
          }
          return View(model);
        }
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      else
      {
        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
        if (result.Succeeded)
        {
          return RedirectToAction("Index");
        }
        else
        {
          ModelState.AddModelError("", "There is something wrong with your email or username. Please try again.");
          return View(model);
        }
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}