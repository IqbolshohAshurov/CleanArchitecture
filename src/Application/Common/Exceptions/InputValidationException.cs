using FluentValidation.Results;

namespace Application.Common.Exceptions;

public class InputValidationException: Exception
{
    public IDictionary<string, string[]> Errors { get; }
    public string ErrorCode { get; }
    private InputValidationException(string massage): base(massage)
    {
        Errors = new Dictionary<string, string[]>();
    }
    public InputValidationException(string message, IEnumerable<ValidationFailure> failures): this(message)
    {
        Errors = failures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }
   
}