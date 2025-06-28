using System.Net;
using static Structure_Inside_Class.clsPerson;

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
        private stAddress _address;

        public clsPerson()
        {

            fullName = "Abdelrahman Medhat";
            _address.addressLine1 = "Building 10";
            _address.addressLine2 = "Queen Rania Street";
            _address.city = "Mansoura";
            _address.country = "Egypt";

        }

        public stAddress Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public void PrintAddress()
        {

            Console.WriteLine("\nAddress:");
            Console.WriteLine(_address.addressLine1);
            Console.WriteLine(_address.addressLine2);
            Console.WriteLine(_address.city);
            Console.WriteLine(_address.country);

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsPerson person1 = new clsPerson();

            person1.PrintAddress();

            Console.WriteLine();

            stAddress addr;

            addr.addressLine1 = "Building 20";
            addr.addressLine2 = "Tahreer st";
            addr.city = "Cairo";
            addr.country = "Egypt";

            person1.Address = addr;

            person1.PrintAddress();

        }
    }
}
