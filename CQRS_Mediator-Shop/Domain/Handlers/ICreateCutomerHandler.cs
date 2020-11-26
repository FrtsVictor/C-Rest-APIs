using System;
using Shop.Domain.Commands.Response;
using Shop.Domain.Commands.Requests;

namespace Shop.Domain.Handlers
{
    public interface ICreateCutomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);

    }
}