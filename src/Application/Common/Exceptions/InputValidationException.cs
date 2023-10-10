using FluentValidation.Results;

namespace Application.Common.Exceptions;

public class InputValidationException: Exception
{
    public IDictionary<string, string[]> Errors { get; }

    private InputValidationException(): base("One or more validation failure have occured")
    {
        Errors = new Dictionary<string, string[]>();
    }
    public InputValidationException(IEnumerable<ValidationFailure> failures): this()
    {
        Errors = failures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }
    
}