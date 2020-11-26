using System;

namespace Shop.Domain.Commands.Response
{
    public class CreateCustomerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime Created_At { get; set; }

    }
}