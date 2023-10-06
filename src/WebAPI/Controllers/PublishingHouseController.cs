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
    public async Task<IActionResult> GetPublishingHouseById(Guid id)
    {
        return Ok(await _mediator.Send(new GetDetailsPublishingHouseQuery(id)));
    }

    [HttpGet("getAll")]
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

    [HttpDelete("delete")]
    public async Task<IActionResult> DeletePublishingHouse(DeletePublishingHouseCommand command)
    {
        return Ok(await _mediator.Send(command));
    } 
    
}