using System;
using Shop.Domain.Commands.Response;
using Shop.Domain.Commands.Requests;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace Shop.Domain.Handlers

{
    public class CreateCustomerHandler :
    IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // verify if client exists
            // validate data
            //insert cliente
            //send email welvome
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Victor",
                Email = "victor@victor",
                Username = "Victorx",
                Created_At = DateTime.Now
            };
            return Task.FromResult(result);
        }


    }
}