using System;

namespace Up_Casting_Down_Casting
{
    internal class Program
    {

        class clsPerson
        {

            public string fullName = "Abdelrahman Medhat";

        }

        class clsEmployee : clsPerson
        {

            public string title = "CEO";

        }

        static void Main(string[] args)
        {

            clsEmployee employee1 = new clsEmployee();

            // Upcasting: Convert emplyee to person.
            clsPerson person1 = employee1;

            Console.WriteLine("Upcasting:");
            Console.WriteLine(person1.fullName);


            // Downcasting: Not allowed directly like C++
            // But you can do it with explicit casting if safe.

            // this is called safe Downcasting because the person1 object was a (clsEmployee) type.
            clsEmployee employee2 = (clsEmployee)person1;

            Console.WriteLine("\nSafe Downcasting:");
            Console.WriteLine(employee2.fullName);
            Console.WriteLine(employee2.title);

            clsPerson person2 = new clsPerson();

            // this is unsafe Downcasting because the person2 object wasn't a (clsEmployee) type.
            // This would throw an InvalidCastException at runtime.          
            //clsEmployee employee3 = (clsEmployee)person2;

            // Check Safe Downcasting
            if (person2 is clsEmployee employee)
            {               
                Console.WriteLine(employee.title);
            }
            else
            {
                Console.WriteLine("\nThis person is not an employee.");
            }

            Console.ReadKey();

        }
    }
}