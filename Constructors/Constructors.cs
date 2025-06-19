namespace Constructors
{
    internal class Constructors
    {

        class clsAddress
        {

            private string _addressLine1;
            private string _addressLine2;
            private string _poBox;
            private string _zipCode;

            public clsAddress()
            {
                Console.WriteLine("Hi, im a constructor.");
            }

            public clsAddress(string addressLine1, string addressLine2, string poBox, string zipCode)
            {
                
                _addressLine1 = addressLine1;
                _addressLine2 = addressLine2;
                _poBox = poBox;
                _zipCode = zipCode;

            }

            // copy constructor 
            //public clsAddress(ref clsAddress old_obj)
            //{

            //    _addressLine1 = old_obj._addressLine1;
            //    _addressLine2 = old_obj._addressLine2;
            //    _poBox= old_obj._poBox;
            //    _zipCode= old_obj._zipCode;

            //}

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

            public string POBox
            {
                get { return _poBox; }
                set { _poBox = value; }
            }

            public string ZipCode
            {
                get { return _zipCode; }
                set { _zipCode = value; }
            }


            public void Print()
            {

                Console.WriteLine("\nAddress Details:");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Address Line1: " + _addressLine1);
                Console.WriteLine("Address Line2: " + _addressLine2);
                Console.WriteLine("PO Box       : " + _poBox);
                Console.WriteLine("Zip Code     : " + _zipCode);

            }

        }

        static void Main(string[] args)
        {

            clsAddress address1 = new clsAddress("Hospital Street", "A 303", "11183", "4444");

            address1.Print();

            // copy constructor
            //clsAddress address2 = new clsAddress(ref address1);

            // compiler will do copy constructor automatically
            clsAddress address2 = address1;

            address2.Print();

        }
    }
}
