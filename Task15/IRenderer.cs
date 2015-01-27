using System;

namespace CsharpSolutions.Exercises.Task15
{
    interface IRenderer
    {
        void Start();

        void Finish();

        void DrawAxis(Axis axis);

        void DrawSeries(Series serie);

        void DrawTitle(String Title);
    }
}
