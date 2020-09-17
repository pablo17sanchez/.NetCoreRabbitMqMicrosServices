using MicroRabbitMq.Banking.Aplication.Interfaces;
using MicroRabbitMq.Banking.Aplication.Models;
using MicroRabbitMq.Banking.Domain.Commands;
using MicroRabbitMq.Banking.Domain.Interfaces;
using MicroRabbitMq.Banking.Domain.Model;
using MicroRabbitMq.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMq.Banking.Aplication.Services
{
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;

        private readonly IEventBus _bus;
        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccount();
        }


        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                    accountTransfer.FromAccount,
                    accountTransfer.ToAccount,
                    accountTransfer.TransferAmount
                );

            _bus.SendCommand(createTransferCommand);

        }


    }
}
