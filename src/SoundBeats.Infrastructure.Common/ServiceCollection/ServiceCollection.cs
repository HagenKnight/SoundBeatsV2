using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SoundBeats.Core.Interfaces.Management;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Infrastructure.Common.Helpers;
using SoundBeats.Infrastructure.Common.Repositories;
using SoundBeats.Infrastructure.Common.Services;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.Persistence.Services;

namespace SoundBeats.Infrastructure.Common.ServiceCollection
{
    public static class ServiceCollection
    {
        public static void AddCommonLayer(this IServiceCollection services)
        {
            /* Repositories */
            services.AddTransient<IGenreRepository<SoundBeatsDbContext>, GenreRepository>();
            services.AddTransient<ICountryRepository<SoundBeatsDbContext>, CountryRepository>();
            services.AddTransient<IArtistRepository<SoundBeatsDbContext>, ArtistRepository>();
            services.AddTransient<IAlbumRepository<SoundBeatsDbContext>, AlbumRepository>();

            /* Services */
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IArtistService, ArtistService>();
            services.AddTransient<IAlbumService, AlbumService>();

            /* Helpers */
            services.AddSingleton<IUriService>(o =>
            {
                var accessor = o.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new UriService(uri);
            });
            services.AddScoped(typeof(IDataShapeHelper<>), typeof(DataShapeHelper<>));
            services.AddScoped<IModelHelper, ModelHelper>();
        }
    }
}
