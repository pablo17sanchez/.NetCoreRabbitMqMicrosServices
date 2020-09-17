using MicroRabbitMq.Banking.Aplication.Models;
using MicroRabbitMq.Banking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMq.Banking.Aplication.Interfaces
{
    public interface IAccountService
    {

        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
