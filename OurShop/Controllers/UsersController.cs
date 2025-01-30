using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Services;
using Entitis;
using DTO;
using AutoMapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OurShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserServices userServices;
        IMapper mapper;
        public UsersController(IUserServices userServices, IMapper mapper)
        {
            this.userServices = userServices;
            this.mapper = mapper;
        }


        // GET: api/<UsersController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "shabat", "shalom" };
        //}

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            User user= await userServices.GetUserById(id);
            UserDTO userDTO = mapper.Map<User, UserDTO>(user);
            return userDTO;
        }

        // POST api/<UsersController>
        [HttpPost]

        public async Task<IActionResult> Post([FromBody] User user)
        {
            int res= userServices.cheakPassword(user.Password);
            if(res < 3)
            {
                return (BadRequest(user));
            }
            User newUser = await userServices.AddUser(user);

            return (Ok(newUser));
        }




        [HttpPost("password")]
        public int Password([FromBody] string password)
        {
            int result = userServices.cheakPassword(password);
            return result;
        }













        [HttpPost("login")]
        public async Task<IActionResult> Login([FromQuery] string email, [FromQuery] string password)
        {
            User newUser =await userServices.Login(email,password);
            return (Ok(newUser));
  
        }


        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] User userToUpdate)
        {
            int res = userServices.cheakPassword(userToUpdate.Password);
            if (res < 3)
            {
                return (BadRequest(userToUpdate));
            }
            
            await userServices.UpdateUser(id, userToUpdate);
            return (Ok(userToUpdate));




            //string textToReplace = string.Empty;
            //using (StreamReader reader = System.IO.File.OpenText("M:\\webAPI\\OurShop\\OurShop\\Users.txt"))
            //{
            //    string currentUserInFile;
            //    while ((currentUserInFile = reader.ReadLine()) != null)
            //    {

            //        User user = JsonSerializer.Deserialize<User>(currentUserInFile);
            //        if (user.Id == id)
            //            textToReplace = currentUserInFile;
            //    }
            //}

            //if (textToReplace != string.Empty)
            //{
            //    string text = System.IO.File.ReadAllText("M:\\webAPI\\OurShop\\OurShop\\Users.txt");
            //    text = text.Replace(textToReplace, JsonSerializer.Serialize(userToUpdate));
            //    System.IO.File.WriteAllText("M:\\webAPI\\OurShop\\OurShop\\Users.txt", text);
            //}




        }
















        // DELETE api/<UsersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
