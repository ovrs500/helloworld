using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HelloWorld.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["webapiBaseUrl"]);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var serviceUrl = "api/BusinessOperations/GetMessage";
                var response = client.GetStringAsync(serviceUrl)
                    .Result;

                System.Console.WriteLine(response);
                System.Console.ReadLine();
            }
        }
    }
}