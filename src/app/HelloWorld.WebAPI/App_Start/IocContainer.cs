using System.Web.Http;
using System.Web.Mvc;
using HelloWorld.DataServices;
using HelloWorld.WebAPI.Infrastructure;
using Microsoft.Practices.Unity;

namespace HelloWorld.WebAPI.App_Start
{
    public static class IocContainer
    {
        public static void ConfigureContainer(HttpConfiguration config)
        {
            IUnityContainer container = new UnityContainer();
            RegisterServices(container);
            config.DependencyResolver = new HelloWorldDependencyResolver(container);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IBusinessOperations, BusinessOperations>();
        }
    }
}