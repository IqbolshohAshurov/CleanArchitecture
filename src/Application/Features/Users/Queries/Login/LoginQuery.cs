using Application.Common.Models;
using MediatR;

namespace Application.Features.Users.Queries.Login;

public record LoginQuery(string UserName, string Password): IRequest<AuthenticationResult>;