using System.Threading;
using System.Xml.Linq;

namespace Objects_with_Parameterized_Constructor_and_Fixed_Array
{

    class clsA
    {

        public int x;

        public clsA(int value)
        {
            x = value;
        }

        public void Print()
        {
            Console.WriteLine("\nThe value of x = " + x);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // Initializing 3 array Objects with function calls of parameterized constructor as elements of that array
            clsA[] obj = { new clsA(10), new clsA(20), new clsA(30) };

            // using print method for each of three elements
            for (int i = 0; i < 3; i++)
            {
                obj[i].Print();
            }

            Console.ReadKey();

        }
    }
}