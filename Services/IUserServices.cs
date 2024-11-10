using Entitis;

namespace Services
{
    public interface IUserServices
    {
        User AddUser(User user);
        int cheakPassword(string password);
        User Login(string email, string password);
        void UpdateUser(int id, User userToUpdate);
    }
}