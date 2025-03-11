using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioAccountingApp
{
    public class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Required for EF Core

        public string Ticker { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        // EF Core requires a parameterless constructor
        public Position() { }

        public Position(string ticker, int quantity, decimal purchasePrice)
        {
            Ticker = ticker;
            Quantity = quantity;
            PurchasePrice = purchasePrice;
        }

        public decimal CalculateUnrealizedPnL(decimal currentPrice)
        {
            return Quantity * (currentPrice - PurchasePrice);
        }
    }
}
