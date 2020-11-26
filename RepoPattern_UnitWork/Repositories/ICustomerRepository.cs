using System.Collections.Generic;
using RepoPattern_UnitWork.Models;

namespace RepoPattern_UnitWork.Repositories
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
        void Delete(Customer customer);
    }
}