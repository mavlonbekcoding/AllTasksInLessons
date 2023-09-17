using N40_N10Test.Data;

namespace N40_N10Test.Service;

public interface IUserService
{
    Student Create(Student student);
    Student Update(Student student);
    bool Delete(long Id);
    Student GetById(long Id);
    IEnumerable<Student> GetAll();
}
