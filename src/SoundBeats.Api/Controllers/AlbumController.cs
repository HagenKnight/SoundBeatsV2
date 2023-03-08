using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoundBeats.Application.Features.Album.Queries;
using SoundBeats.Application.Features.Artist;
using SoundBeats.Application.Models;
using SoundBeats.Core.DTO;
using SoundBeats.Core.DTO.Album;
using SoundBeats.Core.Wrappers;
using System.Data;

namespace SoundBeats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlbumController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Artist
        [HttpGet]
        public async Task<IEnumerable<AlbumDTO>> GetAlbums() =>
            await _mediator.Send(new GetAllAlbumQuery());


        // POST: api/Artist
        [HttpPost]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<CreateAlbumDTO>> Post([FromBody] CreateAlbumDTO command) =>
            await _mediator.Send(command);
    }
}
