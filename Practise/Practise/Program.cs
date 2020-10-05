using BL;
using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            var advancedOperation = new AdvancedOperation(new BasicOperation());
            ExpertOperation expertOperation = new ExpertOperation(advancedOperation);
            var i = advancedOperation.Multiply(100, 4);
            var j = advancedOperation.Division(100, 5);
            advancedOperation.GetFibbonacci(10);
            expertOperation.Exponentiation(2,5);
            expertOperation.Power(4, 16);
            expertOperation.Power2(4, 16);
            Console.ReadKey();
           
        }
    }
}
