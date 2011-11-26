using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using Nancy.Test.Asp.Net.Services;

namespace Nancy.Test.Asp.Net.Application
{
    public class MyApplicationModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IService>().To<Service>();
        }
    }
}
