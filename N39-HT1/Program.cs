using N39_HT1;
List <User> users = new List<User>();
List<WeatherReport> weatherReports  = new List<WeatherReport>();

User userA = new User();
userA.FirstName = "Mavlonbek";
userA.LastName = "Isroilov";
users.Add(userA);

User userB = new User();
userB.FirstName = "John";
userB.LastName = "Yaqubov";
users.Add(userB);

User userC = new User();
userC.FirstName = "Firdavs";
userC.LastName = "Qurbonaliyev";
users.Add(userC);

WeatherReport weatherReportA = new WeatherReport();
weatherReportA.Degree = 40;
weatherReportA.State = "Uzbekistan";
weatherReports.Add(weatherReportA);

WeatherReport weatherReportB = new WeatherReport();
weatherReportB.Degree = 35;
weatherReportB.State = "Xorazm";
weatherReports.Add(weatherReportB);

WeatherReport weatherReportC = new WeatherReport();
weatherReportC.Degree = 30;
weatherReportC.State = "Andijon";
weatherReports.Add(weatherReportC);

foreach(User user in users)
{
    if(user is {FirstName : "John"})
        Console.WriteLine(user.FirstName);
}

foreach(WeatherReport weatherReport in weatherReports)
{
    if (weatherReport is { Degree : > 30})
        Console.WriteLine(weatherReport.Degree);
}