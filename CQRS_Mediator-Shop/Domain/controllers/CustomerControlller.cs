using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Response;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Handlers;
using MediatR;
using System.Threading.Tasks;

namespace Shop.Domain.controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerControlller : ControllerBase
    {

        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromServices] IMediator mediator, //here i add the injection
            [FromBody] CreateCustomerRequest commad
        )
        {
            return mediator.Send(commad);
        }

    }
}