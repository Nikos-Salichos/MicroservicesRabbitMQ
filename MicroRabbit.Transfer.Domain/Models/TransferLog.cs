namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public string FromAccount { get; set; }
        public decimal ToAccount { get; set; }
        public decimal Amount { get; set; }
    }
}
