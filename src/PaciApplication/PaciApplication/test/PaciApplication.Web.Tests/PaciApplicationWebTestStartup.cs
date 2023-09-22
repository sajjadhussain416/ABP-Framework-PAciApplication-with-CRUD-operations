using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace PaciApplication;

public class PaciApplicationWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<PaciApplicationWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
