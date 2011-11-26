using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Test.Asp.Net.Services
{
    public class Service : IService
    {
        public string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
