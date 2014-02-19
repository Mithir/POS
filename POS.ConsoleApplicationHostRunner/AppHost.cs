using System.Collections.Generic;
using ServiceStack;
using Funq;
using POS.API;

namespace POS.ConsoleApplicationHostRunner
{
    public class AppHost : AppHostHttpListenerBase
    {
        public AppHost() : base("StarterTemplate HttpListener", typeof(DealsService).Assembly) { }

        public override void Configure(Container container)
        {
            SetConfig(new HostConfig
            {
                DefaultContentType = "application/json",
                GlobalResponseHeaders = new Dictionary<string, string> {
                        { "Access-Control-Allow-Origin", "*" },
                        { "Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS" },
                        { "Access-Control-Allow-Headers", "Content-Type" }
                    }
            });
            Plugins.Add(new CorsFeature());
        }
    }
}
