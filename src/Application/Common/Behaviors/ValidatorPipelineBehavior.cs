using Application.Common.Exceptions;
using Application.Common.Models;
using FluentValidation;
using MediatR;

namespace Application.Common.Behaviors;

public class ValidatorPipelineBehavior<TRequest, TResponse> 
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest: IRequest<TResponse>

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
        
        if (failures.Length > 0) 
            throw new InputValidationException("Your input data did not pass data validation", failures);
        
        return await next();   
        
        var errors = failures
            .GroupBy(x => x.PropertyName)
            .ToDictionary(k => k.Key, v => v.Select(x => x.ErrorMessage)
                .ToArray()
            );
    }
}