using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO.Album
{
    public class CreateAlbumDTO : CommandDTO, IRequest<ApiResponse<CreateAlbumDTO>>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string CoverUrl { get; set; }
        public string ImageType { get; set; }
        public int ArtistId { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
