using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class ExpertOperation : IExpertOperation
    {
        IAdvancedOperation AdvancedOperation { get; }
        public ExpertOperation(IAdvancedOperation advancedOperation)
        {
            AdvancedOperation = advancedOperation;
        }

        public int Exponentiation(int x, int y)
        {
            var ret = x;
            for (int i = 1; i < y; i++)
            {
                ret = AdvancedOperation.Multiply(ret, x);
            }
            return ret;
        }

        public bool Power(int x, int y)
        {
            if(AdvancedOperation.Multiply(x,x) == y)
            {
                Console.WriteLine("Hatvány");
                return true;
            }
           else
            {
                Console.WriteLine("Nem hatvány");
                return false;
            }
        }

        public bool Power2(int x, int y)
        {
            if (Exponentiation(x, 2) == y)
            {
                Console.WriteLine("Hatvány");
                return true;
            }
            else
            {
                Console.WriteLine("Nem hatvány");
                return false;
            }
        }

    }
}
