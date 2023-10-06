using Application.Features.Authors.Commands.CreateAuthor;
using Application.Features.Authors.Commands.DeleteAuthor;
using Application.Features.Authors.Commands.UpdateAuthor;
using Application.Features.Authors.Queries.GetAuthors;
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAuthorById(Guid id)
    {
        return Ok(await _mediator.Send(new GetAuthorDetailsQuery(id)));
    }

    [HttpGet]
    public async Task<IActionResult> GetListAuthor()
    {
        return Ok(await _mediator.Send(new GetListAuthorQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAuthor(Guid id)
    {
        return Ok(await _mediator.Send(new DeleteAuthorCommand(id)));
    }
}