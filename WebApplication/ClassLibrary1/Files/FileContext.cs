using System.Text.Json;
using Application.Models;

namespace Application.Files
{
    public class FileContext : IFileContext
    {
        private string _filepath = @"D:\users.txt";
        private List<User> users = new List<User>();
        public User AddUser(User user)
        {
            users.Add(user);
            var jsonData = JsonSerializer.Serialize(users);
            File.WriteAllText(_filepath, jsonData);
            return user;
        }
    }
}
