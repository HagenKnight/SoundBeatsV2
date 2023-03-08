using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoundBeats.Application.Features.Artist;
using SoundBeats.Application.Models;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ArtistController(IMediator mediator) => _mediator = mediator;


        // GET: api/Artist
        [HttpGet]
        public async Task<IEnumerable<ArtistDTO>> GetArtists() =>
            await _mediator.Send(new GetAllArtistQuery());

        // GET: api/Genres/5
        [HttpGet("{id}")]
        public async Task<ArtistDTO> GetArtist(int id) =>
            await _mediator.Send(new GetArtistQuery(id));

        // POST: api/Artist
        [HttpPost]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<CreateArtistDTO>> Post([FromBody] CreateArtistDTO command) =>
            await _mediator.Send(command);

        // PUT: api/Artist
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        [HttpPut()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<UpdateArtistDTO>> Put([FromBody] UpdateArtistDTO command) =>
            await _mediator.Send(command);

        // DELETE: api/Artist
        [HttpDelete()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<DeleteArtistDTO>> Delete([FromBody] DeleteArtistDTO command) =>
            await _mediator.Send(command);
    }
}
