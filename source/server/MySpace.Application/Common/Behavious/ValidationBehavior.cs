using ErrorOr;
using FluentValidation;
using MediatR;
using MySpace.Application.Authentication.Commands.Register;
using MySpace.Application.Authentication.Common;

namespace MySpace.Application.Common.Behavious;

public class ValidationBehavior<TRequest, TResponse> : 
             IPipelineBehavior<TRequest, TResponse>
             where TRequest : IRequest<TResponse>
             where TResponse : IErrorOr
{
    private readonly IValidator<TRequest>? _validator;

    public ValidationBehavior(IValidator<TRequest>? validator = null)
    {
        _validator = validator;
    }

    public async Task<TResponse> Handle(TRequest request,
                                        CancellationToken cancellationToken,
                                        RequestHandlerDelegate<TResponse> next)
    {

        if (_validator is null)
        {
            return await next();
        }

        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if(validationResult.IsValid)
        {
            return await next();
        }

       // var errors = validationResult.Errors.Select(validationFailure => Error.Validation(validationFailure.PropertyName, 
              //  validationFailure.ErrorMessage)).ToList();

        var errors = validationResult.Errors
            .ConvertAll(validationFailure => Error.Validation(
                validationFailure.PropertyName, 
                validationFailure.ErrorMessage));

        return (dynamic)errors;
    }
}