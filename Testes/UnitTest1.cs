
using Moq;
using Moq.EntityFrameworkCore;
using Entitis;
using Repository;
using Repository.UserRepository;
using Services;
namespace Testes
{
    public class UnitTest1
    {
        [Fact]
        public async Task Login_Working()
        {
            var user = new User() { Email = "ll@gmail.com", Password = "Ll1234@#" };

            var mockContext = new Mock<AdeNetManageContext>();
            var users = new List<User>() { user };
            mockContext.Setup(x => x.Users).ReturnsDbSet(users);

            var userREpository = new UserRepository(mockContext.Object);

            var result = await userREpository.Login(user.Email, user.Password);

            Assert.Equals(user, result);
        }
    }
}