
using class_tutorial;



var t = new Test();
var id = t.Id;
var count = t.Count;
t.Count = -30;

Student joe = new Student("Joe", 41);
Student jane = new Student("Jane", 31);


//Student pat = new Student(101, "Pat", 22);
//
//Console.WriteLine($"{pat.Id} | {pat.Firstname} | {pat.Age} | {pat.DateCreated}");

Console.WriteLine($"instance joe's first name is {joe.Firstname}");
joe.ChangeFirstname("Joseph");
Console.WriteLine($"instance joe's first name is {joe.Firstname}");
Console.WriteLine($"instance jane's age is {jane.Age}");
jane.IncrementAge();
Console.WriteLine($"instance jane's age is {jane.Age}");
Console.WriteLine($"instance jane's date created is {jane.DateCreated}");
var JaneDateCreatedPlus30Days = jane.CalcCreateDatePlus30Days();
Console.WriteLine($"instance jane's date created plus 30 days is {JaneDateCreatedPlus30Days}");


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


// var aString = concat("abc", "def", "ghi");
void concat(params string[] strings) { }


static int Add(int a, int b) {
    return a + b;
}