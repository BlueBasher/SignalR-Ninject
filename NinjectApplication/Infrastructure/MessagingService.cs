namespace NinjectApplication.Infrastructure
{
	public class MessagingService<T> : IMessagingService<T> where T : class
	{
		#region IMessagingService<T> Members

		public string HelloWorldMessage()
		{
			return "Hello World";
		}

		#endregion
	}
}