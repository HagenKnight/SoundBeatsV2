using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.Persistence.Repository.Base;
using System.Linq.Expressions;

namespace SoundBeats.Infrastructure.Common.Repositories
{
    public class AlbumRepository : BaseRepository<Album, int, SoundBeatsDbContext>, IAlbumRepository<SoundBeatsDbContext>
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public AlbumRepository(IDbFactory<SoundBeatsDbContext> dbFactory) : base(dbFactory) { }

        public async Task<IEnumerable<Album>> FilterAlbum(Expression<Func<Album, bool>> predicate, CancellationToken cancellationToken = default) =>
            await FilterAsync(predicate, cancellationToken);
        
    }
}
