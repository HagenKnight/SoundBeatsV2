using MediatR;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Features.Album.Queries
{
    public class GetAllAlbumQuery : IRequest<IEnumerable<AlbumDTO>> { }

    public class GetAlbumQuery : IRequest<AlbumDTO>
    {
        public int Id { get; set; }
        public GetAlbumQuery(int id) => Id = id;
    }
}
