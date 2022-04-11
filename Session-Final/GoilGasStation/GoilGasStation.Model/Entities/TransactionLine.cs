namespace GoilGasStation.Model
{
    public class TransactionLine : BaseEntity
    {
        public Guid TransactionID { get; set; }
        public Guid ItemID { get; set; }
        //TODO
        //public decimal FuelQuantity { get; set; }
        public decimal Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
        public Transaction Transaction { get; set; }
        public Item Item { get; set; }

    }
}