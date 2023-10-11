using N50_HT1.Data.Model;
using N50_HT1.Service.Interfaces;
using N50_HT1.Service.Services;

namespace N50_HT1.Service.Services;

public class UserService : IUserService
{
    private List<User> users = new List<User>();
   public User UserCreate(User user)
    {
        users.Add(user);
        return user;
    }
}
