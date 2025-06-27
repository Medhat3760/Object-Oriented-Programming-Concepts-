namespace Abstract_Class
{
    internal class Program
    {

        // Abstract class | Interface | Contract.
        abstract class clsMobile
        {
            public int var1;
            public abstract void Dial(string phoneNumber); // Must be overridden

            public abstract void SendSMS(string phoneNumber, string textMessage); // Must be overridden

            public abstract void TakePicture(); // Must be overridden

        }

        class clsIphone : clsMobile
        {
            // This class signed a contract with clsMobile abstract class
            // therefore it should implement everything in the abstract class.
            public override void Dial(string phoneNumber)
            {
                // body 

            }

            public override void SendSMS(string phoneNumber, string textMessage)
            {
                // body
            }

            public override void TakePicture()
            {
                // body
            }

        }

        class clsSamsungNote10 : clsMobile
        {
            // This class signed a contract with clsMobile abstract class
            // therefore it should implement everything in the abstract class.
            public override void Dial(string phoneNumber)
            {
                // body
            }

            public override void SendSMS(string phoneNumber, string textMessage)
            {
                // body
            }

            public override void TakePicture()
            {
                // body
            }

        }

        static void Main(string[] args)
        {

            clsIphone iphone1 = new clsIphone();

            clsSamsungNote10 note10 = new clsSamsungNote10();

        }
    }
}