using Application.Models;

namespace Application.Files
{
    public interface IFileContext
    {
        User AddUser(User user);
    }
}
