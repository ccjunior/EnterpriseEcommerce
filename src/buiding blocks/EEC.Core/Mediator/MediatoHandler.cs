using EEC.Core.Messages;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EEC.Core.Mediator
{
    public class MediatoHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatoHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ValidationResult> EnviarComando<T>(T comando) where T : Command
        {
            return await _mediator.Send(comando);
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
        }
    }
}
