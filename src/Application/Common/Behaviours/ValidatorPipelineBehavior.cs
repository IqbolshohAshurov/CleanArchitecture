using Application.Common.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.Common.Behaviours;

public class ValidatorPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest: class, IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidatorPipelineBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }
    
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken ct)
    {
        var failures = _validators
            .Select(v => v.Validate(request))
            .SelectMany(result => result.Errors)
            .ToArray();

        if (failures.Length <= 0) return await next();
        
        // var errors = failures
        //     .GroupBy(x => x.PropertyName)
        //     .ToDictionary(k => k.Key, v => v.Select(x => x.ErrorMessage)
        //         .ToArray()
        //     );

        
        throw new InputValidationException(failures);
        
    }
}