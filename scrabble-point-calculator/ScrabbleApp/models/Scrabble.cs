namespace ScrabbleApp
{
    public class Scrabble
    {
        public static int GetScore(string phrase, string[] letters)
        {
            int result = 0;
            char[] lettPhrase = phrase.ToUpper().ToCharArray();
            for (int l = 0; l < letters.Count(); l++)
            {
                int points = l + 1;
                if (l == 5)
                {
                    points = 8;
                }
                else if (l == 6)
                {
                    points = 10;
                }
                for (int inputArr = 0; inputArr < lettPhrase.Count(); inputArr++)
                {
                    if (letters[l].Contains(lettPhrase[inputArr]))
                    {
                        result += points;
                    }
                }
            }
            return result;
        }
    }
}