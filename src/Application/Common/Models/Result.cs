using AutoMapper.QueryableExtensions.Impl;

namespace Application.Common.Models;

public class Result
{
    internal Result(bool successed, IEnumerable<string> errors)
    {
        Successed = successed;
        Errors = errors.ToArray();
    }

    public bool Successed { get; init; }

    public string[] Errors { get; init; }

    public static Result Success()
    {
        return new Result(true, Array.Empty<string>());
    }

    public static Result Failure(IEnumerable<string> errors)
    {
        return new Result(false, errors);
    }
}
