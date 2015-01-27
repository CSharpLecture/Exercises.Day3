using System;

namespace CsharpSolutions.Exercises.Task13
{
    //Abstract class
    abstract class Vehicle
    {
        //protected variable
        protected int tires;

        //Get-Property for the variable
        public int Tire
        {
            get { return tires; }
        }

        //Some abstract methods
        public abstract void Accelerate();

        public abstract void Brake();

        //... and a virtual one!
        public virtual void Drive()
        {
            Console.WriteLine("Driving the vehicle!");
        }
    }
}
