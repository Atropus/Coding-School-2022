namespace GoilGasStation.Model
{
    public class Transaction : BaseEntity
    {
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public decimal TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
    }
}