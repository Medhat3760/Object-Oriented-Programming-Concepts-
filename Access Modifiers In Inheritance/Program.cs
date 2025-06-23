using System.ComponentModel;

namespace Access_Modifiers_In_Inheritance
{
    internal class Program
    {

        class clsA
        {
            // only accessible inside this class, neither derived classes nor outside class.
            private int _var1;

            private void Fun1()
            {
                Console.WriteLine("\nFunction 1");
            }

            // only accessible inside this class and all derived classes, but not outside class.
            protected int var2;

            protected void Fun2()
            {
                Console.WriteLine("\nFunction 2");
            }

            // Accessible inside this class, all derived classes, and outside class.
            public int var3;

            public void Fun3()
            {

                Console.WriteLine("\nFunction 3");

            }

        }

        class clsB : clsA
        {

            // have access to public and protected members.

            public void Fun4()
            {

                Console.WriteLine("\n" + var2);

                Fun2();

            }

        }

        static void Main(string[] args)
        {

            // have access to public members only.

            clsB b = new clsB();

            b.Fun3();

            b.Fun4();

        }
    }
}