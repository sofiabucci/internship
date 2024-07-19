using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProgrammersProject.CQRS.Domain.Commands.Requests;
using ProgrammersProject.CQRS.Domain.Commands.Response;

namespace ProgrammersProjectCQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet("{id}")]
        public Task<GetLoginbyIdResponse> Get(Guid id)
        {
            var command = new GetLoginbyIdRequest { Id = id };
            return _mediator.Send(command);
        }

        [HttpPost]
        public Task<PostLoginResponse> Create(PostLoginRequest command)
        {
            return _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public Task<PutLoginResponse> Update(Guid id, PutLoginRequest command)
        {
            command.Id = id;
            return _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public Task<DeleteLoginResponse> Delete(Guid id)
        {
            var command = new DeleteLoginRequest { Id = id };
            return _mediator.Send(command);
        }
    }
}
