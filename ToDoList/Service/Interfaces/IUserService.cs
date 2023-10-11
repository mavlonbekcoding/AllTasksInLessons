using ToDoList.Model;

namespace ToDoList.Service.Interfaces;

public interface IUserService
{
    ValueTask<ICollection<User>> Get(CancellationToken cancellationToken = default);
}
