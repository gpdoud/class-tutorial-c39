using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_tutorial;
internal class Student {

    private static int NextId { get; set; } = 1;

    public int Id { get; private set; }
    public string Firstname { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime DateCreated { get; set; }

    // default constructor
    public Student() {
    }

    public Student(string firstname, int age) {
        Id = NextId++;
        Firstname = firstname;
        Age = age;
    }

    public void IncrementAge() { 
        Age = Age + 1; 
    }

    public void ChangeFirstname(string firstname) {
        this.Firstname = firstname;
    }

    public string CalcCreateDatePlus30Days() {
        return DateCreated.AddDays(30).ToString("MM/dd/yyyy");
    }

}
