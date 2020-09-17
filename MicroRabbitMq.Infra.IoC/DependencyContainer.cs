using MediatR;
using MicroRabbit.Infra.Bus;
using MicroRabbitMq.Banking.Aplication.Interfaces;
using MicroRabbitMq.Banking.Aplication.Services;
using MicroRabbitMq.Banking.Data.Context;
using MicroRabbitMq.Banking.Data.Repository;
using MicroRabbitMq.Banking.Domain.Commands;
using MicroRabbitMq.Banking.Domain.CommandsHandler;
using MicroRabbitMq.Banking.Domain.Events;
using MicroRabbitMq.Banking.Domain.Interfaces;
using MicroRabbitMq.Domain.Core.Bus;
using MicroRabbitMq.Transfer.Aplication.Interfaces;
using MicroRabbitMq.Transfer.Aplication.Services;
using MicroRabbitMq.Transfer.Data.Context;
using MicroRabbitMq.Transfer.Data.Repository;
using MicroRabbitMq.Transfer.Domain.EventHandler;
using MicroRabbitMq.Transfer.Domain.Events;
using MicroRabbitMq.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbitMq.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServicesServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });


            //Subscriptions
            services.AddTransient<TransferEventHandler>();



            //Domain Events

            services.AddTransient<IEventHandler<MicroRabbitMq.Transfer.Domain.Events.TransferCreatedEvent>, TransferEventHandler>();
            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();



            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();

            //Domain Events








        }
    }
}
