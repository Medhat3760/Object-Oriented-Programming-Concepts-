using System.Diagnostics.Metrics;

namespace Nested_Classes
{

    class clsPerson
    {

        public class clsAddress
        {

            string _addressLine1;
            string _addressLine2;
            string _city;
            string _country;

            public clsAddress(string addressLine1, string addressLine2, string city, string country)
            {

                _addressLine1 = addressLine1;
                _addressLine2 = addressLine2;
                _city = city;
                _country = country;

            }

            public string AddressLine1
            {
                get { return _addressLine1; }
                set { _addressLine1 = value; }
            }

            public string AddressLine2
            {
                get { return _addressLine2; }
                set { _addressLine2 = value; }
            }

            public string City
            {
                get { return _city; }
                set { _city = value; }
            }

            public string Country
            {
                get { return _country; }
                set { _country = value; }
            }

            public void Print()
            {
                Console.WriteLine("\nAddress:");
                Console.WriteLine(_addressLine1);
                Console.WriteLine(_addressLine2);
                Console.WriteLine(_city);
                Console.WriteLine(_country);
            }

        }

        string _fullName;
        clsAddress _address = new clsAddress("", "", "", "");

        public clsPerson(string fullName,string addressLine1, string addressLine2, string city, string country)
        {

            _fullName = fullName;

            _address = new clsAddress(addressLine1, addressLine2, city, country);

        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public clsAddress Address
        {
            get { return _address; }
            set { _address = value; }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsPerson person1 = new clsPerson("Abdelrahman Medhat", "Building 10", "Tahreer Street", "Cairo", "Egypt");

            Console.WriteLine("\nName: " + person1.FullName);

            person1.Address.Print();

            Console.ReadKey();

        }
    }
}