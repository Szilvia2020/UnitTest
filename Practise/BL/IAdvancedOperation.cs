using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface IAdvancedOperation
    {
        int Multiply(int x, int y);
        int Division(int x, int y);
        int GetFibbonacci(int x);
    }
}
