using class_tutorial;

Student joe = new Student {
    Id = 1,
    Firstname = "Joe",
    Age = 41,
    IsActive = true,
    DateCreated = new DateTime(2023, 2, 10)
};

Console.WriteLine($"Id          : {joe.Id}");
Console.WriteLine($"Firstname   : {joe.Firstname}");
Console.WriteLine($"Age         : {joe.Age}");
Console.WriteLine($"IsActive    : {joe.IsActive}");
Console.WriteLine($"DateCreated : {joe.DateCreated}");

Customer customer1 = new Customer();
customer1.AccountNumber = "A001";
customer1.Name = "Alphabet soup";
customer1.Email = "info@alphabetsoup.com";
customer1.Phone = "800-555-1212";

Customer customer2 = new Customer {
    AccountNumber = "B002",
    Name = "ButterflySongs",
    Email = "info@butterflysongs.com",
    Phone = "888-555-2121"
};

//Console.WriteLine(customer2.Name);