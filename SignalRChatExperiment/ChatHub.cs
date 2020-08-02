using Microsoft.AspNet.SignalR;

namespace SignalRChatExperiment
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call to the client method.
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}