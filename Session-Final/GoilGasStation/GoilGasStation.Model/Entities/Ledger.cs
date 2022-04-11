namespace GoilGasStation.Model
{
    public class Ledger
    {
        public short Year { get; set; }
        public sbyte Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
    }
}