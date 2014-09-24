// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Microsoft">
//   Copyright © 2014 Microsoft
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Web.Http;

namespace App.HashtagInfo
{
    using System.Web;
    using System.Web.Optimization;
    using System.Web.Routing;

    public class Application : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
