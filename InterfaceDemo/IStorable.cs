using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    interface IStorable
    {
        void Read();

        void Write(object obj);

        void Print();
    }
}
