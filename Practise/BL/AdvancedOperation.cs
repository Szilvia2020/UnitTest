using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class AdvancedOperation : IAdvancedOperation
    {
        
        private IBasicOperation BasicOperation { get; set; }
        public AdvancedOperation(IBasicOperation basicOperation)
        {
            BasicOperation = basicOperation;
           // BasicOperation = basicOperation;
        }

        public int Division(int x, int y)
        {
            int cnt = 0;
            int size = x;
            for (int i = 0; i < size; i++)
            {
                if (x >= y)
                {
                    x = BasicOperation.Subtraction(x, y);
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            return cnt;
        }

        public int Multiply(int x, int y)
        {
            var ret = 0;
            for (int i = 0; i < y; i++)
            {
                ret = BasicOperation.Add(ret, x);
            }
            return ret;
        }

        public int GetFibbonacci(int x)
        {
            var first = 1;
            var second = 1;
            for (int i = 2; i < x; i++)
            {
                second = BasicOperation.Add(first, second);
                first = BasicOperation.Subtraction(second, first);
                Console.WriteLine(second);
            }
            return second;
        }
    }
}
