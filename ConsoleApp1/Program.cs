﻿using System;
using System.ServiceModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(HelloWorldService)))//, baseAddress))
            {
                // Enable metadata publishing.
                //MEMO:App.configに記載

                host.Open();

                Console.WriteLine("The service is ready at {0}");//, baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
