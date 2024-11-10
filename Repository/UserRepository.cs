using Entitis;
using System.Text.Json;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public static List<User> Users { get; set; }



        public User AddUser(User user)
        {
            int numberOfUsers = System.IO.File.ReadLines("M:\\webAPI\\OurShop\\OurShop\\Users.txt").Count();
            user.Id = numberOfUsers + 1;
            string userJson = JsonSerializer.Serialize(user);
            System.IO.File.AppendAllText("M:\\webAPI\\OurShop\\OurShop\\Users.txt", userJson + Environment.NewLine);
            return (user);

            //return CreatedAtAction(nameof(Get), new { id = user.Id }, user);

        }



        public User Login(string email, string password)
        {

            using (StreamReader reader = System.IO.File.OpenText("M:\\webAPI\\OurShop\\OurShop\\Users.txt"))
            {
                string? currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {
                    User user = JsonSerializer.Deserialize<User>(currentUserInFile);
                    if (user.Email == email && user.Password == password)

                        return user;


                }
            }
            return null;


        }


        public void UpdateUser(int id, User userToUpdate)
        {

            string textToReplace = string.Empty;
            using (StreamReader reader = System.IO.File.OpenText("M:\\webAPI\\OurShop\\OurShop\\Users.txt"))
            {
                string currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {

                    User user = JsonSerializer.Deserialize<User>(currentUserInFile);
                    if (user.Id == id)
                        textToReplace = currentUserInFile;
                }
            }

            if (textToReplace != string.Empty)
            {
                string text = System.IO.File.ReadAllText("M:\\webAPI\\OurShop\\OurShop\\Users.txt");
                text = text.Replace(textToReplace, JsonSerializer.Serialize(userToUpdate));
                System.IO.File.WriteAllText("M:\\webAPI\\OurShop\\OurShop\\Users.txt", text);
            }




        }








    }
}
