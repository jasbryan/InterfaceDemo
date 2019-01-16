using System;
using System.Collections.Generic;
using System.Text;

namespace IautoDemo
{
    class SmartCar : Car
    {
        public override void OpenDoor()
        {
            Console.WriteLine("This is the smatrcar open door.");

        }

        public new void ShutDoor()
        {
            Console.WriteLine("This is the smatrcar close door.");
        }
    }
}
