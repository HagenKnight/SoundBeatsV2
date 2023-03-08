using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO.Album
{
    public class DeleteAlbumDTO : CommandDTO, IRequest<ApiResponse<DeleteAlbumDTO>>
    {
        public int Id { get; set; }
    }
}
