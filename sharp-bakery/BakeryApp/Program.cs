using System;
using System.Collections.Generic;
using Spectre.Console;

namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      // Send picture
      CanvasImage image = new CanvasImage("images/bakery.png");
      image.NoMaxWidth();

      AnsiConsole.Write(image);

      // Send intro msg
      AnsiConsole.MarkupLine("[dodgerblue1]Welcome to Pierre's Bakery[/]");
      AnsiConsole.MarkupLine("[deepskyblue3]Here is our bread deal (buy 2 get 1 free)(per type of bread and order sub item)[/]");
      AnsiConsole.MarkupLine("[deepskyblue3]Here is our pastry deal (buy 2 get 1 half off)(per type of pastry and order sub item)[/]");
      AnsiConsole.MarkupLine("[springgreen1]Press any key to continue[/]");
      Console.ReadLine();
      Console.Clear();

      bool close = false;
      int total = 0;
      while (!close)
      {
        string product = BuyMenu();
        switch (product)
        {
          case "bread":
            string breadType = OpenBreadMenu();
            int breadAmount = GetAmount("How many loaves of bread would you like?");
            total += Bread.GetPrice(breadAmount, breadType);
            break;
          case "pastry":
            string pastryType = OpenPastryMenu();
            int pastryAmount = GetAmount("How many pastries would you like?");
            total += Pastry.GetPrice(pastryAmount, pastryType);
            break;
          case "done":
            close = true;
            break;
        }
      }

      // Print total
      AnsiConsole.MarkupLine(String.Format("[springgreen1]Your order total is: ${0}[/]", total));
    }
    public static int GetAmount(string phrase)
    {
      // Ask phrase
      AnsiConsole.MarkupLine(String.Format("[springgreen1]{0}[/]", phrase));

      // Validate user entered something
      string strInput = "";
      string? getInput = Console.ReadLine();
      Console.Clear();
      if (getInput != null)
      {
        strInput = getInput;
      }

      // Validate user entered a number
      int input = 0;
      bool canParse = int.TryParse(strInput, out input);
      if (!canParse)
      {
        AnsiConsole.MarkupLine("[red]Invalid input[/]");
        Environment.Exit(1);
      }
      return input;
    }
    public static string BuyMenu()
    {
      string result = AnsiConsole.Prompt(
          new SelectionPrompt<string>()
              .Title("[blue]What would you like to buy?[/]")
              .PageSize(3)
              .AddChoices(new[] { "[darkorange3]Bread[/]", "[salmon1]Pastry[/]", "[red]Done[/]" }));
      Console.Clear();
      return result.Split("]", 2)[1].Replace("[/]", "").ToLower();
    }
    public static string OpenBreadMenu()
    {
      List<string> breadList = new List<string> { };
      foreach (KeyValuePair<string, int> b in Bread.prices)
      {
        breadList.Add(String.Format("[green](${0})[/] [orange3]{1}[/]", b.Value, b.Key));
      }
      string result = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[darkorange3]What kind of bread would you like?[/]")
            .PageSize(Bread.prices.Count)
            .AddChoices(breadList));
      result = result.Split("[orange3]")[1].Replace("[/]", "");
      Console.Clear();
      return result;
    }
    public static string OpenPastryMenu()
    {
      List<string> pastryList = new List<string> { };
      foreach (KeyValuePair<string, int> p in Pastry.prices)
      {
        pastryList.Add(String.Format("[green](${0})[/] [lightsalmon1]{1}[/]", p.Value, p.Key));
      }
      string result = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[salmon1]What kind of pastry would you like?[/]")
            .PageSize(Pastry.prices.Count)
            .AddChoices(pastryList));
      result = result.Split("[lightsalmon1]")[1].Replace("[/]", "");
      Console.Clear();
      return result;
    }
  }
}