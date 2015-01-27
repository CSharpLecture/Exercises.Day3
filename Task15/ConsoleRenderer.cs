using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpSolutions.Exercises.Task15
{
    sealed class ConsoleRenderer : IRenderer
    {
        Char[][] buffer;
        static readonly ConsoleColor[] colors = new[] { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.White, ConsoleColor.DarkYellow, ConsoleColor.Cyan, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.DarkMagenta };

        readonly int height;
        readonly int width;
        int colorIndex = 0;

        public ConsoleRenderer()
        {
            try
            {
                height = Console.WindowHeight - 1;
                width = Console.WindowWidth - 1;
            }
            catch 
            {
                height = 30;
                width = 100;
            }
        }

        public void Start()
        {
            buffer = new Char[height][];

            for (var i = 0; i != buffer.Length; i++)
            {
                buffer[i] = new Char[width];

                for (int j = 0; j < width; j++)
                    buffer[i][j] = ' ';
            }
        }

        public void Finish()
        {
            for (int i = 0; i < buffer.Length; i++)
                Console.WriteLine(new String(buffer[i]));
        }

        public void DrawAxis(Axis axis)
        {
            if (axis.Type == AxisType.Horizontal)
            {
                var bar = ">".PadLeft(width, '-');
                SetHorizontalBuffer(0, height - 1, bar);
            }
            else
            {
                var bar = "^".PadRight(height - 1, '|');
                SetVerticalBuffer(0, 1, bar);
            }
        }

        public void DrawSeries(Series serie)
        {
            Console.ForegroundColor = colors[colorIndex];
            var minx = serie.MinX;
            var maxx = serie.MaxX;
            var miny = serie.MinY;
            var maxy = serie.MaxY;
            var dx = (maxx - minx) / (width - 1);
            var dy = (maxy - miny) / (height - 2);
            var points = serie.Points.Select(point => new
            {
                i = (int)((point.X - minx) / dx),
                j = (int)((point.Y - miny) / dy)
            }).GroupBy(coord => coord.i).Select(group => group.Min(m => m.j)).ToArray();
            
            for (var i = 0; i != points.Length; i++)
            {
                var point = points[i];
                var symbol = '-';

                if (i == 0 && points.Length > 1)
                    symbol = GetSymbol(points[i + 1] - point);
                else if (i > 0)
                {
                    if (i < points.Length - 1)
                        symbol = GetSymbol(point - points[i - 1]);
                    else
                        symbol = GetSymbol(point - points[i - 1]);
                }

                SetPoint(i + 1, point, symbol);
            }

            colorIndex = (colorIndex + 1) % colors.Length;
        }

        private Char GetSymbol(int diff)
        {
            if (diff > 0)
                return '\\';
            else if (diff == 0)
                return '-';
            return '/';
        }

        public void DrawTitle(string Title)
        {
            SetHorizontalBuffer((width - Title.Length) / 2, 0, Title);
        }

        void SetPoint(double x, double y, char symbol)
        {
            buffer[(int)y][(int)x] = symbol;
        }

        void SetHorizontalBuffer(int i, int j, string text)
        {
            for (int k = 0; k < text.Length; k++)
                buffer[j][i + k] = text[k];
        }

        void SetVerticalBuffer(int i, int j, string text)
        {
            for (int k = 0; k < text.Length; k++)
                buffer[j + k][i] = text[k];
        }
    }
}
