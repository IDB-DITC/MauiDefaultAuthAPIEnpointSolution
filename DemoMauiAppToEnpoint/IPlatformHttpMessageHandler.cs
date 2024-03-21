namespace DemoMauiAppToEnpoint
{
	public interface IPlatformHttpMessageHandler
	{
		HttpMessageHandler GetHttpMessageHandler();
	}

	public class PlatformHttpMessageHandler: IPlatformHttpMessageHandler
	{
        public HttpMessageHandler GetHttpMessageHandler()
		{
			return new HttpClientHandler();
		}
    }

}
