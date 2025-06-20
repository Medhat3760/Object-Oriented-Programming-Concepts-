namespace Static_Members
{
    internal class Program
    {

        class clsA
        {

            public int var;
            public static int counter = 0;

            public clsA()
            {
                counter++;
            }

            public static int Function1()
            {

                return 10;

            }

            public void Print()
            {
                Console.WriteLine("\nVar     = " + var);
                Console.WriteLine("Counter = " + counter);
            }

        }

        static void Main(string[] args)
        {

            clsA A1 = new clsA();
            clsA A2 = new clsA();
            clsA A3 = new clsA();

            A1.var = 10;
            A2.var = 20;
            A3.var = 30;

            A1.Print();
            A2.Print();
            A3.Print();

            clsA.counter = 500;

            Console.WriteLine("\nAfter changing the static member counter in the class:");

            A1.Print();
            A2.Print();
            A3.Print();

            Console.WriteLine("\nStatic method:");

            Console.WriteLine(clsA.Function1());          

        }
    }
}
