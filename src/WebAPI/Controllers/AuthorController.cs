using Application.Features.Authors.Commands.CreateAuthor;
using Application.Features.Authors.Commands.DeleteAuthor;
using Application.Features.Authors.Commands.UpdateAuthor;
using Application.Features.Authors.Queries.GetAuthorDetails;
using Application.Features.Authors.Queries.GetListAuthor;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController: ControllerBase
{
    private readonly IMediator _mediator;

    public AuthorController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("getById/{Id}")]
    public async Task<IActionResult> GetAuthorById([FromRoute] GetDetailsAuthorQuery query)
    {
        return Ok(await _mediator.Send(query));
    }

    [HttpGet("getList")]
    public async Task<IActionResult> GetListAuthor()
    {
        return Ok(await _mediator.Send(new GetListAuthorQuery()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("delete/{Id}")]
    public async Task<IActionResult> DeleteAuthor([FromRoute] DeleteAuthorCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}