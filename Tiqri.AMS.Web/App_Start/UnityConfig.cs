using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using System.Web.Http;
using System.Web.Mvc;
using Tiqri.AMS.Web.App_Start;
using Tiqri.AMS.Web.ContextHandlers;
using Unity.WebApi;
using Microsoft.Practices.Unity;
using Tiqri.AMS.Web.Controllers;
using Tiqri.AMS.BizObject;
using Tiqri.AMS.Web.ContextHandlers.impl;
using Tiqri.AMS.BizObject.Impl;

namespace Tiqri.AMS.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IAccidentTypeContextHandler, AccidentTypeContextHandler>();
            container.RegisterType<IAccidentCategoryBiz, AccidentCategoryBiz>();

            container.RegisterType<IEmployeeContextHandler, EmployeeContextHandler>();

            container.RegisterType<IAccidentContextHandler, AccidentContextHandler>();
            container.RegisterType<IAccidentBiz, AccidentBiz>();

            container.RegisterType<AccountController>(new InjectionConstructor());

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}