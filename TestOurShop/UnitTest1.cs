//using Moq;
//using Moq.EntityFrameworkCore;
//using Entitis;
//using Repository;
//using Repository;
//using Services;
//using Microsoft.Extensions.Logging;

//namespace TestOurShop
//{
//    public class UnitTest1
//    {
//        [Fact]
//        public async Task Login_Valid_Test()
//        {
//            var user = new User() { Email = "ll@gmail.com", Password = "Ll1234@#" };

//            var mockContext = new Mock<AdeNetManageContext>();
//            var users = new List<User>() { user };
//            mockContext.Setup(x => x.Users).ReturnsDbSet(users);


//            var userRepository = new UserRepository(mockContext.Object);

//            var result = await userRepository.Login(user.Email, user.Password);

//            Assert.Equal(user, result);

//        }
//        [Fact]
//        public async Task Login_Invalid_Test()
//        {
//            // Arrange
//            var mocContext = new Mock<AdeNetManageContext>();
//            var users = new List<User>();
//            mocContext.Setup(x => x.Users).ReturnsDbSet(users);

//            var userRepository = new UserRepository(mocContext.Object);

//            // Act
//            var result = await userRepository.Login("nonExistentUser", "wrongPassword");

//            // Assert
//            Assert.Null(result);
//        }
//        [Fact]
//        public async Task Login_WrongPassword_Test()
//        {
//            // Arrange
//            var user = new User { Email = "llll@gmail.com", Password = "LLll1234@!" };
//            var mocContext = new Mock<AdeNetManageContext>();
//            var users = new List<User> { user };
//            mocContext.Setup(x => x.Users).ReturnsDbSet(users);
//            var userRepository = new UserRepository(mocContext.Object);

//            // Act
//            var result = await userRepository.Login(user.Email, "wrongPassword");

//            // Assert
//            Assert.Null(result);
//        }

//        //[Fact]
//        //public async Task CreateOrderSum_CHeckOrderSum_ReturnsOrder()
//        //{
//        //    // Arrange
//        //    var orderItems = new List<OrderItem>() { new() { ProductId = 1 , Quantity =1} };
//        //    var order = new Order { OrderSum = 50, OrderItems = orderItems };

//        //    var mockOrderRepository = new Mock<IOrderRepository>();
//        //    mockOrderRepository.Setup(x => x.AddOrder(It.IsAny<Order>())).ReturnsAsync(order);

//        //    List<Product> products = new List<Product> { new() { Id = 1, Price = 50 } };
//        //    var mockProductRepository = new Mock<IProductRepository>();
//        //    mockProductRepository.Setup(x => x.GetProduct(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int?[]>()))
//        //                         .ReturnsAsync(products);
//        //    var orderService = new OrderService(mockOrderRepository.Object);

//        //    // Act
//        //    var result = await orderService.AddOrder(order);

//        //    // Assert
//        //    Assert.Equal(order, result);
//        //}
//        //[Fact]
//        //public async Task CreateOrderSum_CHeckOrderSum_ReturnsNull()
//        //{
//        //    // Arrange
//        //    var orderItems = new List<OrderItem>() { new() { ProductId = 1, Quantity = 1 } };
//        //    var order = new Order { OrderSum = 50, OrderItems = orderItems };

//        //    var mockOrderRepository = new Mock<IOrderRepository>();
//        //    mockOrderRepository.Setup(x => x.AddOrder(It.IsAny<Order>())).ReturnsAsync(order);

//        //    List<Product> products = new List<Product> { new() { Id = 1, Price = 50 } };
//        //    var mockProductRepository = new Mock<IProductRepository>();
//        //    mockProductRepository.Setup(x => x.GetProduct(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int?[]>()))
//        //                         .ReturnsAsync(products);
//        //    var orderService = new OrderService(mockOrderRepository.Object);

//        //    // Act
//        //    var result = await orderService.AddOrder(order);

//        //    // Assert
//        //    Assert.NotNull(result); // Ensure the result is not null
//        //}
//        //[Fact]
//        //public async Task AddOrder_WhenOrderIsNull_ReturnsNull()
//        //{B
//        //    // Arrange
//        //    var mockOrderRepository = new Mock<IOrderRepository>();
//        //    mockOrderRepository.Setup(x => x.AddOrder(It.IsAny<Order>())).ReturnsAsync((Order)null);

//        //    var orderService = new OrderService(mockOrderRepository.Object);

//        //    // Act
//        //    var result = await orderService.AddOrder(null);

//        //    // Assert
//        //    Assert.Null(result); // Ensure the result is null
//        //}
//    }
//}