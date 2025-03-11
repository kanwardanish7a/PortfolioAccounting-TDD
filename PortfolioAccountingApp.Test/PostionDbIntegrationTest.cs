using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAccountingApp.Test
{
    [TestClass]
    public class PostionDbIntegrationTest
    {
        [TestMethod]
        public void AddPosition_ShouldSaveToDatabase()
        {
            var options = new DbContextOptionsBuilder<PortfolioDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDB")
                .Options;

            using (var context = new PortfolioDbContext(options))
            {
                context.Positions.Add(new Position("AAPL", 100, 150.00m));
                context.SaveChanges();
            }

            using (var context = new PortfolioDbContext(options))
            {
                var position = context.Positions.FirstOrDefault(p => p.Ticker == "AAPL");
                Assert.IsNotNull(position);
                Assert.AreEqual(100, position.Quantity);
            }
        }
    }
}
