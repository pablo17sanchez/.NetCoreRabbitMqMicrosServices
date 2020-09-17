using MicroRabbitMq.Domain.Core.Bus;
using MicroRabbitMq.Transfer.Aplication.Interfaces;
using MicroRabbitMq.Transfer.Domain.Interfaces;
using MicroRabbitMq.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMq.Transfer.Aplication.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;
        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {

            _transferRepository = transferRepository;
            _bus = bus;


        }
        public IEnumerable<TransferLog> GetTransferLog()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
