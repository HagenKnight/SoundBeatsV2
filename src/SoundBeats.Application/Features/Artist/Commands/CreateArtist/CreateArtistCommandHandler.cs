﻿using MediatR;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Application.Features.Artist.Commands
{
    public class CreateArtistCommandHandler : IRequestHandler<CreateArtistDTO, ApiResponse<CreateArtistDTO>>
    {
        private readonly IArtistService _artistService;
        public CreateArtistCommandHandler(IArtistService artistService) => _artistService = artistService;

        public async Task<ApiResponse<CreateArtistDTO>> Handle(CreateArtistDTO request, CancellationToken cancellationToken)
        {
            var entity = await _artistService.AddArtist(request, cancellationToken);
            return new ApiResponse<CreateArtistDTO>(entity, $"The Artist with name {entity.Name} was created successfully.");
        }

    }
}
