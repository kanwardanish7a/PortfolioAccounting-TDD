using System.Collections.Generic;
using System.Linq;

namespace PortfolioAccountingApp
{
    public class Portfolio
    {
        private readonly List<Position> _positions = new();

        public void AddPosition(Position position)
        {
            _positions.Add(position);
        }

        public decimal GetTotalUnrealizedPnL(Dictionary<string, decimal> currentPrices)
        {
            return _positions.Sum(pos => pos.CalculateUnrealizedPnL(currentPrices[pos.Ticker]));
        }
    }
}
