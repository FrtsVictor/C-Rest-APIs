using System;
using Shop.Domain.Commands.Response;
using Shop.Domain.Commands.Requests;
namespace Shop.Domain.Handlers

{
    public class CreateCustomerHandler : ICreateCutomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            // verify if client exists
            // validate data
            //insert cliente
            //send email welvome
            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Victor",
                Email = "victor@victor",
                Username = "Victorx",
                Created_At = DateTime.Now
            };
        }
    }
}