using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using HelloWorlddServiceContract;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uri baseAddress = new Uri("http://HelloWorlddServiceContrac");

            using (ServiceHost host = new ServiceHost(typeof(HelloWorldService)))//, baseAddress))
            {
                // Enable metadata publishing.
                //MEMO:App.configに記載
                

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}");//, baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }


    public class HelloWorldService : IHelloWorldService
    {
        public string SayHello(string name)
        {
            var test = new ClassLibrary1.Class1();
            var nowsecond = DateTime.Now.Second;
            return string.Format("Hello, {0} {1} {2}", name, nowsecond, test.IncrementMethod(nowsecond));
        }
    }
}
