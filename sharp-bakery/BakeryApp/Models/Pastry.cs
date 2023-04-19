using System.Collections.Generic;

namespace BakeryApp
{
  public class Pastry
  {
    public static Dictionary<string, int> prices = new Dictionary<string, int> {
      {"pastry", 2},
      {"doughnut", 2},
      {"cupcake", 2},
      {"danish", 4},
      {"tart", 4},
      {"profiteroles", 6},
      {"baklava", 6},
      {"strudel", 4}
    };
    public static int GetPrice(int amount, string type = "pastry")
    {
      int price = prices[type];
      int dealAmount = (int)(amount / 3);
      int normalPrice = (int)((amount - dealAmount) * price);
      int halfPrice = (int)(dealAmount * (price / 2));
      int resultPrice = normalPrice + halfPrice;
      return resultPrice;
    }
  }
}