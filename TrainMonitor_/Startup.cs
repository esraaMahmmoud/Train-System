using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainMonitor_.Startup))]
namespace TrainMonitor_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
