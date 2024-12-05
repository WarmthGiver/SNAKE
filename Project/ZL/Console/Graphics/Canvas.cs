using System;

namespace ZL.CS.Graphics
{
    public sealed class Canvas
    {
        private readonly IntPoint size;
        private readonly IntPoint pivot;

        private readonly sbyte maxDepth;
        private readonly sbyte[,] depthMap;

        private readonly int[,] backgroundColorMap;

        private readonly int[,] foregroundColorMap;
        private readonly char[,] foregroundTextMap;

        public Canvas(IntPoint size, sbyte maxDepth = sbyte.MaxValue)
        {
            this.size = size;
            pivot = size.GetPivot();

            this.maxDepth = maxDepth;
            depthMap = new sbyte[size.Y, size.X];

            backgroundColorMap = new int[size.Y, size.X];

            foregroundColorMap = new int[size.Y, size.X];
            foregroundTextMap = new char[size.Y, size.X];

            Clear();
        }

        public void Clear()
        {
            depthMap.Fill(maxDepth);

            backgroundColorMap.Fill(-1);

            foregroundColorMap.Fill(15);
            foregroundTextMap.Fill(' ');
        }

        internal void Request(Background background, IntPoint position, sbyte depth)
        {
            var colorMap = background.colorMap;

            position.Y += pivot.Y;
            position.X += pivot.X;

            position.Y -= background.pivot.Y;
            position.X -= background.pivot.X;

            int positionY = position.Y;
            int positionX = position.X;

            for (int y = 0; y < colorMap.GetLength(0); ++y)
            {
                position.Y = positionY + y;

                for (int x = 0; x < colorMap.GetLength(1); ++x)
                {
                    position.X = positionX + x;

                    if (position.X < 0 || position.Y < 0)
                    {
                        continue;
                    }

                    if (depthMap.Get(position) < depth)
                    {
                        continue;
                    }

                    if (colorMap[y, x] != -1)
                    {
                        backgroundColorMap.Set(position, colorMap[y, x]);

                        foregroundTextMap.Set(position, ' ');
                    }
                }
            }
        }

        internal void Request(Foreground foreground, IntPoint position, sbyte depth)
        {
            var colorMap = foreground.colorMap;
            var textMap = foreground.textMap;

            position.Y += pivot.Y;
            position.X += pivot.X;

            position.Y -= foreground.pivot.Y;
            position.X -= foreground.pivot.X;

            int positionY = position.Y;
            int positionX = position.X;

            for (int y = 0; y < textMap.Length; ++y)
            {
                position.Y = positionY + y;

                for (int x = 0; x < textMap[y].Length; ++x)
                {
                    position.X = positionX + x;

                    if (position.X < 0 || position.Y < 0)
                    {
                        continue;
                    }

                    if (depthMap.Get(position) < depth)
                    {
                        continue;
                    }

                    if (colorMap != null)
                    {
                        foregroundColorMap.Set(position, colorMap[y, x]);
                    }
                    foregroundTextMap.Set(position, textMap[y][x]);
                }
            }
        }

        public void Draw()
        {
            Fixed.Console.SetWindowSize(size);

            for (int y = 0; y < size.Y; ++y)
            {
                for (int x = 0; x < size.X; ++x)
                {
                    Console.SetCursorPosition(x, y);

                    if (backgroundColorMap[y, x] != -1)
                    {
                        Console.BackgroundColor = (ConsoleColor)backgroundColorMap[y, x];
                    }

                    Console.ForegroundColor = (ConsoleColor)foregroundColorMap[y, x];
                    Console.Write(foregroundTextMap[y, x]);

                    Console.ResetColor();
                }
            }
        }
    }
}