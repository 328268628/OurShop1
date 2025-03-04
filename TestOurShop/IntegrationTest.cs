//using Entitis;
//using Moq;
//using Repository;
//using Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestOurShop
//{
//    public class IntegrationTest: IClassFixture<DatabaseFixture>
//    {
//        private readonly AdeNetManageContext _context;
//        public IntegrationTest(DatabaseFixture fixture)
//        {
//            _context = fixture.Context;
//        }
//        [Fact]
//        public async Task DB_Login_Valid_Test()
//        {
//            // Arrange
//            var user = new User { Email = "test@example.com", Password = "password123" };
//            _context.Users.Add(user);
//            await _context.SaveChangesAsync();
//            var userRepository = new UserRepository(_context);


//            // Act
//            var tmpUser = await userRepository.Login(user.Email, user.Password);

//            // Assert
//            Assert.NotNull(tmpUser);
//            Assert.Equal(user.Email, tmpUser.Email);
//            Assert.Equal(user.Password, tmpUser.Password);
//        }
//        [Fact]
//        public async Task DB_Login_Invalid_Test()
//        {
//            // Arrange
//            var userRepository = new UserRepository(_context);

//            // Act
//            var result = await userRepository.Login("wrongPassword", "nonExistentUser");

//            // Assert
//            Assert.Null(result);
//        }
//        [Fact]
//        public async Task DB_Login_WrongPassword_Test()
//        {
//            // Arrange
//            var user = new User { Email = "LaikySh", Password = "password1234" };
//            _context.Users.Add(user);
//            await _context.SaveChangesAsync();

//            var userRepository = new UserRepository(_context);

//            // Act
//            var result = await userRepository.Login(user.Email, "worngpassword");

//            // Assert
//            Assert.Null(result);
//        }
//        //[Fact]
//        //public async Task DB_CreateOrderSum_CHeckOrderSum_ReturnsOrder()
//        //{
//        //    // Arrange
//        //    _context.Categories.Add(new Category { Name = "basic" });
//        //    await _context.SaveChangesAsync();

//        //    List<Product> products = new List<Product> { new() { Price = 6, Name = "Milk", CategoryId = 1, Description = "tasty", Image = "1.jpg" }, new() { Price = 20, Name = "eggs", CategoryId = 1, Description = "tasty", Image = "1.jpg" } };
//        //    _context.Products.AddRange(products);
//        //    await _context.SaveChangesAsync();

//        //    var orderItems = new List<OrderItem>() { new() { ProductId = 1 }, new() { ProductId = 2 } };
//        //    var order = new Order { OrderSum = 26, OrderItems = orderItems };
//        //    var orderRepository = new OrderRepository(_context);
//        //    var orderService = new OrderService(orderRepository);

//        //    // Act
//        //    var result = await orderService.AddOrder(order);

//        //    // Assert
//        //    Assert.Equal(order, result);
//        //}
//    }
//}
