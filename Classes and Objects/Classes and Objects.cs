namespace Classes_and_Objects
{
    internal class Program
    {

        class clsPerson
        {
            //this private by default and will not be accessed from outside the class
            //for internal use only
            int x;

            public string firstName;
            public string lastName;

            public string FullName()
            {

                return firstName + " " + lastName;

            }

        }

        static void Main(string[] args)
        {

            clsPerson person1 = new clsPerson();

            person1.firstName = "Abdelrahman";
            person1.lastName = "Medhat";

            Console.WriteLine(person1.FullName());

            string s1;

        }
    }
}