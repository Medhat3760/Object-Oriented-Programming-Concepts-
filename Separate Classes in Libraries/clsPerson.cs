namespace Separate_Classes_in_Libraries;
public class clsPerson
{

    private int _ID;
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phone;

    public clsPerson(int id, string firstName, string lastName, string email, string phone)
    {

        _ID = id;
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _phone = phone;

    }

    public int getID
    {
        get { return _ID; }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }

    public string getFullName
    {
        get { return _firstName + " " + _lastName; }
    }

    public void Print()
    {

        Console.WriteLine("\nInfo:");
        Console.WriteLine("______________________________");
        Console.WriteLine("ID        : " + _ID);
        Console.WriteLine("First Name: " + _firstName);
        Console.WriteLine("Last Name : " + _lastName);
        Console.WriteLine("Full Name : " + getFullName);
        Console.WriteLine("Email     : " + _email);
        Console.WriteLine("Phone     : " + _phone);
        Console.WriteLine("______________________________");

    }

    public void SendEmail(string subject, string body)
    {

        Console.WriteLine("\nThe following message sent successfully to email: " + _email);
        Console.WriteLine("Subject: " + subject);
        Console.WriteLine("Body   : " + body);

    }

    public void SendSMS(string textMessage)
    {

        Console.WriteLine("\nThe following SMS sent successfully to phone: " + _phone);
        Console.WriteLine(textMessage);
        
    }
    
}