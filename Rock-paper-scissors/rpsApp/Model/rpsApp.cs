namespace rpsApp
{
    public class rpsLogic
    {
        public static string rpsWinCon(string p1, string p2)
        {
            List<string> wins = new List<string> { "scissors", "rock", "paper" };
            string winner = "rock";

            switch (p1)
            {
                case "rock":
                    winner = p2 == wins[0] ? p1 : p2;
                    break;
                case "paper":
                    winner = p2 == wins[1] ? p1 : p2;
                    break;
                case "scissors":
                    winner = p2 == wins[2] ? p1 : p2;
                    break;
                default:
                    winner = "Invalid entry";
                    break;
            }
            return winner;
        }
    }
}

