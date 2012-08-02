using SignalR.Hubs;

namespace NinjectApplication.Infrastructure
{
	public class MessagingHub : Hub
	{
		private IMessagingService<App> _messagingService;

		public MessagingHub(IMessagingService<App> messagingService)
		{
			_messagingService = messagingService;
		}

		public void SendMessage(string message)
		{
			Clients.addMessage(_messagingService.GetMessage() + ": " + message);
		}
	}
}