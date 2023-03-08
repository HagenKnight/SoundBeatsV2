using SoundBeats.Core.DTO;
using SoundBeats.Core.DTO.Album;

namespace SoundBeats.Core.Interfaces.Services
{
    public interface IAlbumService
    {
        Task<IEnumerable<AlbumDTO>> GetAlbums(CancellationToken cancellationToken = default);

        Task<AlbumDTO> FindAlbum(int id, CancellationToken cancellationToken = default);

        //Task<AlbumDTO> FilterAlbum(Expression<Func<Album, bool>> predicate, CancellationToken cancellationToken = default);
        Task<CreateAlbumDTO> AddAlbum(CreateAlbumDTO objDTO, CancellationToken cancellationToken = default);
        Task<UpdateAlbumDTO> UpdateAlbum(UpdateAlbumDTO objDTO, CancellationToken cancellationToken = default);
        Task<DeleteAlbumDTO> DeleteAlbum(DeleteAlbumDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);

    }
}
