namespace NinjectApplication.Infrastructure
{
	public interface IMessagingService<T> where T : class
	{
		string GetMessage();
	}
}