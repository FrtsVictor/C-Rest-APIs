using System.Collections.Generic;
using System.Threading.Tasks;
using UserManager.Domain.Entities;
using UserManager.Infra.Context;
using UserManager.Infra.Interfaces;

namespace UserManager.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository //liskov, userRepository pode receber overwrite de base repository
    {
        private readonly UserManagerContext _context;

        public UserRepository(UserManagerContext context) : base(context) // recebe no construtor e passa pro sontruor base os metodos
        {
            _context = context;
        }

        public async Task<User> SearchByEmail(string email)
        {
            var user = await _context.Users
                                .Where
                                (
                                    x => 
                                        x.Email.Tolower().Contains(email.ToLower())
                                )
                                .AsNoTracking()
                                .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<User> GetByName(string email)
        {
            var user = await _context.Users
                                .Where
                                (
                                    x => 
                                        x.Name.Tolower().contains(name.ToLower())
                                )
                                .AsNoTracking()
                                .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<User> SearchByName(string email)
        {
            var user = await _context.Users
                                .Where
                                (
                                    x => 
                                        x.Name.Tolower().contains(name.ToLower())
                                )
                                .AsNoTracking()
                                .ToListAsync();

            return user.FirstOrDefault();
        }

        public Task<User> GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        Task<List<User>> IUserRepository.SearchByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        Task<List<User>> IUserRepository.SearchByName(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}