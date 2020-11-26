using System.Collections.Generic;
using RepoPattern_UnitWork.Data;
using RepoPattern_UnitWork.Models;

namespace RepoPattern_UnitWork.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);

        }

        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);
            //without SaveChanges don't persists
        }

    }
}