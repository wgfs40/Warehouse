using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Application.Interfaces;
using Warehouse.Application.Services;
using Warehouse.Domain.CommandHandlers.Items;
using Warehouse.Domain.Commands.Items;
using Warehouse.Domain.Core.Bus;
using Warehouse.Domain.Core.Events;
using Warehouse.Domain.Core.Notifications;
using Warehouse.Domain.EventHandlers;
using Warehouse.Domain.Events;
using Warehouse.Domain.Interfaces;
using Warehouse.Infra.CrossCutting.Bus;
using Warehouse.Infra.CrossCutting.Identity.Authorization;
using Warehouse.Infra.CrossCutting.Identity.Models;
using Warehouse.Infra.CrossCutting.Identity.Services;
using Warehouse.Infra.Data.Context;
using Warehouse.Infra.Data.EventSourcing;
using Warehouse.Infra.Data.Repository.EventSourcing;
using Warehouse.Infra.Data.Repository.Items;
using Warehouse.Infra.Data.UoW;

namespace Warehouse.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
            services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IItemAppService, ItemAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<INotificationHandler<ItemRegistedEvent>, ItemEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            // Domain - Commands
            services.AddScoped<INotificationHandler<RegisterNewItemCommand>, ItemCommandHandler>();
            //services.AddScoped<INotificationHandler<UpdateCustomerCommand>, CustomerCommandHandler>();
            //services.AddScoped<INotificationHandler<RemoveCustomerCommand>, CustomerCommandHandler>();

            // Infra - Data
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<WirehouseContext>();

            // Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<EventStoreSQLContext>();

            // Infra - Identity Services
            services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            // Infra - Identity
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
