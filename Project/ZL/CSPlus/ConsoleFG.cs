namespace ZL.CSPlus
{
    /// <summary>
    /// Console Foreground
    /// </summary>
    public sealed class ConsoleFG : ConsoleGraphic
    {
        private readonly string[] strings;

        public ConsoleFG(int[,] colorMap, params string[] strings) : base(colorMap)
        {
            this.strings = strings;
        }

        public override void Draw(IntPoint position)
        {
            position.X -= offset.X;
            position.Y -= offset.Y;

            for (int y = 0; y < strings.Length; ++y)
            {
                for (int x = 0; x < strings.Length; ++x)
                {
                    Console.SetCursorPosition(position.X + x, position.Y + y);

                    if (colorMap != null && colorMap[y, x] != -1)
                    {
                        Console.ForegroundColor = (ConsoleColor)colorMap[y, x];
                    }

                    Console.Write(strings[y][x]);
                    Console.ResetColor();
                }
            }
        }
    }
}