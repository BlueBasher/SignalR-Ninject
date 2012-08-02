namespace NinjectApplication.Infrastructure
{
	public class MessagingService<T> : IMessagingService<T> where T : class
	{
		#region IMessagingService<T> Members

		public string GetMessage()
		{
			return "From " + typeof(T).ToString();
		}

		#endregion
	}
}