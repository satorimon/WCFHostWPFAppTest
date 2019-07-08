﻿using System.ServiceModel;

namespace HelloWorldServiceContract
{
    [ServiceContract(Namespace = "http://HelloWorldServiceContract")]
    public interface IHelloWorldService
    {
        [OperationContract]
        string SayHello(string name);
    }
}
