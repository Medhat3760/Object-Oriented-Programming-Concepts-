namespace Separate_Classes_in_Libraries;
public class clsEmployee : clsPerson
{

    string _title;
    string _department;
    float _salary;

    public clsEmployee(int id, string firstName, string lastName, string email, string phone, string title, string department, float salary) : base(id, firstName, lastName, email, phone)
    {

        // super construcor class is loaded firstly before the Derived class constructor body being executed.

        _title = title;
        _department = department;
        _salary = salary;

    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }

    public float Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }

    // Function Overridding
    public void Print()
    {

        Console.WriteLine("\nInfo:");
        Console.WriteLine("______________________________");
        Console.WriteLine("ID        : " + getID);
        Console.WriteLine("First Name: " + FirstName);
        Console.WriteLine("Last Name : " + LastName);
        Console.WriteLine("Full Name : " + getFullName);
        Console.WriteLine("Email     : " + Email);
        Console.WriteLine("Phone     : " + Phone);
        Console.WriteLine("Title     : " + _title);
        Console.WriteLine("Department: " + _department);
        Console.WriteLine("Salary    : " + _salary);
        Console.WriteLine("______________________________");

    }
    
}