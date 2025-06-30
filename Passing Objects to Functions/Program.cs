namespace Passing_Objects_to_Functions
{
    // In C#, class objects are reference types by default, so passing an object to a method (without ref) still allows modifying its fields.
    // But if you want to completely replace the object inside the method (like assigning a new one), you must use ref.
    class clsA
    {

        public int x;

        public void Print()
        {
            Console.WriteLine("\nThe value of x = "+x);
        }

    }

    internal class Program
    {

        
        static void Fun1(clsA a)
        {
            // assigning a new one
            a = new clsA(); // optional, to simulate true "by value" behavior like in C++
            a.x = 100;
        }

        static void Fun2(ref clsA a)
        {           
            a = new clsA();
            a.x = 200;
        }

        static void Main(string[] args)
        {

            clsA a1 = new clsA();

            a1.x = 50;
            Console.WriteLine("\na1.x before calling function:");
            a1.Print();

            // Pass by value, object will not be afected.
            Console.WriteLine("\na1.x after calling function1 byVal:");
            Fun1(a1);
            a1.Print();

            // Pass by reference, object will be afected.
            Console.WriteLine("\na1.x after calling function2 byRef:");
            Fun2(ref a1);
            a1.Print();

        }
    }
}