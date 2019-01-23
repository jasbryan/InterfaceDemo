using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemoTwo
{
    class Car
    {
        public int CurrentSpeed { get; set; }

        public int MaxSpeed { get; set; } = 100;

        private bool isDead;

        public Car()
        {
                       
        }

        public Car(int currSpeed, int maxSpeed)
        {
            CurrentSpeed = currSpeed;
            MaxSpeed = maxSpeed;
        }

        //1 define delegate type
        //public delegate void CarEngineHandler(string msg);

        //2 define member variable
        private Action<string> listOfHandlers;

        //3 use delegate
        public void RegisterWithCarEngine(Action<string> methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(Action<string> methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (isDead)
            {
                listOfHandlers?.Invoke("Engine is dead");
            }
            else
            {
                CurrentSpeed += delta;
                //Is the car almost dead
                if (10 >= (MaxSpeed-CurrentSpeed) &&  CurrentSpeed < MaxSpeed)
                {
                    listOfHandlers?.Invoke("You are getting very close to max speed!!!!");
                }
                if(CurrentSpeed >= MaxSpeed)
                {
                    isDead = true;
                }else
                {
                    Console.WriteLine($"Currentspeed = {CurrentSpeed}");
                }
            }


        }




    }
}
