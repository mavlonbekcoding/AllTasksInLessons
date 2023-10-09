using N45_HT1.Model;
//Add user begin
List<User> users = new List<User>();

User userA = new User();
userA.firstName = "Mavlonbek";
userA.Id = 1;
users.Add(userA);

User userB = new User();
userB.firstName = "Mirsaid";
userB.Id = 2;
users.Add(userB);

User userC = new User();
userC.firstName = "Mashxurbek";
userC.Id = 3;
users.Add(userC);
//Add user finish
List<Order> orders = new List<Order>();
//Add order begin
Order orderA = new Order();
orderA.Id = 1;
orderA.Amount = 1_000_00;
orderA.userId = 1;

Order orderB = new Order();
orderB.Id = 2;
orderB.Amount = 2_00_00;
orderB.userId = 2;

List<OrderProduct> orderProducts = new List<OrderProduct>();

OrderProduct orderProductA = new OrderProduct();
orderProductA.Count = 5;
orderProductA.productId = 1;
orderProductA.Id = 1;
orderProducts.Add(orderProductA);

OrderProduct orderProductB = new OrderProduct();
orderProductB.Count = 10;
orderProductB.productId = 2;
orderProductB.Id = 2;
orderProducts.Add(orderProductB);


List<Product> products = new List<Product>();

Product productA = new Product();
productA.Name = "HP laptop";
productA.Id = 1;
productA.Price = 1_00_0;

Product productB = new Product();
productB.Name = "HP laptop";
productB.Id = 1;
productB.Price = 1_00_0;

var query = 
    from