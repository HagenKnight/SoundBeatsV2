using AutoMapper;
using SoundBeats.Application.Features.Country;
using SoundBeats.Core.Custom;
using SoundBeats.Core.DTO;
using SoundBeats.Core.DTO.Album;
using SoundBeats.Core.Entities;

namespace SoundBeats.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            /* Mapping PagedList objects. */
            CreateMap(typeof(PagedList<>), typeof(MetaData<>)).ConvertUsing(typeof(ConverterPaging<,>));

            /* Mapping queries and parameters. */
            CreateMap<GetAllCountryQuery, GetAllCountryParameter>().ReverseMap();


            CreateMap<Genre, GenreDTO>().ReverseMap();
            CreateMap<Genre, CreateGenreDTO>().ReverseMap();
            CreateMap<GenreDTO, CreateGenreDTO>().ReverseMap();

            CreateMap<UpdateGenreDTO, Genre>().ReverseMap(); ;
            CreateMap<UpdateGenreDTO, GenreDTO>().ReverseMap(); ;
            CreateMap<DeleteGenreDTO, Genre>().ReverseMap(); ;
            CreateMap<DeleteGenreDTO, GenreDTO>().ReverseMap(); ;

            CreateMap<Country, CountryDTO>().ReverseMap(); ;

            CreateMap<Artist, ArtistDTO>().ReverseMap();
            CreateMap<Artist, CreateArtistDTO>().ReverseMap();
            CreateMap<ArtistDTO, CreateArtistDTO>().ReverseMap();
            CreateMap<Artist, UpdateArtistDTO>().ReverseMap();
            CreateMap<ArtistDTO, UpdateArtistDTO>().ReverseMap();
            CreateMap<Artist, DeleteArtistDTO>().ReverseMap();
            CreateMap<ArtistDTO, DeleteArtistDTO>().ReverseMap();

            CreateMap<Album, AlbumDTO>().ReverseMap();
            CreateMap<Album, CreateAlbumDTO>().ReverseMap();
            CreateMap<AlbumDTO, CreateAlbumDTO>().ReverseMap();
            CreateMap<Album, UpdateAlbumDTO>().ReverseMap();
            CreateMap<AlbumDTO, UpdateAlbumDTO>().ReverseMap();
            CreateMap<Album, DeleteAlbumDTO>().ReverseMap();
            CreateMap<AlbumDTO, DeleteAlbumDTO>().ReverseMap();
            
        }
    }
}
