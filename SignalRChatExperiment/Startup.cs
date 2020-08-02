using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRChatExperiment.Startup))]
namespace SignalRChatExperiment
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any Hub/Conection wire up & configuration should be written here.
            app.MapSignalR();
        }
    }
}
