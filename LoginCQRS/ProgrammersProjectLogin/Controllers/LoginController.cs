using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProgrammersProjectLogin.Domain.Commands.Requests;
using ProgrammersProjectLogin.Domain.Models;
using ProgrammersProjectLogin.Infrastructure.Context;

namespace ProgrammersProjectLogin.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController(IMediator mediator, ApplicationDataContext context) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;
        private readonly ApplicationDataContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoginAddRequest>>> GetLogins()
        {
            var command = new LoginGetRequest();
            var response = await _mediator.Send(command);
            return Ok(response);
        }


        [HttpPost]
        public async Task<ActionResult<Login>> AddLogin(LoginAddRequest command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut]
        public async Task<ActionResult<Login>> UpdateLogin(LoginUpdateRequest command)
        { 
            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Login>> DeleteLogin(Guid id)
        {
            var command = new LoginDeleteRequest { Id = id };
            return await _mediator.Send(command);
        }
    }
}
