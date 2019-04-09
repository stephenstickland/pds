using BusinessApi.Controllers;
using BusinessService;
using BusinessService.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using System;
using System.Runtime.Caching;
using System.Threading.Tasks;
using Xunit;

namespace BusinessApiTests
{
    public class BusinessApiTest
    {
        [Fact]
        public void Construction()
        {
            Mock<IBusinessService> mockBusinessService = new Mock<IBusinessService>();

            var controller = new BusinessController(new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions()), mockBusinessService.Object);

            Assert.NotNull(controller);
        }

        [Fact]
        public async void GetPeriod()
        {
            Mock<IBusinessService> mockBusinessService = new Mock<IBusinessService>();

            mockBusinessService
                .Setup(c => c.GetItemsForPeriod(It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .Returns(Task.FromResult(new Period(DateTime.Now, DateTime.Now)));

            var httpContext = new DefaultHttpContext();

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            var controller = new BusinessController(new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions()), mockBusinessService.Object)
            {
                ControllerContext = controllerContext
            };

            Assert.NotNull(controller);

            var okResult = await controller.Get(DateTime.Now, DateTime.Now);

            Assert.NotNull(okResult);
            Assert.Empty(okResult.Value.BusinessItems);
        }

        [Fact]
        public async void GetItem()
        {
            Mock<IBusinessService> mockBusinessService = new Mock<IBusinessService>();

            mockBusinessService
                .Setup(c => c.GetItem(It.IsAny<DateTime>(), It.IsAny<DateTime>(), It.IsAny<int>()))
                .Returns(Task.FromResult(new BusinessItem() { Category = "test"}));

            var httpContext = new DefaultHttpContext();

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            var controller = new BusinessController(new Microsoft.Extensions.Caching.Memory.MemoryCache(new MemoryCacheOptions()), mockBusinessService.Object)
            {
                ControllerContext = controllerContext
            };

            Assert.NotNull(controller);

            var okResult = await controller.Get(DateTime.Now, DateTime.Now, 0);

            Assert.NotNull(okResult);
            Assert.Equal("test", okResult.Value.Category);
        }
    }
}
