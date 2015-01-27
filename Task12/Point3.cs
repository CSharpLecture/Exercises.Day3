using System;

namespace CsharpSolutions.Exercises.Task12
{
    //The structure
    struct Point3
    {
        //Its fields
        float x;
        float y;
        float z;

        //Another constructor (takes already the fields)
        public Point3 (float x, float y, float z)
	    {
            this.x = x;
            this.y = y;
            this.z = z;
	    }

        //For the X field
        public float X
        {
            get { return x; }
            set
            {
                //Changing it!!
                Console.WriteLine("X changed from {0} to {1}.", x, value);
                x = value;
            }
        }

        public float Y
        {
            get { return y; }
            set
            {
                Console.WriteLine("Y changed from {0} to {1}.", y, value);
                y = value;
            }
        }

        public float Z
        {
            get { return z; }
            set
            {
                Console.WriteLine("Z changed from {0} to {1}.", z, value);
                z = value;
            }
        }

        //This is how operator overloading looks like
        public static Point3 operator +(Point3 a, Point3 b)
        {
            //Just return a new one
            return new Point3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Point3 operator -(Point3 a, Point3 b)
        {
            return new Point3(a.x - b.x, a.y - b.y, a.z - b.z);
        }
    }
}
