using System;

namespace DelegateDemoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = new Func<int,int>(Calculator.AddNumber);
            Console.WriteLine(n1(20));

            var n2 = new Func<int,int>(Square);
            Console.WriteLine(n2(34));

            var c1 = new Car(10, 100);
            var c2 = new Car();

            c1.RegisterWithCarEngine(Screen);
            c1.RegisterWithCarEngine(AnotherScreen);

            for(var i=0;i<6;i++)
            {
                c1.Accelerate(20);
            }

            c1.UnRegisterWithCarEngine(AnotherScreen);
            for (var i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }


        }

        public static void Screen(string msg)
        {
            Console.WriteLine($"here is the Engine message: {msg}");
        }

        public static void AnotherScreen(string msg)
        {
            Console.WriteLine(msg.ToUpper());
        }

        static int Square(int num) => num * num;

    }
}
