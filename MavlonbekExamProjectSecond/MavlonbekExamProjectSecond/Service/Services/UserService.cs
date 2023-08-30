using MavlonbekExamProjectSecond.Data.Constants;
using MavlonbekExamProjectSecond.Domain.Entities.Users;
using MavlonbekExamProjectSecond.Service.Helpers;
using MavlonbekExamProjectSecond.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavlonbekExamProjectSecond.Service.Services
{
   public class UserService : IUserService
{
    public UserService() 
    {
        string source = File.ReadAllText(PathFile.USER_PATH);

        if (string.IsNullOrEmpty(source))
            File.WriteAllText(PathFile.USER_PATH, "[]");
    }
    public Response<User> Create(User user)
    {
        string source = File.ReadAllText(PathFile.USER_PATH);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(source);

        User existUser = users.FirstOrDefault(u  => u.Id == user.Id);

        if (existUser is not null)
            return new Response<User>()
            {

                StatusCode = 200,
                Message = "already exists",
                Data = existUser
            };
        if (users.Count == 0)
            user.Id = 0;
        else
            user.Id = users.LastOrDefault().Id + 1;

        user.CreateAt = DateTime.Now;
        users.Add(user);
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);   
        File.WriteAllText(PathFile.USER_PATH , json);
        return new Response<User>()
        {
            StatusCode = 200,
            Message = "succes",
            Data = user
        };
    }

    public Response<User> Update(User user)
    {
        string sourse = File.ReadAllText(PathFile.USER_PATH);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(sourse);

        User existUser = users.FirstOrDefault(u =>u.Id == user.Id);
        if (existUser is null)
            return new Response<User>()
            {
                StatusCode = 404,
                Data = existUser,
                Message = "This user not fount"
            };

       
        existUser.FirstName = user.FirstName;
        existUser.LastName = user.LastName;
        existUser.PhoneNumber = user.PhoneNumber;
        existUser.UpdateAt = DateTime.Now;

        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText (PathFile.USER_PATH , json);
        return new Response<User>()
        {
            StatusCode = 200,
            Data = user,
            Message = "Succsess"
        };
    }
    public Response<bool> Delete(long Id)
    {
        string sourse = File.ReadAllText(PathFile.USER_PATH);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(sourse);

        User existUser = users.FirstOrDefault(u =>u.Id == Id);

        if (existUser is null)
            return new Response<bool>()
            {
                StatusCode = 404,
                Message = "This student not fount",
                Data = false
            };
        users.Remove(existUser);

        string source = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(PathFile.USER_PATH , source);

        return new Response<bool>()
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    

    public Response<User> GetById(long Id)
    {
        string sourse = File.ReadAllText(PathFile.USER_PATH);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(sourse);

        User existUser = users.FirstOrDefault(u => u.Id.Equals(Id));

        if (existUser is null)
            return new Response<User>()
            {
                StatusCode = 404,
                Message = "This student not fount",
                Data = null
            };

        return new Response<User>()
        {
            StatusCode = 200,
            Message = "Success",
            Data = existUser
        };

    }


    public Response<IEnumerable<User>> GetAll()
    {
        string sourse = File.ReadAllText(PathFile.USER_PATH);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(sourse);

        return new Response<IEnumerable<User>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = users
        };
    }
}

}
