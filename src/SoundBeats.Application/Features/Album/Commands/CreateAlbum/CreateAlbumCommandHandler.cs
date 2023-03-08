using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.DTO.Album;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Application.Features.Artist.Commands
{
    public class CreateAlbumCommandHandler : IRequestHandler<CreateAlbumDTO, ApiResponse<CreateAlbumDTO>>
    {
        private readonly IAlbumService _albumService;
        private readonly IArtistService _artistService;

        public CreateAlbumCommandHandler(IAlbumService albumService, IArtistService artistService)
        {
            _albumService = albumService;
            _artistService = artistService;
        }

        public async Task<ApiResponse<CreateAlbumDTO>> Handle(CreateAlbumDTO request, CancellationToken cancellationToken)
        {
            var entity = await _albumService.AddAlbum(request, cancellationToken);
            var artist = await _artistService.FindArtist(request.ArtistId);
            return new ApiResponse<CreateAlbumDTO>(entity, $"The {artist.Name}'s Album titled \"{entity.Title}\" was created successfully.");
        }

    }
}
