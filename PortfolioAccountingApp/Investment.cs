namespace PortfolioAccountingApp
{
    public class Investment
    {
        public decimal InitialAmount { get; }
        public decimal CurrentValue { get; }

        public Investment(decimal initialAmount, decimal currentValue)
        {
            InitialAmount = initialAmount;
            CurrentValue = currentValue;
        }

        public decimal CalculateROI()
        {
            return ((CurrentValue - InitialAmount) / InitialAmount) * 100;
        }
    }
}
