using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nancy.Test.Asp.Net.Modules
{
    public abstract class BaseModule : NancyModule
    {
        public BaseModule(string modulePath)
            : base(modulePath)
        {   
            this.Get[@"/js/{name}"] = x =>
            {
                return Response.AsJs(string.Format("js/{0}", (string)x.name));
            };

            this.Get[@"/css/{name}"] = x =>
            {
                return Response.AsCss(string.Format("css/{0}", (string)x.name));
            };

            this.Get[@"/img/{name}"] = x =>
            {
                return Response.AsImage(string.Format("img/{0}", (string)x.name));
            };

            this.Get["/"] = this.Index;
        }

        public virtual Response Index(dynamic x)
        {
            return this.View["Index.cshtml"];
        }
    }
}