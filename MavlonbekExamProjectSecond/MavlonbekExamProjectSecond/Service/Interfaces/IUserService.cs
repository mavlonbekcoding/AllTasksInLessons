using MavlonbekExamProjectSecond.Domain.Entities.Users;
using MavlonbekExamProjectSecond.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavlonbekExamProjectSecond.Service.Interfaces
{
    public interface IUserService
    {
        Response<User> Create(User User);
        Response<User> Update(User user);
        Response<bool> Delete(long Id);
        Response<User> GetById(long Id);
        Response<IEnumerable<User>> GetAll();
    }
}
