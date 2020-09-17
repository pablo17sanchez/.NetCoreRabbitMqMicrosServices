﻿using MicroRabbitMq.Banking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMq.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccount();

    }
}
