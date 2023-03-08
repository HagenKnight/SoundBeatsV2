using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;

namespace SoundBeats.Application.Features.Artist
{
    public class GetArtistHandler : IRequestHandler<GetArtistQuery, ArtistDTO>
    {
        private readonly IArtistService _artistService;
        public GetArtistHandler(IArtistService artistService) => _artistService = artistService;

        public async Task<ArtistDTO> Handle(GetArtistQuery request, CancellationToken cancellationToken) =>
            await _artistService.FindArtist(request.Id, cancellationToken);

    }
}
