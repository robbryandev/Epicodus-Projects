namespace ScrabbleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter A Word For Me To Score:");
            string? wordInp = Console.ReadLine();
            string letterStr = "AEIOULNRST\nDG\nBCMP\nFHVWY\nK\nJX\nQZ";
            string[] letters = letterStr.Split("\n");
            Console.WriteLine("The words score is " + Scrabble.GetScore(wordInp, letters));
            Main();
        }
    }
}