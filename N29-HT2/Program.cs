using N29_HT2;

public class Program
{
    static async Task Main(string[] args)
    {
        var employeeService = new EmployeeService();
        await employeeService.HireAsync("Mavlonbek", "Isroilov");

        Console.WriteLine("Hiring process completed.");
    }
}
