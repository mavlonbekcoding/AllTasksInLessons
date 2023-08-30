using Application.Files;
using Application.Models;

namespace Application.Services
{
    public class UserService: IUserService
    {
        private readonly IFileContext _fileContext;

        public UserService(IFileContext fileContext)
        {
            _fileContext = fileContext;
        }

        public User AddUser(User user)
        {
            return _fileContext.AddUser(user);
        }
    }
}
