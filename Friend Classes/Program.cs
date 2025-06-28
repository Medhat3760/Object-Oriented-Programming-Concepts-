namespace Friend_Classes
{

    // Note:
    // In C#, there is no direct equivalent to C++'s friend keyword,
    // because C# enforces stricter access control
    // and does not allow one class to access private members of another
    // unless they're nested or use other mechanisms (Changing the private modifier to internal modifier).

    internal class Program
    {

        class clsA
        {

            internal int _var1;

            public int var2;

            public clsA()
            {
                _var1 = 10;
                var2 = 20;
            }           

        }

        class clsB
        {

            public void Display(clsA a)
            {

                Console.WriteLine("\nThe value of Var1 = " + a._var1);
                Console.WriteLine("\nThe value of Var2 = " + a.var2);

            }

        }

        static void Main(string[] args)
        {

            clsA a = new clsA();
            clsB b = new clsB();

            Console.WriteLine(a._var1);

            b.Display(a);

            Console.ReadKey();

        }
    }
}