using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;

namespace SoundBeats.Application.Features.Artist
{
    public class GetAllArtistHandler : IRequestHandler<GetAllArtistQuery, IEnumerable<ArtistDTO>>
    {
        private readonly IArtistService _artistService;

        public GetAllArtistHandler(IArtistService artistService) => _artistService = artistService;

        public async Task<IEnumerable<ArtistDTO>> Handle(GetAllArtistQuery request, CancellationToken cancellationToken) =>
            await _artistService.GetArtists(cancellationToken);

    }
}
