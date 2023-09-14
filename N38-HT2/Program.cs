using Bogus;
using N38_HT2;
int isSeed = 1;

var fakerEmployees = new Faker<Employee>()
    .RuleFor(e => e.Id, f => isSeed++)
    .RuleFor(e => e.Name, f => f.Person.FirstName)
    .RuleFor(e => e.PhoneNumber, f => f.Person.Phone)
    .RuleFor(e => e.Amount, f => f.Random.Decimal(1000, 10000))
    .RuleFor(e => e.Email, f => f.Person.Email);

var employees = fakerEmployees.Generate(50);

foreach (var employee in employees)
{
    Console.WriteLine($"Id: {employee.Id}");
    Console.WriteLine($"Name: {employee.Name}");
    Console.WriteLine($"PhoneNumber: {employee.PhoneNumber}");
    Console.WriteLine($"Amount: {employee.Amount}");
    Console.WriteLine($"Email: {employee.Email}");
    Console.WriteLine();
}

/////////////////////////////////////////
var fakerOrder = new Faker<Order>()
    .RuleFor(o => o.Id, f => f.Random.Int(1, 1000))
    .RuleFor(o => o.Name, f => f.Commerce.ProductName())
    .RuleFor(o => o.Description, f => f.Lorem.Sentence())
    .RuleFor(o => o.Price, f => f.Random.Double(10, 1000))
    .RuleFor(o => o.OrderCreatTime, f => f.Date.Past());

var orders = fakerOrder.Generate(100);

foreach (var order in orders)
{
    Console.WriteLine($"Id: {order.Id}");
    Console.WriteLine($"Name: {order.Name}");
    Console.WriteLine($"Description: {order.Description}");
    Console.WriteLine($"Price: {order.Price}");
    Console.WriteLine($"OrderCreateTime: {order.OrderCreatTime}");
    Console.WriteLine();
}

//////////////////////////////////
var fakerUserAddress = new Faker<UserAddress>()
    .RuleFor(a => a.Id, f => f.Random.Int(1, 1000_000))
    .RuleFor(a => a.Name, f => f.Person.FullName)
    .RuleFor(a => a.Description, f => f.Lorem.Sentence())
    .RuleFor(a => a.Amount, f => f.Random.Double(10, 1000))
    .RuleFor(a => a.City, f => f.Address.City());

var userAddresses = fakerUserAddress.Generate(1000);

foreach (var userAddress in userAddresses)
{
    Console.WriteLine($"Id: {userAddress.Id}");
    Console.WriteLine($"Name: {userAddress.Name}");
    Console.WriteLine($"Description: {userAddress.Description}");
    Console.WriteLine($"Amount: {userAddress.Amount}");
    Console.WriteLine($"City: {userAddress.City}");
    Console.WriteLine();
}

////////////////
var fakerBlogPost = new Faker<BlogPost>()
    .RuleFor(bp => bp.Id, f => f.Random.Int(1, 1000))
    .RuleFor(bp => bp.Name, f => f.Lorem.Sentence())
    .RuleFor(bp => bp.Description, f => f.Lorem.Paragraph())
    .RuleFor(bp => bp.SendTime, f => f.Date.Past())
    .RuleFor(bp => bp.Price, f => f.Random.Double(10, 100));

var blogPosts = fakerBlogPost.Generate(90);

foreach (var blogPost in blogPosts)
{
    Console.WriteLine($"Id: {blogPost.Id}");
    Console.WriteLine($"Name: {blogPost.Name}");
    Console.WriteLine($"Description: {blogPost.Description}");
    Console.WriteLine($"Send Time: {blogPost.SendTime}");
    Console.WriteLine($"Price: {blogPost.Price}");
    Console.WriteLine();
}

/////
var fakerWeatherReport = new Faker<WeatherReport>()
    .RuleFor(wr => wr.Id, f => f.Random.Int(1, 1000))
    .RuleFor(wr => wr.Description, f => f.Lorem.Sentence())
    .RuleFor(wr => wr.Name, f => f.Lorem.Word())
    .RuleFor(wr => wr.City, f => f.Address.City())
    .RuleFor(wr => wr.Temperature, f => f.Random.Double(-10, 40));

var weatherReports = fakerWeatherReport.Generate(500);
foreach (var weatherReport in weatherReports)
{
    Console.WriteLine($"Id: {weatherReport.Id}");
    Console.WriteLine($"Description: {weatherReport.Description}");
    Console.WriteLine($"Name: {weatherReport.Name}");
    Console.WriteLine($"City: {weatherReport.City}");
    Console.WriteLine($"Temperature: {weatherReport.Temperature}°C");
    Console.WriteLine();
}
