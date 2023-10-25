using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Application.Common.Interfaces.Authentication;
using Application.Common.Models;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Features.Users.Queries.Login;

public class LoginQueryHandler: IRequestHandler<LoginQuery, AuthenticationResult>
{
    private readonly IApplicationDbContext _context;
    private readonly IJwtTokenGenerator _tokenGenerator;

    public LoginQueryHandler(IApplicationDbContext context, IJwtTokenGenerator tokenGenerator)
    {
        _context = context;
        _tokenGenerator = tokenGenerator;
        
    }
    
    public async Task<AuthenticationResult> Handle(LoginQuery request, CancellationToken ct)
    {
        var user = await _context.Users
            .SingleOrDefaultAsync(x => x.UserName == request.UserName && x.Password == request.Password, ct);

        if (user is null)
           throw new InvalidPasswordOrLogin("Incorrect password or login");

        var token = _tokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, token);
    }
}