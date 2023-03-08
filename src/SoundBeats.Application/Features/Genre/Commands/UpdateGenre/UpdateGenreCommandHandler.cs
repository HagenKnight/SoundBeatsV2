using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Application.Features.Genre.Commands
{
    public class UpdateGenreCommandHandler : IRequestHandler<UpdateGenreDTO, ApiResponse<UpdateGenreDTO>>
    {
        private readonly IGenreService _genreService;

        public UpdateGenreCommandHandler(IGenreService genreService) =>
            _genreService = genreService;

        public async Task<ApiResponse<UpdateGenreDTO>> Handle(UpdateGenreDTO request, CancellationToken cancellationToken)
        {
            var entity = await _genreService.UpdateGenre(request, cancellationToken);
            return new ApiResponse<UpdateGenreDTO>(entity, $"The Genre with name {entity.Name} was updated successfully.");
        }
    }
}
