using Application.Features.PublishingHouses.Commands.CreatePublishingHouse;
using Application.Features.PublishingHouses.Commands.DeletePublishingHouse;
using Application.Features.PublishingHouses.Commands.UpdatePublishigHouse;
using Application.Features.PublishingHouses.Queries.GetDetailsPublishingHouse;
using Application.Features.PublishingHouses.Queries.GetListPublishingHouse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PublishingHouseController: ControllerBase
{
    private readonly IMediator _mediator;

    public PublishingHouseController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("getById/{id}")]
    public async Task<IActionResult> GetPublishingHouseById([FromRoute] GetDetailsPublishingHouseQuery query)
    {
        return Ok(await _mediator.Send(query));
    }

    [HttpGet("getList")]
    public async Task<IActionResult> GetPublishingHouseList()
    {
        return Ok(await _mediator.Send(new GetListPublishingHouseQuery()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreatePublishingHouse(CreatePublishingHouseCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdatePublishingHouse(UpdatePublishingHouseCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeletePublishingHouse([FromRoute] DeletePublishingHouseCommand command)
    {
        return Ok(await _mediator.Send(command));
    } 
    
}