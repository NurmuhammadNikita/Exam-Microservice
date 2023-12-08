using Rivendell_GameClub.Domain.Tables.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Infrastructure.Repositories.UsersRepository
{
    public interface IUserRepository
    {
        public ValueTask<User> CreateAsync(User model);
        public ValueTask<User> UpdateAsync(Guid Id, User model);
        public ValueTask<User> DeleteAsync(Guid Id);
        public ValueTask<User> GetByIdAsync(Guid Id);
        public ValueTask<IList<User>> GetAllAsync();
    }
}
