﻿using MediatR;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Features.Artist
{

    public class GetAllArtistQuery : IRequest<IEnumerable<ArtistDTO>> { }

    public class GetArtistQuery : IRequest<ArtistDTO>
    {
        public int Id { get; set; }
        public GetArtistQuery(int id) => Id = id;
    }
}
