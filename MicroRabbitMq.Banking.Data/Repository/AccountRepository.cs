using MicroRabbitMq.Banking.Data.Context;
using MicroRabbitMq.Banking.Domain.Interfaces;
using MicroRabbitMq.Banking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMq.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {

        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccount()
        {
            return _ctx.Accounts;
        }

     
    }
}
