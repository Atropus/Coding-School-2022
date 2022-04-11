namespace GoilGasStation.Model
{
    public class BaseEntity
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public bool Status { get; set; } = true;
    }
}