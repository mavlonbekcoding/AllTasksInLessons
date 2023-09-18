using N38_HT1;
var usersContainer = new UserContainer();
usersContainer.AddUser(new User(Guid.NewGuid(), "Mavlonbek", "Isroilov", "mavlonbekcoding@gmail.com"));
usersContainer.AddUser(new User(Guid.NewGuid(), "Mirsaid", "Ikromov", "ikromovmirsaid@gmail.com"));
usersContainer.AddUser(new User(Guid.NewGuid(), "Ahrorbek", "Sirojiddinov", "axrorbek05@gmail.com"));

var userById = usersContainer[new Guid("6f9619ff-8b86-d011-b42d-00cf4fc964ff")];
var userByKeyword = usersContainer["Alice"];
var userByIndex = usersContainer[1];

Console.WriteLine($"User by ID: {userById.FirstName} {userById.LastName}");
Console.WriteLine($"User by Keyword: {userByKeyword.FirstName} {userByKeyword.LastName}");
Console.WriteLine($"User by Index: {userByIndex.FirstName} {userByIndex.LastName}");
