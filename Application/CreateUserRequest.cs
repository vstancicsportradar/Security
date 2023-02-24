using CSharpFunctionalExtensions;
using MediatR;

namespace Application;

public class CreateUserRequest : IRequest<Result<CreateUserOutput>>
{
    public string Name { get; set; }
    public string Email { get; set; }
}