using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoundBeats.Application.Features.Genre;
using SoundBeats.Application.Models;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GenreController(IMediator mediator) => _mediator = mediator;

        // GET: api/Genres
        [HttpGet]
        public async Task<IEnumerable<GenreDTO>> GetGenres() =>
            await _mediator.Send(new GetAllGenreQuery());


        // GET: api/Genres/5
        [HttpGet("{id}")]
        public async Task<GenreDTO> GetGenre(int id) =>
            await _mediator.Send(new GetGenreQuery(id));


        // POST: api/Genres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<CreateGenreDTO>> Post([FromBody] CreateGenreDTO command) =>
            await _mediator.Send(command);


        // PUT: api/Genres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<UpdateGenreDTO>> Put([FromBody] UpdateGenreDTO command) =>
            await _mediator.Send(command);

        // DELETE: api/Genres/5
        [HttpDelete()]
        [Authorize(Roles = CustomRoles.Administrator)]
        public async Task<ApiResponse<DeleteGenreDTO>> Delete([FromBody] DeleteGenreDTO command) =>
            await _mediator.Send(command);

    }
}
