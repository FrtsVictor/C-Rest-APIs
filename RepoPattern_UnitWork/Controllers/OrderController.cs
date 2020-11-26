using Microsoft.AspNetCore.Mvc;
using RepoPattern_UnitWork.Data;
using RepoPattern_UnitWork.Models;
using RepoPattern_UnitWork.Repositories;

namespace RepoPattern_UnitWork.Controllers
{
    [ApiController]
    [Route("v1/orders")]
    public class OrderController : ControllerBase
    {

        [HttpPost]
        [Route("")]
        public Order Post(
        [FromServices] ICustomerRepository customerRepository,
        [FromServices] IOrderRepository orderRepository,
        [FromServices] IUnityOfWork uow

    )
        {
            try
            {
                var customer = new Customer { Name = "Victor" };
                var order = new Order { Number = "123", Customer = customer };

                customerRepository.Save(customer);
                orderRepository.Save(order);

                uow.Commit();
                return order;
            }
            catch (System.Exception)
            {
                uow.Rollback();
                throw;
            }
        }

    }
}