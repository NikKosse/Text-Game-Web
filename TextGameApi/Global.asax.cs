using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using TextGameApi.App_Start;

namespace TextGameApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Bootstrapper.Run();

            GlobalConfiguration.Configure(WebApiConfig.Register);

            HttpConfiguration config = GlobalConfiguration.Configuration;

            config.Formatters.JsonFormatter
                        .SerializerSettings
                        .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}
