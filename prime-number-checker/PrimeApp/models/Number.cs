namespace PrimeApp {
    public class Number {
        public static bool isPrime(int num) {
            bool prime = true;
            List<int> basePrime = new List<int>{2, 3, 5, 7};
            foreach (int i in basePrime) {
                if (num % i == 0) {
                    prime = false;
                }
            }
            return prime;
        }
    }
}