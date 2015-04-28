using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfRestService
{
	[ServiceContract(Name = "RestService")]
	public interface IRestService
	{
		[OperationContract]
		[WebGet(UriTemplate = Routing.GetClientRoute, BodyStyle = WebMessageBodyStyle.Bare)]
		string GetClientNameById(string Id);
	}

	public static class Routing
	{
		public const string GetClientRoute = "/client/{id}";
	}
}
