using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class SingleCastDelegateSample(int a,int b)
    {
        delegate int SumDelegate(int firstNumber, int secondNumber); //The delegate property by the same output and parameters

        internal void Start()
        {
            Console.WriteLine("Checking single delegate ...");

            //F-CM : Initializing delegate
            SumDelegate delegateItem = new SumDelegate(SummerizeTwoNumbers);

            Console.WriteLine("Delegate is initialized by the SummerizeTwoNumbers function which has the same return type and parameters.");

            var sumOfInputNumbers = delegateItem?.Invoke(a, b);


            Console.WriteLine($"Delegate is invoked and the target \"Sum\" function is called. Result : {sumOfInputNumbers}");
        }

        private static int SummerizeTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
