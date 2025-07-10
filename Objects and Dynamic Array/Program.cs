namespace Objects_and_Dynamic_Array
{
    internal class Program
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
                Console.WriteLine("\nThe value of x is = " + x);
            }

        }

        static void Main(string[] args)
        {

            short numberOfObjects = 5;

            // allocating dynamic array of Size numberOfObjects (null)
            clsA[] arrA = new clsA[numberOfObjects];

            // Initialize each object using parameterized constructor
            for (int i = 0; i < numberOfObjects; i++)
            {
                arrA[i] = new clsA(i);
            }

            // Print each object's content
            for (int i = 0; i < numberOfObjects; i++)
            {
                arrA[i].Print();
            }

            Console.ReadKey();

        }
    }
}