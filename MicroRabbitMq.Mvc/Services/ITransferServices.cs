using MicroRabbitMq.Mvc.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbitMq.Mvc.Services
{
    public interface ITransferServices
    {

        Task Transfer(TransferDto trasferDto);
    }
}
