namespace Employee_Exercise
{
    internal class Program
    {

        class clsEmployee
        {

            int _ID;
            string _firstName;
            string _lastName;
            string _title;
            string _email;
            string _phone;
            double _salary;
            string _department;

            public clsEmployee(int id, string firstName, string lastName, string title, string email, string phone, double salary, string department)
            {

                _ID = id;
                _firstName = firstName;
                _lastName = lastName;
                _title = title;
                _email = email;
                _phone = phone;
                _salary = salary;
                _department = department;

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

            public string Title
            {
                get { return _title; }
                set
                {
                    _title = value;
                }
            }

            public string Email
            {
                get { return _email; }
                set
                {
                    _email = value;
                }
            }

            public string Phone
            {
                get { return _phone; }
                set
                {
                    _phone = value;
                }
            }

            public double Salary
            {
                get { return _salary; }
                set
                {
                    _salary = value;
                }
            }

            public string Department
            {
                get { return _department; }
                set
                {
                    _department = value;
                }
            }

            public string getFullName
            {
                get { return _firstName + " " + _lastName; }
            }

            public void Print()
            {

                Console.WriteLine("\nInfo:");
                Console.WriteLine("__________________________");
                Console.WriteLine("ID        : " + _ID);
                Console.WriteLine("First Name: " + _firstName);
                Console.WriteLine("Last Name : " + _lastName);
                Console.WriteLine("Title     : " + _title);
                Console.WriteLine("Email     : " + _email);
                Console.WriteLine("Phone     : " + _phone);
                Console.WriteLine("Salary    : " + _salary);
                Console.WriteLine("Department: " + _department);
                Console.WriteLine("__________________________");

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

        static void Main(string[] args)
        {

            clsEmployee employee1 = new clsEmployee(10, "Abdelrahman", "Medhat", "TS", "my@gmail.com", "0649046134", 30000, "Communications");

            employee1.Print();

            employee1.SendEmail("Hello", "You are welcome");

            employee1.SendSMS("You are welcome");

            Console.ReadKey();

        }

    }

}

