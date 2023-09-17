using N40_N10Test.Data;
using N40_N10Test.Data.FilePath;
using Newtonsoft.Json;

namespace N40_N10Test.Service;

public class UserService : IUserService
{
    public UserService()
    {
        string source = File.ReadAllText(PathFile.STUDENT_PATH);
        if (string.IsNullOrEmpty(source))
            File.WriteAllText(PathFile.STUDENT_PATH, "[]");
    }
    public Student Create(Student student)
    {
        throw new NotImplementedException();
    }

    public bool Delete(long Id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Student> GetAll()
    {
        string? source = default;
        if(File.Exists(PathFile.STUDENT_PATH))
             source = File.ReadAllText(PathFile.STUDENT_PATH);

        if(source is not null)
        {
            var users = JsonConvert.DeserializeObject<IEnumerable<Student>>(source);
        }
       
    }

    public Student GetById(long Id)
    {
        throw new NotImplementedException();
    }

    public Student Update(Student student)
    {
        throw new NotImplementedException();
    }
}
