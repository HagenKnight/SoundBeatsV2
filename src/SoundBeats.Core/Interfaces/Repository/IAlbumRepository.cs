using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using System.Linq.Expressions;

namespace SoundBeats.Core.Interfaces.Repository
{
    public interface IAlbumRepository<TContext> : IBaseRepository<Album, TContext> where TContext : DbContext, new()
    {
        Task<IEnumerable<Album>> FilterAlbum(Expression<Func<Album, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
