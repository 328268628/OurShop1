using Entitis;

namespace Repository
{
    public interface IUserRepository
    {
        User AddUser(User user);
        User Login(string email, string password);
        void UpdateUser(int id, User userToUpdate);
    }
}