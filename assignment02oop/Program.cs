using System;

enum Gender
{
    M, 
    F  
}

enum SecurityLevel
{
    Guest,
    Developer,
    Secretary,
    DBA,
    SecurityOfficer
}



class Employee
{
    public int ID { get; set; }

    private string name;
    public string Name
    {
        get => name;
        set => name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Name cannot be empty.");
    }

    public Gender Gender { get; set; }

    private double salary;
    public double Salary
    {
        get => salary;
        set => salary = value >= 0 ? value : throw new ArgumentException("Salary must be non-negative.");
    }

   // public HiringDate HireDate { get; set; }
    public SecurityLevel SecurityLevel { get; set; }

    public Employee(int id, string name, Gender gender, double salary, SecurityLevel securityLevel)
    {
        ID = id;
        Name = name;
        Gender = gender;
        Salary = salary;
      
        SecurityLevel = securityLevel;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {String.Format( "{0:C}", Salary)}, ";
             
    }
}


class Program
{
    static void Main()
    {

        Console.WriteLine("class creatd");
      
        
    }
}
