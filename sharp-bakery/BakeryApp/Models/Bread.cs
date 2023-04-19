using System.Collections.Generic;

namespace BakeryApp
{
  public class Bread
  {
    public static Dictionary<string, int> prices = new Dictionary<string, int> {
      {"bread", 5},
      {"white", 5},
      {"whole_wheat", 5},
      {"multigrain", 6},
      {"rye", 7},
      {"sourdough", 7},
      {"pumpernickel", 8},
      {"baguette", 6},
      {"boule", 8},
      {"ciabatta", 7},
      {"challah", 7},
      {"brioche", 8},
      {"flatbread", 4},
      {"english_muffin", 4},
      {"bagel", 3},
      {"bialy", 4}
    };
    public static int GetPrice(int amount, string type = "bread")
    {
      int price = prices[type];
      int dealAmount = (int)(amount / 3);
      int resultPrice = (int)((amount - dealAmount) * price);
      return resultPrice;
    }
  }
}