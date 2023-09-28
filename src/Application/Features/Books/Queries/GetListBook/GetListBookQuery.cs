using Application.Common.Models.DTOs.BookDTOs;
using MediatR;

namespace Application.Features.Books.Queries.GetListBook;

public class GetListBookQuery: IRequest<IEnumerable<BookDto>> { }