using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAccountingApp
{
    public static class FinancialCalculator
    {
        public static decimal CalculateDailyReturn(decimal openingPrice, decimal closingPrice)
        {
            return ((closingPrice - openingPrice) / openingPrice) * 100;
        }
    }
}
