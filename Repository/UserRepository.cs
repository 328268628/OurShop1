using Entitis;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        AdeNetManageContext manageDbContext;

        public UserRepository(AdeNetManageContext manageDbContext)
        {
            this.manageDbContext = manageDbContext;
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
