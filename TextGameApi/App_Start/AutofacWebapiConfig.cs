using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using TextGameApi.Helpers;

namespace TextGameApi.App_Start
{
    public class AutofacWebapiConfig
    {
        public static IContainer container;

        public static void Initalize(HttpConfiguration config)
        {
            Initalize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initalize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //register controllers here
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<CharacterHelper>()
                .As<ICharacterHelper>()
                .InstancePerRequest();

            container = builder.Build();
            return container;
        }
    }
}