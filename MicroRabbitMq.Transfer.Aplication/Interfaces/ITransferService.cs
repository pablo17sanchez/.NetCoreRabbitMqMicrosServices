﻿using MicroRabbitMq.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMq.Transfer.Aplication.Interfaces
{
    public interface ITransferService
    {

        IEnumerable<TransferLog> GetTransferLog();
    }
}
