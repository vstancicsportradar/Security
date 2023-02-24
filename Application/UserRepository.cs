using Domain;

namespace Application;

public class UserRepository : IRepository<IUser>
{
    public IUser GetById(Guid id)
    {
        return new User(Name.Create("name"), Email.Create("email"));
    }

    public Task Add(IUser entity)
    {
        throw new NotImplementedException();
    }

    public Task Update(IUser entity)
    {
        throw new NotImplementedException();
    }
}