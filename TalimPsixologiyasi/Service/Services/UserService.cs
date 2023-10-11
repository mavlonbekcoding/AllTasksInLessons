using TalimPsixologiyasi.Model;
using TalimPsixologiyasi.Service.Interfaces;

namespace TalimPsixologiyasi.Service.Services;

public class UserService : IStudentService
{
    List<Student> students = new List<Student>();
    public Student Create(Student student)
    {
        students.Add(student);
        return student;
    }
}
