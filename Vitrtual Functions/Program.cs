namespace Vitrtual_Functions
{
    internal class Program
    {

        class clsPerson
        {

            public virtual void Print()
            {
                Console.WriteLine("Hi, i'm Person.");
            }

        }

        class clsEmployee : clsPerson
        {

            public override void Print()
            {
                Console.WriteLine("Hi, i'm Employee.");
            }

        }

        class clsStudent : clsPerson
        {

            public override void Print()
            {
                Console.WriteLine("Hi, i'm Student.");
            }

        }

        static void Main(string[] args)
        {

            clsEmployee employee1 = new clsEmployee();
            employee1.Print();

            clsStudent student1 = new clsStudent();
            student1.Print();

            Console.WriteLine();

            // Upcasting to base class reference
            clsPerson person1 = employee1;
            person1.Print();

            clsPerson person2 = student1;
            person2.Print();

        }
    }
}