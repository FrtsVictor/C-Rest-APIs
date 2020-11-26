using System.Collections.Generic;
using RepoPattern_UnitWork.Data;
using RepoPattern_UnitWork.Models;

namespace RepoPattern_UnitWork.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public void Delete(Order order)
        {
            _context.Orders.Remove(order);

        }

        public void Save(Order order)
        {
            _context.Orders.Add(order);

        }

    }
}