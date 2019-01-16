using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var box1 = new Box
            {
                Width = 5,
                Height = 10.2,
                Length = 25.4
            };

            var box2 = new Box
            {
                Width = 5,
                Height = 10.2,
                Length = 25.4
            };

            var box3 = box1 + box2;

            Console.WriteLine($"Box3 length:{box3.Length}, Width:{box3.Width}, Height:{box3.Height}");
        }
    }
}
