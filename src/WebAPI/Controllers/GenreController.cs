using Application.Features.Genres.Commands.CreateGenre;
using Application.Features.Genres.Commands.DeleteGenre;
using Application.Features.Genres.Commands.UpdateGenre;
using Application.Features.Genres.Queries.GetDetailGenre;
using Application.Features.Genres.Queries.GetListGenre;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenreController: ControllerBase
{
    private readonly IMediator _mediator;

    public GenreController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetGenreList()
    {
        return Ok(await _mediator.Send(new GetListGenreQuery()));
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetGenreById([FromRoute] GetDetailsGenreQuery query)
    {
        return Ok(await _mediator.Send(query));
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateGenre(CreateGenreCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateGenre(UpdateGenreCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> DeleteGenre([FromRoute] DeleteGenreCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}