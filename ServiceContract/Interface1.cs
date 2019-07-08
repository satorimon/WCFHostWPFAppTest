using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorlddServiceContract
{
    [ServiceContract(Namespace = "http://HelloWorlddServiceContract")]
    public interface IHelloWorldService
    {
        [OperationContract]
        string SayHello(string name);
    }

}
