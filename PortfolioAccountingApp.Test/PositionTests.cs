using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortfolioAccountingApp;

namespace PortfolioAccountingApp.Tests
{
    [TestClass]
    public class PositionTests
    {
        private Position _position;

        [TestInitialize]
        public void SetUp()
        {
            _position = new Position("AAPL", 100, 150.00m); // 100 shares bought at $150 each
        }

        [TestMethod]
        public void CalculateUnrealizedPnL_ShouldReturnCorrectProfit()
        {
            decimal currentPrice = 160.00m; // Market price increased
            decimal expectedPnL = 100 * (160.00m - 150.00m); // (160-150) * 100 = 1000

            var result = _position.CalculateUnrealizedPnL(currentPrice);

            Assert.AreEqual(expectedPnL, result);
        }

        [TestMethod]
        public void CalculateUnrealizedPnL_ShouldReturnCorrectLoss()
        {
            decimal currentPrice = 140.00m; // Market price decreased
            decimal expectedPnL = 100 * (140.00m - 150.00m); // (140-150) * 100 = -1000

            var result = _position.CalculateUnrealizedPnL(currentPrice);

            Assert.AreEqual(expectedPnL, result);
        }
    }
}
