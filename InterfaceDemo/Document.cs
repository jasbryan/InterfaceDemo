using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Document : IStorable
    {
        public void Read()
        {
            Console.WriteLine("We like to read from the document");
        }

        public void Write(object obj)
        {
            Console.WriteLine("We like to write to the document");
        }

        public void Print()
        {
            Console.WriteLine("Executing Dpcument print method");
        }

        public int Status { get; set; }
    }
}
