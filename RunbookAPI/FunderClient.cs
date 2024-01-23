using System.Threading.Tasks;

namespace Runbook.API
{
    public class FunderClient : CWSSoapClient, IFunderClient
    {
        public FunderClient(CWSSoapClient.EndpointConfiguration config) : base(config) 
        { }
       
    }
}
