
namespace Destructors
{


    internal class Program
    {

        class clsPerson
        {

            public string FullName;

            // Constructor
            public clsPerson()
            {
                FullName = "Mohammed Abu-Hadhoud";
                Console.WriteLine("\nHi, I'm Constructor");
            }

            // Destructor (Finalizer in C#)
            ~clsPerson()
            {
                Console.WriteLine("\nHi, I'm destructor.");
            }

        }

        static void Fun1()
        {

            // Local object (goes out of scope when method ends)
            clsPerson person1 = new clsPerson();
            // Destructor will run when garbage collector decides, not immediately


        }

        static void Fun2()
        {

            // Heap-allocated object (also subject to GC, use of new is always on heap)
            clsPerson person2 = new clsPerson();

            // Forcing null and GC to simulate `delete`
            person2 = null;
            GC.Collect();      // Force garbage collection
            GC.WaitForPendingFinalizers(); // Wait for destructor to finish

        }

        static void Main(string[] args)
        {

            Fun1();

            Fun2();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}