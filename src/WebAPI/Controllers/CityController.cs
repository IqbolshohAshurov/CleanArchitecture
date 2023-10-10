using Application.Features.Authors.Queries.GetListAuthor;
using Application.Features.Cities.Commands.CreateCity;
using Application.Features.Cities.Commands.DeleteCity;
using Application.Features.Cities.Commands.UpdateCity;
using Application.Features.Cities.Queries.GetDetailCity;
using Application.Features.Cities.Queries.GetListCity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CityController: ControllerBase
{
    private readonly IMediator _mediator;

    public CityController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("getById/{id}")]
    public async Task<IActionResult> GetCityById([FromRoute] GetDetailsCityQuery query)
    {
        return Ok(await _mediator.Send(query));
    }

    [HttpGet("getList")]
    public async Task<IActionResult> GetCityList()
    {
        return Ok(await _mediator.Send(new GetListCityQuery()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateCity(CreateCityCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateCity(UpdateCityCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteCity([FromRoute] DeleteCityCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
    
}