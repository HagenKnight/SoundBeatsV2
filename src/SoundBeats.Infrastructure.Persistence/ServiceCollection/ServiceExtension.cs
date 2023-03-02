﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoundBeats.Infrastructure.Persistence.Data;

namespace SoundBeats.Infrastructure.Persistence.ServiceCollection
{
    public static class ServiceExtension
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            /* Contextos de Bases de Datos. */
            string? connectionString = configuration.GetConnectionString("SoundBeatsConnection");
            services.AddDbContext<SoundBeatsDbContext>(options => { options.UseSqlServer(connectionString); });

            /* DbFactory pattern. */
            /* Agregar aquí las implementaciones de Factory Pattern, asociadas a cada conexto de Base de Datos... */
            services.AddScoped<Func<SoundBeatsDbContext>>((provider) => () => provider.GetService<SoundBeatsDbContext>());
        }
    }
}
