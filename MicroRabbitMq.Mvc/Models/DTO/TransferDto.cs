using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbitMq.Mvc.Models.DTO
{
    public class TransferDto
    {

        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public Decimal TransferAmount { get; set; }
    }
}
