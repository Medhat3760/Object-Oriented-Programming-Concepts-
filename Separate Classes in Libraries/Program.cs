namespace Separate_Classes_in_Libraries
{

    // Separating Code and Classes in Libraries will make our life easier and we can control our code and organize it better.

    internal class Program
    {

        static void Main(string[] args)
        {

            clsEmployee employee1 = new clsEmployee(10, "Abdelrahman", "Medhat", "my@gmail.com", "0649046134", "CEO", "Communications", 30000);

            employee1.Print();
            
            Console.ReadKey();

        }

    }

}
