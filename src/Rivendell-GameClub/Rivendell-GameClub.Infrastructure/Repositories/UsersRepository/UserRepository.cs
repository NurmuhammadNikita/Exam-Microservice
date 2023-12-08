using Microsoft.EntityFrameworkCore;
using Rivendell_GameClub.Domain.Tables.Entities;
using Rivendell_GameClub.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Infrastructure.Repositories.UsersRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly RivendellDB _context;


        public UserRepository(RivendellDB context)
        {
            _context = context;

        }

        public async ValueTask<User> CreateAsync(User model)
        {
            User User = new User()
            {
                

            };

            await _context.Users.AddAsync(User);
            await _context.SaveChangesAsync();

            return User;
        }

        public async ValueTask<User> DeleteAsync(Guid Id)
        {
            User User = await _context.Users.FirstOrDefaultAsync(x => x.Id == Id);
            if (User == null)
            {
                return (new User());
            }
            else
            {
                _context.Users.Remove(User);
                await _context.SaveChangesAsync();
                return (User);
            }
        }

        public async ValueTask<IList<User>> GetAllAsync()
        {
            IList<User> Users = await _context.Users.ToListAsync();

            return (Users);
        }

        public ValueTask<User> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<User> UpdateAsync(Guid Id, User model)
        {
            var User = await _context.Users.FirstOrDefaultAsync(x => x.Id == Id);
            if (User == null)
            {
                return (new User());
            }
            else
            {
                

                _context.Users.Update(User);
                await _context.SaveChangesAsync();
                return (User);

            }
        }
    }
}
