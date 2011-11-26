using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using Nancy.Test.Asp.Net.Services;
namespace Nancy.Test.Asp.Net.Modules
{
    public class MyModule : BaseModule
    {
        private readonly IService service;

        public MyModule(IService service) : base("/mymodule")
        {
            this.service = service;
            
            this.Get["/test/{name}"] = this.Test;

            this.Post["/go"] = this.Go;
        }

        public Response Go(dynamic x)
        {
            string message = this.service.SayHello(this.Request.Form.Name);
            return this.Response.AsJson<String>(message);
        }

        public override Response Index(dynamic x)
        {
            return View["Index.cshtml", new { Message = "Who are you?" }];
        }

        public Response Test(dynamic x)
        {
            return "<h1>" + service.SayHello(x.Name) + "</h1>";
        }
    }
}
