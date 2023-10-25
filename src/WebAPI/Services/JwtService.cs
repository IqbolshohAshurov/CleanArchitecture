using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace WebAPI.Services;

public class JwtService
{
    private readonly IHttpContextAccessor _contextAccessor;

    public JwtService(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }

    public Guid ExtractJwt()
    {
        string authHeader = _contextAccessor.HttpContext.Request.Headers["Authorization"];
        var jwt = authHeader?.Split(' ')[1];

        JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        SecurityToken token = handler.ReadToken(jwt);
        JwtSecurityToken jwtToken = (JwtSecurityToken) token;
        IEnumerable<Claim> claims = jwtToken.Claims;

        string subject = claims.First(c => c.Type == "sub").Value;

        return Guid.Parse(subject);
    }
}