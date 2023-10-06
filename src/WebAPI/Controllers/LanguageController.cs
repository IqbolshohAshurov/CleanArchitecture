using Application.Features.Languages.Commands.CreateCommand;
using Application.Features.Languages.Commands.DeleteCommand;
using Application.Features.Languages.Commands.UpdateCommand;
using Application.Features.Languages.Queries.GetDetailQuery;
using Application.Features.Languages.Queries.GetListQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LanguageController : ControllerBase
{
    private readonly IMediator _mediator;

    public LanguageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("getById/{id}")]
    public async Task<IActionResult> GetLanguageById(Guid id)
    {
        return Ok(await _mediator.Send(new GetDetailsLanguageQuery(id)));
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> GetLanguageList()
    {
        return Ok(await _mediator.Send(new GetListLanguageQuery()));
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateLanguage(CreateLanguageCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateLanguage(UpdateLanguageCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteLanguage(DeleteLanguageCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

}