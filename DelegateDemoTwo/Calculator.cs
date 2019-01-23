using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemoTwo
{
    public delegate int NumberChanger(int number);

    class Calculator
    {
        public static int AddNumber(int num)
        {
            num += 10;
            return num;
        }



    }
}
