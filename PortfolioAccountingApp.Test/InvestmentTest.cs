using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAccountingApp.Test
{
    [TestClass]
    public class InvestmentTest
    {
        Investment investment;

        [TestInitialize]
        public void SetUp() {
             investment = new Investment(10000m, 12000m); // Initial: $10,000, Current: $12,000

        }


        [TestMethod]
        public void CalculateROI_ShouldReturnCorrectValue()
        {
           
            decimal expectedROI = (2000m / 10000m) * 100; // 20%

            var result = investment.CalculateROI();

            Assert.AreEqual(expectedROI, result);
        }
    }
}
