using N32_T1;
using System.Text.Json;

string LocationPath = @"D:\FileTest\Location.json";
string SpecialityPath = @"D:\FileTest\Speciality.json";
string StudentsPath = @"D:\FileTest\Student.json";

var Students = JsonSerializer.Deserialize<List<Student>>
                                  (File.ReadAllText(StudentsPath));
var Specialityes = JsonSerializer.Deserialize<List<Speciality>>
                          (File.ReadAllText(SpecialityPath));
var Locations = JsonSerializer.Deserialize<List<Location>>
                          (File.ReadAllText(LocationPath));

var SelectStudents = Specialityes.GroupJoin(Students,
    specialityes => specialityes.id,
    students => students.speciality_id,
    (Specialityes, students) => new
    {
        Specialityes = Specialityes,
        Students = students
    }
    );
//Console.WriteLine(JsonSerializer.Serialize(SelectStudents));

/*
Console.WriteLine(JsonSerializer.Serialize(SelectStudents.Select(x => x.Specialityes.speciality_name)));
*/Console.WriteLine(JsonSerializer.Serialize(SelectStudents.GroupBy(x => x.Students.Count())));

//var ResultGroupBy = Specialityes.GroupBy(x => x.);