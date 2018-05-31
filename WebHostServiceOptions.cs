using System;
using System.Collections.Generic;
using System.Text;

namespace GenericHostSample
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.Hosting;

    public class WebHostServiceOptions
    {
        public Action<HostBuilderContext, IApplicationBuilder> ConfigureApp { get; internal set; }
    }
}
