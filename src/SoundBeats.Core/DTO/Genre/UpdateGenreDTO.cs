﻿using MediatR;
using SoundBeats.Core.DTO.Base;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Core.DTO
{
    public class UpdateGenreDTO : CommandDTO, IRequest<ApiResponse<UpdateGenreDTO>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
