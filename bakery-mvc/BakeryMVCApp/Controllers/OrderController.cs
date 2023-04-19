using Microsoft.AspNetCore.Mvc;
using BakeryMVCApp.Models;

namespace BakeryMVCApp.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/orders/{id}/new")]
    public ActionResult New(int id) {
        return View(Vendor.GetAll()[id]);
    }

    [HttpPost("/orders/{id}/new/submit")]
    public ActionResult New(int id, string title, string description, string price, string date) {
        double newPrice = double.Parse(price);
        string[] splitDate = date.Split("-");
        List<int> newDate = new List<int>{int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2])};
        Vendor.GetAll()[id].Orders.Add(new Order(title, description, newPrice, newDate));
        return Redirect("/vendor/all");
    }
  }
}