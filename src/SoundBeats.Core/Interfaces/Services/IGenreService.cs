using SoundBeats.Core.DTO;

namespace SoundBeats.Core.Interfaces.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDTO>> GetGenres(CancellationToken cancellationToken = default);

        Task<GenreDTO> FindGenre(int id, CancellationToken cancellationToken = default);

        //Task<GenreDTO> FilterGenre(Expression<Func<Genre, bool>> predicate, CancellationToken cancellationToken = default);
        Task<CreateGenreDTO> AddGenre(CreateGenreDTO objDTO, CancellationToken cancellationToken = default);
        Task<UpdateGenreDTO> UpdateGenre(UpdateGenreDTO objDTO, CancellationToken cancellationToken = default);
        Task<DeleteGenreDTO> DeleteGenre(DeleteGenreDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
    }
}
