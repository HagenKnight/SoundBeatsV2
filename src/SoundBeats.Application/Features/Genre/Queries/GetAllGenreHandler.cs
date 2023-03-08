using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;

namespace SoundBeats.Application.Features.Genre
{
    public class GetAllGenreHandler : IRequestHandler<GetAllGenreQuery, IEnumerable<GenreDTO>>
    {
        private readonly IGenreService _genreService;

        public GetAllGenreHandler(IGenreService genreService) => _genreService = genreService;

        public async Task<IEnumerable<GenreDTO>> Handle(GetAllGenreQuery request, CancellationToken cancellationToken) =>
            await _genreService.GetGenres(cancellationToken);
    }
}
