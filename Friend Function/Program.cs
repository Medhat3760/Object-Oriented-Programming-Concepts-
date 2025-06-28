using static Friend_Function.Program;

namespace Friend_Function
{

    // In C#, there is no direct equivalent to C++'s friend keyword,
    // because C# enforces stricter access control
    // and does not allow any non member function to access private members of the class.

    // unless use other mechanisms ( use internal or public modifier with the class and the members )

    // if the non member function is inside another high level class (like namespace level) you must use internal or public with the first class.

    internal class Program
    {

        internal class clsA
        {

            //private int _var1;
            //protected int _var2;

            // another mechanism
            internal int _var1;
            internal int _var2;
            public int var3;

            public clsA()
            {
                _var1 = 10;
                _var2 = 20;
                var3 = 30;
            }

        }

        public static int MySum(clsA a)
        {

            return a._var1 + a._var2 + a.var3;

        }

        static void Main(string[] args)
        {

            clsA a1 = new clsA();

            Console.WriteLine(MySum(a1));

            Console.ReadKey();

        }
    }
}