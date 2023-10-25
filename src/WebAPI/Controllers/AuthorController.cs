using Application.Features.Authors.Commands.CreateAuthor;
using Application.Features.Authors.Commands.DeleteAuthor;
using Application.Features.Authors.Commands.UpdateAuthor;
using Application.Features.Authors.Queries.GetDetailAuthor;
using Application.Features.Authors.Queries.GetListAuthor;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

    [Authorize(Roles = "admin")]
    [HttpGet]
    public async Task<IActionResult> GetListAuthor()
    {
        return Ok(await _mediator.Send(new GetListAuthorQuery()));
    }
    
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetAuthorById([FromRoute] GetDetailsAuthorQuery query)
    {
        return Ok(await _mediator.Send(query));
    }
    
    // Create Author 
    [HttpPost("create")]
    public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    // Update Author
    [HttpPut("update")]
    public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    // Delete Author
    [HttpDelete("{Id}")]
    public async Task<IActionResult> DeleteAuthor([FromRoute] DeleteAuthorCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}