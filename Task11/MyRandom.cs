using System;

namespace CsharpSolutions.Exercises.Task11
{
    class MyRandom : Random
    {
        //Store another field for some arbitrary value
        int value;

        public override int Next()
        {
            //This is not so random any more (certainly different!)
            return value++;
        }

        public double MySample()
        {
            //Now we return the result of a call to Sample(), which is usually hidden
            return Sample();
        }
    }
}
