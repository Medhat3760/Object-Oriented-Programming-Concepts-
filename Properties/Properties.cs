namespace Properties
{
    internal class Program
    {

        class clsPerson
        {

            private int _ID = 3760;
            private string _firstName;
            private string _lastName;

            //Property Get, this is a read only property because we don’t have a set function
            public int getID()
            {
                return _ID;
            }

            //Property Set
            public void setFirstName(string firstName)
            {
                _firstName = firstName;
            }

            //Property Get
            public string getFirstName()
            {
                return _firstName;
            }

            //Property Set
            public void setLastName(string lastName)
            {
                _lastName = lastName;
            }

            //Property Get
            public string getLastName()
            {
                return _lastName;
            }

            //Property Get
            public string getFullName()
            {
                return _firstName + " " + _lastName;
            }

            //_________________________________________________________________________________________________________________

            // Read Only Property
            public int ID
            {
                get { return _ID; }
            }

            // property set and get
            public string firstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            // property set and get
            public string lastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }

            // Read Only Property
            public string fullName
            {
                get { return _firstName + " " + _lastName; }
            }

        }

        static void Main(string[] args)
        {

            clsPerson person1 = new clsPerson();

            person1.setFirstName("Abdelrahman");
            person1.setLastName("Medhat");

            Console.WriteLine("ID        : " + person1.getID());
            Console.WriteLine("First Name: " + person1.getFirstName());
            Console.WriteLine("Last Name : " + person1.getLastName());
            Console.WriteLine("Full Name : " + person1.getFullName());

            Console.WriteLine();

            person1.firstName = "Abdelrahman";
            person1.lastName = "Medhat";

            Console.WriteLine("ID        : " + person1.ID);
            Console.WriteLine("First Name: " + person1.firstName);
            Console.WriteLine("Last Name : " + person1.lastName);
            Console.WriteLine("Full Name : " + person1.fullName);

        }
    }
}