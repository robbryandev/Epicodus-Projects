namespace rpsApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Player 1 (rock, paper, scissors):");
            string p1 = Console.ReadLine();
            Console.WriteLine("Player 2 (rock, paper, scissors):");
            string p2 = Console.ReadLine();
            Console.WriteLine(rpsLogic.rpsWinCon(p1, p2));
        }
    }
}