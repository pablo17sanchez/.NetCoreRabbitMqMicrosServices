﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbitMq.Transfer.Aplication.Interfaces;
using MicroRabbitMq.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMq.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {

        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;

        }
        // GET api/transfer
        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {

            return Ok(_transferService.GetTransferLog());

        }


    }
}
