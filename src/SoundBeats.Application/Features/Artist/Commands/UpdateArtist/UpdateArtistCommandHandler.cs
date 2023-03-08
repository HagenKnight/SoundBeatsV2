using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Application.Features.Artist.Commands
{
    public class UpdateArtistCommandHandler : IRequestHandler<UpdateArtistDTO, ApiResponse<UpdateArtistDTO>>
    {
        private readonly IArtistService _artistService;
        public UpdateArtistCommandHandler(IArtistService artistService) =>
            _artistService = artistService;

        public async Task<ApiResponse<UpdateArtistDTO>> Handle(UpdateArtistDTO request, CancellationToken cancellationToken)
        {
            var entity = await _artistService.UpdateArtist(request, cancellationToken);
            return new ApiResponse<UpdateArtistDTO>(entity, $"The Artist with name {entity.Name} was updated successfully.");
        }
    }
}
