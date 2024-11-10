using System.Text.Json;
using Entitis;
using Repository;
using Zxcvbn;


namespace Services
{
    public class UserServices : IUserServices
    {
        IUserRepository userRepository;

        public UserServices(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User AddUser(User user)
        {
            return userRepository.AddUser(user);
        }

        public int cheakPassword(string password)
        {

            var result = Zxcvbn.Core.EvaluatePassword(password);

            return result.Score;

        }

        public User Login(string email, string password)
        {

            return userRepository.Login(email, password);


        }


        public void UpdateUser(int id, User userToUpdate)
        {

            userRepository.UpdateUser(id, userToUpdate);

        }

    }
}
