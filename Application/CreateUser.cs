using CSharpFunctionalExtensions;
using Domain;
using MediatR;

namespace Application;

public class CreateUser : IRequestHandler<CreateUserRequest,Result<CreateUserOutput>>
{
    private readonly IUserFactory _userFactory;
    private readonly IRepository<IUser> _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    
    public CreateUser(IUserFactory userFactory, IRepository<IUser> userRepository, IUnitOfWork unitOfWork)
    {
        _userFactory = userFactory;
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<CreateUserOutput>> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
        Result<IUser> user = _userFactory.Create(request.Name, request.Email);
        if (user.IsFailure)
            return Result.Failure<CreateUserOutput>("error");

        await _userRepository.Add(user.Value);
        await _unitOfWork.CommitAsync();
        
    }
}