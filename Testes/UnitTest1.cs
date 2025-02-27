
using Moq;
using Moq.EntityFrameworkCore;
using Entitis;


namespace Testes
{
    public class UnitTest1
    {
        [fact]
        public async Task Login_Working()
        {
            var user = new User() { Email = "ll@gmail.com", Password = "Ll1234@#" };

            var mockContext = new Mock<AdeNetManageContext>();
            var users = new List<User>() { user };
            mockContext.Setup(x => x.Users).ReturnsDbSet(users);

            var userREpository = new MyRepository(mockContext.Object);

            var result = await userREpository.Login(user.UserName, user.Password);

            Assert.Equal(user, result);
        }
    }
}