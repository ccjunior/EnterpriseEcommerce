using EEC.Clientes.API.Application.Commands;
using EEC.Clientes.API.Application.Events;
using EEC.Clientes.API.Data;
using EEC.Clientes.API.Data.Repository;
using EEC.Clientes.API.Models;
using EEC.Core.Mediator;
using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EEC.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatoHandler>();
            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();
            
            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();


            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}
