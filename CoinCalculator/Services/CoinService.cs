namespace CoinCalculator.Services
{
    public class CoinService
    {
        private readonly (string Name, int Value)[] coins = new[]
        {
        ("silver-dollar", 100),
        ("half-dollar", 50),
        ("quarter", 25),
        ("dime", 10),
        ("nickel", 5),
        ("penny", 1)
    };

        public Dictionary<string, int> GetOptimalCoins(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative.", nameof(amount));

            int cents = (int)(amount * 100);
            var result = new Dictionary<string, int>();

            foreach (var (name, value) in coins)
            {
                int count = cents / value;
                result[name] = count;
                cents %= value;
            }

            return result;
        }
    }
}