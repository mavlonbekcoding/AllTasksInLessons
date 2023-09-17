using N37_HT1.Data.Models;
using N37_HT1.Interfaces;

namespace N37_HT1.Service;

public class UserService : IUserService
{
    public IEnumerable<User> GetUsers()
    {
        yield return new User { FirstName = "Mavlonbek", LastName = "Isroilov", UserStatus = Status.Registered };
        yield return new User { FirstName = "Ikromov", LastName = "Mirsaid", UserStatus = Status.Active };
        yield return new User { FirstName = "Obidov", LastName = "Hayitbek", UserStatus = Status.Deleted };
    }
}

