using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpSolutions.Exercises.Task15
{
    class Series
    {
        List<DataPoint> points;

        public Series()
        {
            points = new List<DataPoint>();
        }

        public Series(IEnumerable<DataPoint> existingPoints)
        {
            points = new List<DataPoint>(existingPoints);
        }

        public String Name
        {
            get;
            set;
        }

        public String Color
        {
            get;
            set;
        }

        public List<DataPoint> Points
        {
            get { return points; }
        }

        public Double MaxX
        {
            get { return points.Max(m => m.X); }
        }

        public Double MinX
        {
            get { return points.Min(m => m.X); }
        }

        public Double MaxY
        {
            get { return points.Max(m => m.Y); }
        }

        public Double MinY
        {
            get { return points.Min(m => m.Y); }
        }
    }
}
