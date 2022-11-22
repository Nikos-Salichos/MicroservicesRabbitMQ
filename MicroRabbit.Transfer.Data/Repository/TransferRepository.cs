using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _tranferDbContext;

        public TransferRepository(TransferDbContext transferDbContext)
        {
            _tranferDbContext = transferDbContext;
        }

        public void AddTransferLog(TransferLog transferLog)
        {
            _tranferDbContext.TransferLogs.Add(transferLog);
            _tranferDbContext.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _tranferDbContext.TransferLogs;
        }
    }
}

