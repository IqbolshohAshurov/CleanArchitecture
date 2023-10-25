using Application.Features.Books.Commands.CreateBook;
using Application.Features.Books.Commands.DeleteBook;
using Application.Features.Books.Commands.UpdateBook;
using Application.Features.Books.Queries.GetDetailBook;
using Application.Features.Books.Queries.GetListBook;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController: ControllerBase
{
    private readonly IMediator _mediator;
    public BookController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetListBooksAsync()
    {
        return Ok(await _mediator.Send(new GetListBookQuery()));
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetBookByIdAsync([FromRoute] GetDetailsBookQuery query)
    {
        return Ok(await _mediator.Send(query));
    }


    [HttpPost("create")]
    public async Task<IActionResult> CreateBookAsync(CreateBookCommand command)
    {
        bool result = await _mediator.Send(command);
        
        return Ok(result);
    }


    [HttpPut("update")]
    public async Task<IActionResult> UpdateBookAsync(UpdateBookCommand command)
    {
        bool result = await _mediator.Send(command);
        
        return Ok(result);
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> DeleteBookAsync([FromRoute] DeleteBookCommand command)
    {
        bool result = await _mediator.Send(command);
        
        return Ok(result);
    }
}