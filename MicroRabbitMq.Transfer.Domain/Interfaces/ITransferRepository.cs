using MicroRabbitMq.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMq.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {

        IEnumerable<TransferLog> GetTransferLogs();

        void Add(TransferLog transferlog);

    }
}
