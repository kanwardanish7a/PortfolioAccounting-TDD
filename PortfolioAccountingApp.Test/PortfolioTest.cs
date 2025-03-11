using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAccountingApp.Test
{
    [TestClass]
    public class PortfolioTest
    {
        Portfolio portfolio;

        [TestInitialize]
        public void SetUp()
        {
            portfolio = new Portfolio();
            portfolio.AddPosition(new Position("AAPL", 100, 150.00m));
            portfolio.AddPosition(new Position("GOOG", 50, 2000.00m));
        }

        [TestMethod]
        public void GetTotalUnrealizedPnL_ShouldReturnSumOfAllPositions()
        {
           

            decimal applePrice = 160.00m;  // $1000 profit
            decimal googlePrice = 1900.00m; // $-5000 loss

            decimal expectedTotalPnL = (100 * (160 - 150)) + (50 * (1900 - 2000)); // 1000 + (-5000) = -4000

            var result = portfolio.GetTotalUnrealizedPnL(new Dictionary<string, decimal>
    {
        {"AAPL", applePrice},
        {"GOOG", googlePrice}
    });

            Assert.AreEqual(expectedTotalPnL, result);
        }

    }
}
