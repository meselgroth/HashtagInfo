using System.Web.Http;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(App.HashtagInfo.Startup))]

namespace App.HashtagInfo
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //var config = new HttpConfiguration();

            //WebApiConfig.Register(config);
            //app.UseWebApi(config);

            ConfigureAuth(app);
        }
    }
}
