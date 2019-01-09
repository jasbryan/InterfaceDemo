using System;
using System.Collections.Generic;
using System.Text;

namespace IautoDemo
{
    class Train : Auto
    {
        public override void OpenDoor()
        {
            Console.WriteLine("The door opens for the Train");
        }
    }
}
