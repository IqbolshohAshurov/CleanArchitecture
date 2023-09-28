using Application.Features.Books.Commands.CreateBook;
using Application.Features.Books.Commands.DeleteBook;
using Application.Features.Books.Commands.UpdateBook;
using Application.Features.Books.Queries.GetBookById;
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
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBookByIdAsync(Guid id)
    {
        return Ok(await _mediator.Send(new GetBookByIdQuery(id)));
    }
    
    
    [HttpGet("listBook")]
    public async Task<IActionResult> GetListBooksAsync()
    {
        return Ok(await _mediator.Send(new GetListBookQuery()));
    }
    
    
    [HttpPost("createBook")]
    public async Task<IActionResult> CreateBookAsync(CreateBookCommand command)
    {
        bool result = await _mediator.Send(command);
        if (!result)
            return BadRequest();
        return Ok(result);
    }


    [HttpPut("updateBook")]
    public async Task<IActionResult> UpdateBookAsync(UpdateBookCommand command)
    {
        bool result = await _mediator.Send(command);
        if (!result)
            return BadRequest();
        return Ok(result);
    }

    [HttpDelete("deleteBook")]
    public async Task<IActionResult> DeleteBookAsync(DeleteBookCommand command)
    {
        bool result = await _mediator.Send(command);
        if (!result)
            return BadRequest();
        return Ok(result);
    }
}