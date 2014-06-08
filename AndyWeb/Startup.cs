using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AndyWeb.Startup))]

namespace AndyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}