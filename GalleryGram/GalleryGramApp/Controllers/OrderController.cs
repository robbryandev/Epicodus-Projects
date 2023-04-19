using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using GalleryGram.Models;
using GalleryGram.ViewModels;
using System.Security.Claims;
using System.Globalization;
using GalleryGram.ResponseModels;
namespace GalleryGram.Controllers
{
  public class OrderController : Controller
  {
    private readonly GalleryGramContext _db;
    private IWebHostEnvironment _hostingEnvironment;
    private readonly UserManager<ApplicationUser> _userManager;
    public OrderController(GalleryGramContext db, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _hostingEnvironment = environment;
      _userManager = userManager;
    }
    
    [HttpGet("/order/create/{pictureId}")]
    public ActionResult Create(int pictureId)
    {
      ViewBag.pictureId = pictureId;
      return View();
    }

    [HttpPost("/order/create/{pictureId}")]
    public async Task<ActionResult> Create(OrderViewModel vModel, int pictureId)
    {
      if (!ModelState.IsValid)
      {
        ViewBag.pictureId = pictureId;
        return View(vModel);
      } else {
          string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
          // User name is currently the email
          string userName = HttpContext.User.Identity.Name;
          string userEmail = userName;

          GalleryGram.Models.Address newAddress = new GalleryGram.Models.Address();
          newAddress.line1 = vModel.line1;
          newAddress.line2 = vModel.line2;
          newAddress.postalOrZipCode = vModel.postalOrZipCode;
          newAddress.countryCode = vModel.countryCode;
          newAddress.townOrCity = vModel.townOrCity;
          newAddress.stateOrCounty = vModel.stateOrCounty;

          Picture thisPic = _db.Pictures
            .FirstOrDefault(entry => entry.picture_id == pictureId);
          GalleryGram.Models.Asset newAsset = new GalleryGram.Models.Asset() {
            printArea = "default",
            url = thisPic.fileName 
          };

          OrderResponse response = await OrderRequest.Post(newAddress, newAsset, userName, userEmail);

          DbOrder newOrder = new DbOrder();
          newOrder.user_id = userId;
          newOrder.confirmation_id = response.order.id;
          newOrder.status = response.order.status.stage;
          newOrder.cost = "9.99"; //response.order.items[0].recipientCost.amount is null for some reason;

          _db.DbOrders.Add(newOrder);
          _db.SaveChanges();

          return Redirect($"/order/confirm/{newOrder.confirmation_id}"); 
      }
    }

    [HttpGet("/order/confirm/{confirmation_id}")]
    public ActionResult Confirm(string confirmation_id)
    {
      DbOrder order = _db.DbOrders
        .FirstOrDefault(entry => entry.confirmation_id == confirmation_id);

      return View(order);
    }
  }
}