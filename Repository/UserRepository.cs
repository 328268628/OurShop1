using Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using NLog;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        AdeNetManageContext _manageDbContext;
        //private readonly IDbContextFactory<AdeNetManageContext> _contextFactory;
        private readonly ILogger<UserRepository> _logger;

        //public UserRepository(AdeNetManageContext manageDbContext, ILogger<UserRepository> logger)
        //{
        //    this.manageDbContext = manageDbContext;
        //    _logger = logger;
        //}
        public UserRepository(AdeNetManageContext manageDbContext,ILogger<UserRepository> logger)
        {
           _manageDbContext = manageDbContext;
            _logger = logger;
            //_contextFactory= contextFactory;, IDbContextFactory<AdeNetManageContext> contextFactory
        }
        public async Task<User> AddUser(User user)
        {
            await _manageDbContext.Users.AddAsync(user);
            await _manageDbContext.SaveChangesAsync();
            return user;
        }
        public async Task<User> GetUserById(int id)
        {
            User user = await _manageDbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
            return user;

        }


        public async Task<User> Login(string email, string password)
        {
            //using (var context = _contextFactory.CreateDbContext())
            //{
            //    return await context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            //}
            User user = await _manageDbContext.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                _logger.LogCritical($"login attempted with User Name , {email} and password{password}");
            }
            return user;
        }
        //public async Task<User> Login(string email, string password)
        //{
        //    // Ensure that the DbContext is used in a thread-safe manner
        //    User user;
        //    using (var context = new AdeNetManageContext())
        //    {
        //        user = await context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        //    }
        //    if (user != null)
        //    {
        //        _logger.LogCritical($"login attempted with User Name , {email} and password{password}");
        //    }
        //    return user;
        //}

        public async Task UpdateUser(int id, User userToUpdate)
        {
            userToUpdate.Id = id;
            _manageDbContext.Update(userToUpdate);
            await _manageDbContext.SaveChangesAsync();
        }








    }
}
