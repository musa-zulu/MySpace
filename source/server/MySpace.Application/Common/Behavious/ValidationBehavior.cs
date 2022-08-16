using ErrorOr;
using MediatR;
using MySpace.Application.Authentication.Commands.Register;
using MySpace.Application.Authentication.Common;

namespace MySpace.Application.Common.Behavious;

public class ValidateRegisterCommandBehavior : IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand request,
                                                      CancellationToken cancellationToken,
                                                      RequestHandlerDelegate<ErrorOr<AuthenticationResult>> next)
    {
        //logic to be invoked before the handler
        var result = await next();
        //logic to be invoked after the handler

        return result;
    }
}