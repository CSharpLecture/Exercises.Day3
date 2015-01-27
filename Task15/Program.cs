using System;

namespace CsharpSolutions.Exercises.Task15
{
    class PlotSample
    {
        public static void Run()
        {
            var plot = new Plot();
            plot.Title = "My sample plot";
            var seriesA = new Series();
            var seriesB = new Series();
            seriesA.Name = "Sine";
            seriesA.Color = "red";

            for(var i = 0; i != 314; i++)
                seriesA.Points.Add(new DataPoint(i * 0.01, Math.Sin(i * 0.01)));

            plot.Series.Add(seriesA);
            seriesB.Name = "Cosine";
            seriesB.Color = "blue";

            for (var i = 0; i != 314; i++)
                seriesB.Points.Add(new DataPoint(i * 0.01, Math.Cos(i * 0.01)));

            plot.Series.Add(seriesB);

            plot.Draw(new ConsoleRenderer());
            Console.ReadLine();
        }
    }
}
