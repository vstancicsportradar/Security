using Domain;

namespace Application;

public interface IRepository<T> where T : IAggregateRoot
{
    T GetById(Guid id);
    Task Add(T entity);
    Task Update(T entity);
}