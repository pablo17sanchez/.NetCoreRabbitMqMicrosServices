using MicroRabbitMq.Transfer.Data.Context;
using MicroRabbitMq.Transfer.Domain.Interfaces;
using MicroRabbitMq.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMq.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;


        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(TransferLog transferlog)
        {
            _ctx.TransferLogs.Add(transferlog);
            _ctx.SaveChanges();

        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
