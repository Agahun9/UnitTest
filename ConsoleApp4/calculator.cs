using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {

        public int Div(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Qutient(int a, int b)
        {
            return a * b;
        }
    }
}
