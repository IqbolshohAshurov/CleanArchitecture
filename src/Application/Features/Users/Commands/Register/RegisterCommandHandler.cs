using Application.Common.Interfaces;
using Application.Common.Interfaces.Authentication;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Users.Commands.Register;

public class RegisterCommandHandler: IRequestHandler<RegisterCommand, AuthenticationResult>
{
    private readonly IApplicationDbContext _context;
    private readonly IJwtTokenGenerator _tokenGenerator;
    private readonly IMapper _mapper;

    public RegisterCommandHandler(
        IApplicationDbContext context,
        IJwtTokenGenerator tokenGenerator,
        IMapper mapper
        )
    {
        _context = context;
        _tokenGenerator = tokenGenerator;
        _mapper = mapper;
        
    }

    public async Task<AuthenticationResult> Handle(RegisterCommand command, CancellationToken ct)
    {
        var user = _mapper.Map<User>(command);
            
            _context.Users.Add(user);
            await _context.SaveChangeAsync(ct);

            var token = _tokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
            
    }
}