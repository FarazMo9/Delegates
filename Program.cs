using System.Globalization;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber , secondNumber;
            GetUserNumbers(out firstNumber, out secondNumber);

            //F-CM: Single Delegate Iniialization
            var singleTaskDelegate=new SingleCastDelegateSample(firstNumber, secondNumber);
            singleTaskDelegate.Start();

            //F-CM: Multi Delegate Initialization
            var multiTaskDelegate = new MultiCastDelegateSample();
            multiTaskDelegate.Start();

            Console.ReadLine();
        }

        private static void GetUserNumbers(out int firstNumber, out int secondNumber)
        {
            firstNumber = 0;
            secondNumber = 0;

            bool firstNumberEntered = false, secondNumberEntered = false;

            //F-CM : getting the first number on console
            do
            {
                Console.WriteLine("Please enter the first number :");
                if (int.TryParse(Console.ReadLine(), out int parsedValue))
                {
                    firstNumber = parsedValue;
                    firstNumberEntered = true;
                }

            } while (!firstNumberEntered);

            //F-CM : getting the second number on console
            do
            {
                Console.WriteLine("Please enter the second number :");

                if (int.TryParse(Console.ReadLine(), out int parsedValue))
                {
                    secondNumber = parsedValue;
                    secondNumberEntered = true;
                }


            } while (!secondNumberEntered);

        }

       
       
    }
}
