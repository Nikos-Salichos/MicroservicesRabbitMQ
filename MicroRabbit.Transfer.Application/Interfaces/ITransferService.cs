using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public class ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
