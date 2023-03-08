using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;

namespace SoundBeats.Application.Features.Album.Queries
{
    public class GetAllAlbumHandler : IRequestHandler<GetAllAlbumQuery, IEnumerable<AlbumDTO>>
    {

        private readonly IAlbumService _albumService;

        public GetAllAlbumHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<IEnumerable<AlbumDTO>> Handle(GetAllAlbumQuery request, CancellationToken cancellationToken) =>
            await _albumService.GetAlbums(cancellationToken);
    }
}
