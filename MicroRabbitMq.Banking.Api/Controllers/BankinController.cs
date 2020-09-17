using System.Collections.Generic;
using MicroRabbitMq.Banking.Aplication.Interfaces;
using MicroRabbitMq.Banking.Aplication.Models;
using MicroRabbitMq.Banking.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMq.Banking.Api.Controllers
{
    public class BankinController : ControllerBase
    {

        private readonly IAccountService _accountService;

        public BankinController(IAccountService accountService)
        {

            _accountService = accountService;

        }
        /// <summary>
        /// Get value from accounts
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/GetAccounts")]
        public ActionResult<IEnumerable<Account>> Get()
        {

            return Ok(_accountService.GetAccounts());
        }


        [HttpPost("api /PostData")]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
        [HttpGet()]
        public ActionResult Index()
        {

            return Ok();

        }

    }
}
