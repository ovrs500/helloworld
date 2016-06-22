namespace HelloWorld.DataServices
{
    public sealed class BusinessOperations : IBusinessOperations
    {
        /// <summary>
        /// operation to return a message
        /// </summary>
        /// <returns></returns>
        public string ReturnMessage()
        {
            return "Hello World";
        }
    }
}