namespace CsharpSolutions.Exercises.Task15
{
    struct DataPoint
    {
        double x;
        double y;

        public DataPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }
    }
}
