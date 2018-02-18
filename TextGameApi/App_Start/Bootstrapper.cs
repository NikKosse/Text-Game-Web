using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TextGameApi.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            AutofacWebapiConfig.Initalize(GlobalConfiguration.Configuration);
        }
    }
}