using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Response;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Handlers;


namespace Shop.Domain.controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerControlller : ControllerBase
    {

        [HttpPost]
        [Route("")]
        public CreateCustomerResponse Create(
            [FromServices] ICreateCutomerHandler handler, //here i add the injection
            [FromBody] CreateCustomerRequest commad
        )
        {
            return handler.Handle(commad);
        }

    }
}