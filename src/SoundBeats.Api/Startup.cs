﻿using SoundBeats.Application.Mappings;
using SoundBeats.Api.ServiceCollection;

namespace SoundBeats.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureServiceExtension.InitConfigurationAPI(services, Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            AppBuilderExtension.InitConfigurationAPI(app, env);
        }

    }
}
