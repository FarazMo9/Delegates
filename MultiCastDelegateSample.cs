using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class MultiCastDelegateSample
    {
        delegate int MultiTaskDelegate();
        internal void Start()
        {
            Console.WriteLine("Checking multi task delegate ...");


            MultiTaskDelegate delegateItem = new MultiTaskDelegate(FirstStep);
            delegateItem += SecondStep;
            Console.WriteLine("Delegate is initialized.");

            var result = delegateItem?.Invoke();

            //F-CM : You may check the result which is the last invoked step return value
            Console.WriteLine($"Delegate is invoked. Result : {result}");

        }

        private int FirstStep()
        {
            Console.WriteLine("First task is invoked.");
            return 0;
        }

        private int SecondStep()
        {
            Console.WriteLine("Second task is invoked.");
            return 1;
        }
    }
}
