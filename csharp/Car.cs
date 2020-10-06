using System;

namespace csharp
{
    public class Car
    {
        // the state of the car 
        public string petName;
        public int currentSpeed;

        public Car()
        {
            petName = "Chuck";
            currentSpeed = 10;
        }
        
        // The functionality of the car 
        // Using the expression bodied member syntax introduced in C#
        public void PrintState() 
            => Console.WriteLine("{0} is going {1} MPH.", petName, currentSpeed);

        public void SpeedUp(int delta)
            => currentSpeed += delta;
    }
}