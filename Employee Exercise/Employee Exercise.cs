using System.Security.Cryptography;

namespace Employee_Exercise
{
    internal class Program
    {

        class clsPerson
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

            public void SendSMS(string sms)
            {

                Console.WriteLine("\nThe following SMS sent successfully to phone: " + _phone);
                Console.WriteLine(sms);

            }

        }

        class clsEmployee : clsPerson
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
            
            // Overriding Function
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

        static void Main(string[] args)
        {

            clsEmployee employee1 = new clsEmployee(10, "Abdelrahman", "Medhat", "my@gmail.com", "0649046134", "CEO", "Communications", 30000);

            employee1.Print();

            Console.ReadKey();

        }

    }

}

