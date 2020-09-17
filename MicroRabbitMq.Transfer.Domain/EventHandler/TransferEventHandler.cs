﻿using MicroRabbitMq.Domain.Core.Bus;
using MicroRabbitMq.Transfer.Domain.Events;
using MicroRabbitMq.Transfer.Domain.Interfaces;
using MicroRabbitMq.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbitMq.Transfer.Domain.EventHandler
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {

        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            });

            return Task.CompletedTask;
        }
    }
}
