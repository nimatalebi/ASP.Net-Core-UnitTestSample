using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moq;
using UnitTestSample.Controllers;
using UnitTestSample.Infra.Abstract;
using UnitTestSample.Models;
using Xunit;
using Assert = Xunit.Assert;

namespace UnitTest.Controllers
{
    
    public class HomeControllerTest
    {
        [Fact]
        public void Get()
        {
            //if you need Implement a new Behavior for Service Methods
            var simpleDataMock = new Mock<ISimpleDataService>();
            simpleDataMock.Setup(c => c.GetAll()).ReturnsAsync(() => new List<SimpleDataViewModel>());


            var controller = new HomeController(simpleDataMock.Object);

            var result =  controller.Index() as ViewResult;
            var viewName = result.ViewName;

            //check the View Name is index
            //not 404 or other Views
            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }

    }
}
