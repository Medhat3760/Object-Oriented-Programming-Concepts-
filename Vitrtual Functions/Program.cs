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
            clsStudent student1 = new clsStudent();

            // Late/Dynamic Binding: at runtime
            employee1.Print();
            student1.Print();

            Console.WriteLine();

            // Upcasting to base class reference
            clsPerson person1 = employee1;
            clsPerson person2 = student1;

            // Late/Dynamic Binding: at runtime
            person1.Print();
            person2.Print();

        }
    }
}
