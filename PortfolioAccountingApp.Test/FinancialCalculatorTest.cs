using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAccountingApp.Test
{
    [TestClass]
    public class FinancialCalculatorTest
    {
        [TestMethod]
        public void CalculateDailyReturn_ShouldReturnCorrectValue()
        {
            decimal openingPrice = 150.00m;
            decimal closingPrice = 155.00m;
            decimal expectedReturn = ((155.00m - 150.00m) / 150.00m) * 100; // 3.33%

            var result = FinancialCalculator.CalculateDailyReturn(openingPrice, closingPrice);

            Assert.AreEqual(expectedReturn, result);
        }
    }
}
