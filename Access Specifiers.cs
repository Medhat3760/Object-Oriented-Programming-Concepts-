using System.ComponentModel;

namespace Access_Specifiers
{
    internal class Program
    {

        class clsPerson
        {
            // only accessable inside this class
            private int variable1 = 5;

            private int Function1()
            {
                return 40;
            }

            // only accessable inside this class and all classes inhirets this calss
            protected int variable2 = 100;

            protected int Function2()
            {
                return 50;
            }


            //accessable for everyone outside/inside/and classes inherits this class
            public string firstName;
            public string lastName;

            public string FullName()
            {

                return firstName + " " + lastName;

            }

            public float Function3()
            {
                return Function1() * variable1 * variable2;
            }

        }

        static void Main(string[] args)
        {

            clsPerson person1 = new clsPerson();

            person1.firstName = "Abdelrahman";
            person1.lastName = "Medhat";

            Console.WriteLine(person1.FullName());

            Console.WriteLine(person1.Function3());

        }
    }
}