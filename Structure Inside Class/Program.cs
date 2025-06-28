namespace Structure_Inside_Class
{

    class clsPerson
    {

        public struct stAddress
        {

            public string addressLine1;
            public string addressLine2;
            public string city;
            public string country;

        }

        public string fullName;
        public stAddress address;

        public clsPerson()
        {

            fullName = "Abdelrahman Medhat";
            address.addressLine1 = "Building 10";
            address.addressLine2 = "Queen Rania Street";
            address.city = "Mansoura";
            address.country = "Egypt";

        }

        public void PrintAddress()
        {

            Console.WriteLine("\nAddress:");
            Console.WriteLine(address.addressLine1);
            Console.WriteLine(address.addressLine2);
            Console.WriteLine(address.city);
            Console.WriteLine(address.country);

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsPerson person1 = new clsPerson();

            person1.PrintAddress();

        }
    }
}