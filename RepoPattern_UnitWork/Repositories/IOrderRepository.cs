using System.Collections.Generic;
using RepoPattern_UnitWork.Models;

namespace RepoPattern_UnitWork.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
        void Delete(Order order);

    }
}