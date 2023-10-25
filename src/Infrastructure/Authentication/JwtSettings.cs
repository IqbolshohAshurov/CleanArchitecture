namespace Infrastructure.Authentication;

public class JwtSettings
{
    public const string SECTION_NAME = "JwtSettings";

    public string? Secret { get; init; } 

    public int ExpiryMinute { get; init; } 

    public string? Issuer { get; init; } 

    public string? Audience { get; init; }
    
}