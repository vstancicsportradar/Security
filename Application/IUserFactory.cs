using CSharpFunctionalExtensions;
using Domain;

namespace Application;

public interface IUserFactory
{
    Result<IUser> Create(string name, string email);
}