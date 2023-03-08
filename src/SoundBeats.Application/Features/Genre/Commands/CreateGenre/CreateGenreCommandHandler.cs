using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Application.Features.Genre.Commands
{
    public class CreateGenreCommandHandler : IRequestHandler<CreateGenreDTO, ApiResponse<CreateGenreDTO>>
    {
        private readonly IGenreService _genreService;

        public CreateGenreCommandHandler(IGenreService genreService) =>
            _genreService = genreService;

        public async Task<ApiResponse<CreateGenreDTO>> Handle(CreateGenreDTO request, CancellationToken cancellationToken)
        {
            var entity = await _genreService.AddGenre(request, cancellationToken);
            return new ApiResponse<CreateGenreDTO>(entity, $"The Genre with name {entity.Name} was created successfully.");
        }
    }
}
