using System.Net.Http;
using System.Web.Http;
using HelloWorld.DataServices;
using HelloWorld.WebAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorld.WebAPI.Tests
{
    [TestClass]
    public class BusinessOperationTests
    {
        [TestMethod]
        public void Can_GetMessage_SUCCESS()
        {
            // arrange
            var mockBuinessOperations = new Mock<IBusinessOperations>();

            mockBuinessOperations.Setup(x => x.ReturnMessage(
                ))
                .Returns("Hello World")
                .Verifiable("ReturnMessage should have been called once but was not");

            var businessController = new BusinessOperationsController(mockBuinessOperations.Object);

            businessController.Request = new HttpRequestMessage();
            businessController.Configuration = new HttpConfiguration();

            // act
            var retVal = businessController.GetMessage();
            var retValContent = retVal.Content.ReadAsStringAsync();

            // assert
            Assert.IsTrue(retVal.IsSuccessStatusCode, "Expected a successful status code");
            Assert.IsTrue(retValContent.Result.Contains("Hello World"), "Expected the output to be Hello World");
        }
    }
}