using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRChatExperiment.Startup))]
namespace SignalRChatExperiment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any Hub/Conection wire up & configuration should go in here.
            app.MapSignalR();
        }
    }
}
