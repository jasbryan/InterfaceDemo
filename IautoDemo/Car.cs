using System;
using System.Collections.Generic;
using System.Text;

namespace IautoDemo
{
    class Car : Auto
    {
        public override void OpenDoor()
        {
            Console.WriteLine("The door opens for the car class");
        }

        public void ShutDoor()
        {
            Console.WriteLine("The door opens for the car class");
        }

    }
}
