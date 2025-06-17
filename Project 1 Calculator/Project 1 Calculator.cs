namespace Project_1_Calculator
{
    internal class Program
    {

        class clsCalculator
        {

            private float _previousResult;
            private float _result;
            private float _lastNumber;
            private string _lastOperation;


            public void Clear()
            {

                _previousResult = 0;
                _lastNumber = 0;
                _result = 0;
                _lastOperation = "Clear";

            }

            public void Add(float number)
            {

                _previousResult = _result;
                _lastNumber = number;
                _result += number;
                _lastOperation = "Adding";

            }

            public void Subtract(float number)
            {

                _previousResult = _result;
                _lastNumber = number;
                _result -= number;
                _lastOperation = "Subtracting";

            }

            // Abstraction
            private bool _IsZero(float number)
            {
                return number == 0;
            }

            public void Divide(float number)
            {

                _lastNumber = number;

                // for demo purpose 
                if (_IsZero(number))
                {
                    number = 1;
                }

                _previousResult = _result;
                _result /= number;
                _lastOperation = "Dividing";

            }

            public void Multiply(float number)
            {

                _previousResult = _result;
                _lastNumber = number;
                _result *= number;
                _lastOperation = "Multiplying";

            }

            public void CancelLastOperation()
            {

                _lastNumber = 0;
                _result = _previousResult;
                _lastOperation = "Cancelling Last Operation";

            }

            public float getFinalResult()
            {
                return _result;
            }

            public void PrintResult()
            {

                Console.WriteLine($"Result After {_lastOperation} {_lastNumber} is: {_result}");

            }

        }

        static void Main(string[] args)
        {

            clsCalculator calculator1 = new clsCalculator();

            calculator1.Clear();

            calculator1.Add(10);
            calculator1.PrintResult();

            calculator1.Add(100);
            calculator1.PrintResult();

            calculator1.Subtract(20);
            calculator1.PrintResult();

            calculator1.Divide(0);
            calculator1.PrintResult();

            calculator1.Divide(2);
            calculator1.PrintResult();

            calculator1.Multiply(3);
            calculator1.PrintResult();

            calculator1.CancelLastOperation();
            calculator1.PrintResult();

            calculator1.Clear();
            calculator1.PrintResult();

        }
    }
}