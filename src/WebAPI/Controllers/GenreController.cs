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

    [HttpGet("getById/{id}")]
    public async Task<IActionResult> GetGenreById([FromRoute] GetDetailsGenreQuery query)
    {
        return Ok(await _mediator.Send(query));
    }

    [HttpGet("getList")]
    public async Task<IActionResult> GetGenreList()
    {
        return Ok(await _mediator.Send(new GetListGenreQuery()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateGenre(CreateGenreCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteGenre([FromRoute] DeleteGenreCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateGenre(UpdateGenreCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
    
    
}