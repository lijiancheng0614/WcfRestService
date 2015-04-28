using System.ServiceModel;
using System.ServiceModel.Activation;

namespace WcfRestService
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class RestService : IRestService
	{
		public string GetClientNameById(string Id)
		{
			return "client" + Id;
		}
	}
}