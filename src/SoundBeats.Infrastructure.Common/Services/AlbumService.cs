using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.Persistence.Services.Base;
using SoundBeats.Core.DTO.Album;
using AutoMapper;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Exceptions;

namespace SoundBeats.Infrastructure.Common.Services
{
    public class AlbumService : CRUDService<AlbumDTO, CommandDTO, int,
                                Album, IAlbumRepository<SoundBeatsDbContext>, SoundBeatsDbContext>,
                                IAlbumService
    {

        public AlbumService(IAlbumRepository<SoundBeatsDbContext> repository,
           IUnitOfWork<SoundBeatsDbContext> unitOfWork,
           IMapper mapper) : base(repository,
                                  unitOfWork,
                                  mapper)
        {

        }

        public async Task<IEnumerable<AlbumDTO>> GetAlbums(CancellationToken cancellationToken = default)
        {
            var albumList = await GetAllIncludeAsync("Artist", cancellationToken);

            return Mapper.Map<IEnumerable<AlbumDTO>>(albumList);
        }

        public async Task<AlbumDTO> FindAlbum(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);

        public async Task<CreateAlbumDTO> AddAlbum(CreateAlbumDTO objDTO, CancellationToken cancellationToken = default)

        {
            var ifExists = await FilterAsync(u => u.Title == objDTO.Title &&
                                            u.ArtistId == objDTO.ArtistId &&
                                            u.IsDeleted == false);
            if (ifExists.Count() > 0)
                throw new EntityAlreadyExistException(objDTO.GetType(), objDTO.Title);
            else
                return Mapper.Map<CreateAlbumDTO>(await InsertAsync(objDTO, cancellationToken));
        }

        public async Task<UpdateAlbumDTO> UpdateAlbum(UpdateAlbumDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await GetSingleAsync(u => u.Title == objDTO.Title &&
                                            u.ArtistId == objDTO.ArtistId &&
                                            u.IsDeleted == false);
            if (ifExists == null)
                throw new EntityNotFoundException(objDTO.GetType(), objDTO.Title);
            else
                return Mapper.Map<UpdateAlbumDTO>(await UpdateAsync(objDTO, cancellationToken));
        }

        public async Task<DeleteAlbumDTO> DeleteAlbum(DeleteAlbumDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Id == objDTO.Id && u.IsDeleted == false);
            if (ifExists == null || ifExists.Count() == 0)
                throw new EntityNotFoundException(objDTO.Id.ToString());

            return Mapper.Map<DeleteAlbumDTO>(await DeleteAsync(objDTO, autoSave, cancellationToken));
        }
    }
}
