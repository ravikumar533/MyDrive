using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MyDrive.Startup))]

namespace MyDrive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
