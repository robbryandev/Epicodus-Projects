namespace PrimeApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter A Number");
            string? userInput = Console.ReadLine();
            int userNum = 0;
            int.TryParse(userInput, out userNum);
            Console.WriteLine("Primes:\n");
            for (int i = 0; i <= userNum; i++)
            {
                if (i > 1)
                {
                    bool valid = Number.isPrime(i);
                    if (valid)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}