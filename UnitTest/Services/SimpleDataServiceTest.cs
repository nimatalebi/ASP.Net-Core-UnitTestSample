using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using UnitTestSample;
using UnitTestSample.Infra.Abstract;
using UnitTestSample.Models;
using Xunit;

namespace UnitTest.Services
{
    public class SimpleDataServiceTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public SimpleDataServiceTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;

        }

        [Fact]
        public async Task SimpleData_List()
        {
            var serviceScopeFactory = _factory.Services.GetRequiredService<IServiceScopeFactory>();
            using var serviceScope = serviceScopeFactory.CreateScope();

            //Get Real Service
            var service = serviceScope.ServiceProvider.GetRequiredService<ISimpleDataService>();
            var result = await service.GetAll();
            Assert.NotNull(result);//if result is not Null return true
            Assert.True(result.Count > 0);//if Count > 0 is true
        }

        //this case Should be Fail and Return NullArgumentException
        [Fact]
        public async Task SimpleData_Create()
        {
            var serviceScopeFactory = _factory.Services.GetRequiredService<IServiceScopeFactory>();
            using var serviceScope = serviceScopeFactory.CreateScope();
            var service = serviceScope.ServiceProvider.GetRequiredService<ISimpleDataService>();
            await service.Create(new SimpleDataViewModel() { Title = "test", Category = "" });
        }

        [Fact]
        public async Task SimpleData_Delete()
        {
            var serviceScopeFactory = _factory.Services.GetRequiredService<IServiceScopeFactory>();
            using var serviceScope = serviceScopeFactory.CreateScope();
            var service = serviceScope.ServiceProvider.GetRequiredService<ISimpleDataService>();
            await service.Delete(1);
        }
    }
}
