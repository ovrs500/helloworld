using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorld.DataServices.Tests
{
    [TestClass]
    public class BusinessOperationTests
    {
        [TestMethod]
        public void Can_Get_Return_Message_SUCCESS()
        {
            // arrange
            var businessOperations = new BusinessOperations();

            // act
            var retVal = businessOperations.ReturnMessage();

            // assert
            Assert.IsTrue(retVal == "Hello World", "Expected the return value to be Hello World");
        }
    }
}