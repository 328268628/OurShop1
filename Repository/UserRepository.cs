using Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        AdeNetManageContext manageDbContext;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(AdeNetManageContext manageDbContext, ILogger<UserRepository> logger)
        {
            this.manageDbContext = manageDbContext;
            _logger = logger;
        }

        public async Task<User> AddUser(User user)
        {
            await manageDbContext.Users.AddAsync(user);
            await manageDbContext.SaveChangesAsync();
            return user;
        }
        public async Task<User> GetUserById(int id)
        {
            User user = await manageDbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
            return user;

        }


        public async Task<User> Login(string email, string password)
        {
            User user = await manageDbContext.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                _logger.LogCritical($"login attempted with User Name , {email} and password{password}");
            }
            return user;
        }


        public async Task UpdateUser(int id, User userToUpdate)
        {
            userToUpdate.Id = id;
            manageDbContext.Update(userToUpdate);
            await manageDbContext.SaveChangesAsync();
        }








    }
}
