using Xunit;
using CoinCalculator.Services;
using System.Collections.Generic;

namespace CoinCalculator.Tests
{
	public class CoinServiceTests
	{
		[Theory]
		[InlineData(0.99, "silver-dollar", 0)]
		[InlineData(0.99, "half-dollar", 1)]
		[InlineData(0.99, "quarter", 1)]
		[InlineData(0.99, "dime", 2)]
		[InlineData(0.99, "nickel", 0)]
		[InlineData(0.99, "penny", 4)]
		[InlineData(1.56, "silver-dollar", 1)]
		[InlineData(1.56, "half-dollar", 1)]
		[InlineData(1.56, "nickel", 1)]
		[InlineData(1.56, "penny", 1)]
		[InlineData(12.85, "silver-dollar", 12)]
		[InlineData(12.85, "half-dollar", 1)]
		[InlineData(12.85, "quarter", 1)]
		[InlineData(12.85, "dime", 1)]
		[InlineData(12.85, "nickel", 0)]
		[InlineData(12.85, "penny", 0)]
		public void GetOptimalCoins_ReturnsExpectedCounts(decimal amount, string coin, int expectedCount)
		{
			// Arrange
			var service = new CoinService();

			// Act
			var result = service.GetOptimalCoins(amount);

			// Assert
			Assert.True(result.ContainsKey(coin));
			Assert.Equal(expectedCount, result[coin]);
		}
        [Fact]
        public void GetOptimalCoins_ZeroAmount_ReturnsAllZeroCoins()
        {
            // Arrange
            var service = new CoinService();

            // Act
            var result = service.GetOptimalCoins(0m);

            // Assert
            Assert.All(result.Values, count => Assert.Equal(0, count));
        }

        [Fact]
        public void GetOptimalCoins_NegativeAmount_ThrowsArgumentException()
        {
            // Arrange
            var service = new CoinService();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => service.GetOptimalCoins(-1.23m));
        }

        [Fact]
        public void GetOptimalCoins_AmountLessThanOneCent_ReturnsAllZeroCoins()
        {
            // Arrange
            var service = new CoinService();

            // Act
            var result = service.GetOptimalCoins(0.004m); // rounds down to 0 cents

            // Assert
            Assert.All(result.Values, count => Assert.Equal(0, count));
        }
    }
}
