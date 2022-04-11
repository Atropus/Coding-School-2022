namespace GoilGasStation.Model
{
    public class Item : BaseEntity
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
    }
}