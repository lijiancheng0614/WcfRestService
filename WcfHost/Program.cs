using System;
using System.ServiceModel.Web;
using WcfRestService;

namespace WcfHost
{
	class Program
	{
		static void Main(string[] args)
		{
			RestService restService = new RestService();
			WebServiceHost serviceHost = new WebServiceHost(restService, new Uri("http://localhost"));
			serviceHost.Open();
			Console.ReadKey();
			serviceHost.Close();
		}
	}
}
