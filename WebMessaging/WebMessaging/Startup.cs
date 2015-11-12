using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMessaging.Startup))]
namespace WebMessaging
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
