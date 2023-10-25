using Application.Common.Models;
using MediatR;

namespace Application.Features.Users.Commands.Register;

public record RegisterCommand(
    string UserName,
    string Password,
    string Role) : IRequest<AuthenticationResult>;
