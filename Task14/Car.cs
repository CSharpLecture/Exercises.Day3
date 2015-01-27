using System;

namespace CsharpSolutions.Exercises.Task14
{
    //Deriving from vehicle
    class Car : Vehicle
    {
        //Automatic property
        public int Gears
        {
            get;
            set;
        }

        //standard constructor
        public Car()
        {
            //Set the value of tires to 4
            tires = 4;
        }

        //Copy constructor
        public Car(Car car)
            : base(car)
        {
            this.Gears = car.Gears;
        }

        public override bool Equals(object obj)
        {
            if (obj is Car)
            {
                var other = (Car)obj;
                return other.tires == this.tires && other.Gears == this.Gears;
            }

            return false;
        }

        public override void Accelerate()
        {
            Console.WriteLine("The car is accelerating");
        }

        public override void Brake()
        {
            Console.WriteLine("The car is braking");
        }
    }
}
