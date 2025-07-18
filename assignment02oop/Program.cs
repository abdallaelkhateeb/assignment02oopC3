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


#region Q1
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

    public HiringDate HireDate { get; set; }
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

#endregion

#region Q2

class HiringDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public HiringDate(int day, int month, int year)
    {
        if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1900)
            throw new ArgumentException("Invalid date.");
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day:D2}/{Month:D2}/{Year}";
    }
}
#endregion
class Program
{
    static void Main()
    {
        #region Q3
        Employee[] EmpArr = new Employee[3];

        EmpArr[0] = new Employee(
            id: 1001,
            name: "Ali",
            gender: Gender.M,
            salary: 12000,
            hireDate: new HiringDate(15, 7, 2025),
            securityLevel: SecurityLevel.DBA
        );
15
        EmpArr[1] = new Employee(
            id: 1002,
            name: "Bob",
            gender: Gender.M,
            salary: 5000,
            hireDate: new HiringDate(16, 7, 2025),
            securityLevel: SecurityLevel.Guest
        );

        EmpArr[2] = new Employee(
            id: 1003,
            name: "Charlie",
            gender: Gender.M,
            salary: 20000,
            hireDate: new HiringDate(17, 7, 2025),
            securityLevel: SecurityLevel.SecurityOfficer
        );

        #endregion
    }
}
