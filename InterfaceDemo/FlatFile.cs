using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class FlatFile : IStorable, ICompressable
    {
        public void Compress()
        {
            Console.WriteLine("Executing FlatFile compress method");
        }

        public void Decomporess()
        {
            Console.WriteLine("Executing FlatFile decompress method");
        }

        void ICompressable.Print()
        {
            Console.WriteLine("Executing FlatFile compressable print method");
        }

        public void Print()
        {
            Console.WriteLine("Executing FlatFile storable print method");
        }

        public void Read()
        {
            Console.WriteLine("We like to read from the FlatFile");
        }

        public void Write(object obj)
        {
            Console.WriteLine("We like to write to the FlatFile");
        }
    }
}
