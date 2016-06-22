using System.Security.Cryptography.X509Certificates;

namespace HelloWorld.DataServices
{
    public interface IBusinessOperations
    {
        /// <summary>
        /// operation to return a message
        /// </summary>
        /// <returns></returns>
        string ReturnMessage();
    }
}