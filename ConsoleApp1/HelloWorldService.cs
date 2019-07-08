﻿using System;
using HelloWorlddServiceContract;

namespace ConsoleApp1
{
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
