namespace WebAPI.Responses;

public class ErrorResponse
{
    public int? Status { get; init; } = null;

    public string? Title { get; init; } = null;

    public string? Detail { get; init; } = null;

    public string? Type { get; init; } = null;

    public string? Instance { get; init; } = null;

    public IDictionary<string, string[]>? Errors { get; init; } = null;
}