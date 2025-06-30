namespace Objects_and_Vectors
{

    class clsA
    {

        public int x;

        public clsA(int val)
        {
            x = val;
        }

        public void Print()
        {
            Console.WriteLine("\nThe value of x = "+x);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List<clsA> list1 = new List<clsA>();

            short numberOfObjects = 5;

            for(short i = 0; i < numberOfObjects; i++)
            {
                list1.Add(new clsA(i));
            }

            for(short i = 0; i < numberOfObjects; i++)
            {
                list1[i].Print();
            }

        }
    }
}