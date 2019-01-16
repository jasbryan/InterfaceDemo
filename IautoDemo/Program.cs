using System;

namespace IautoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Start();
            myCar.Stop();
            myCar.OpenDoor();

            var mySC = new SmartCar();
            mySC.OpenDoor();



        }
    }
}
