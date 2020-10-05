using System;

namespace BL
{
    public class BasicOperation : IBasicOperation
    {

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
           return x - y;
        }
    }
}
