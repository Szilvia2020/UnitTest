using BL;
using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new AdvancedOperation(new BasicOperation());
            var i = a.Multiply(100, 4);
            var j = a.Division(100, 5);
            Console.ReadKey();
        }
    }
}
