using System;
using System.Collections.Generic;

namespace CsharpSolutions.Exercises.Task15
{
    class Plot
    {
        List<Series> series;
        Axis x;
        Axis y;

        public Plot()
        {
            x = new Axis
            {
                Type = AxisType.Horizontal,
                Label = "x"
            };
            y = new Axis
            {
                Type = AxisType.Vertical,
                Label = "y"
            };
            series = new List<Series>();
        }

        public Plot(IEnumerable<Series> existingSeries)
        {
            series = new List<Series>(existingSeries);
        }

        public String Title
        {
            get;
            set;
        }

        public List<Series> Series
        {
            get { return series; }
        }

        public void Draw(IRenderer renderer)
        {
            renderer.Start();
            renderer.DrawAxis(x);
            renderer.DrawAxis(y);

            foreach (var serie in series)
                renderer.DrawSeries(serie);

            renderer.DrawTitle(Title);
            renderer.Finish();
        }
    }
}
