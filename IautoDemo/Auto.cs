using System;
using System.Collections.Generic;
using System.Text;

namespace IautoDemo
{
    abstract class Auto : IAuto
    {
        public abstract void OpenDoor();

        public void Start()
        {
            Console.WriteLine("Abstract implement of Start");
        }
        public void Stop()
        {
            Console.WriteLine("Abstract implement of Stop");
        }
    }
}
