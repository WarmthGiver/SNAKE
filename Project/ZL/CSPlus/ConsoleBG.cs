namespace ZL.CSPlus
{
    /// <summary>
    /// Console Background
    /// </summary>
    public sealed class ConsoleBG : ConsoleGraphic
    {
        public ConsoleBG(int[,] colorMap) : base(colorMap) { }

        public override void Draw(IntPoint position)
        {
            position.Y -= offset.Y;
            position.X -= offset.X;

            for (int y = 0; y < colorMap.GetLength(0); ++y)
            {
                for (int x = 0; x < colorMap.GetLength(1); ++x)
                {
                    Console.SetCursorPosition(position.X + x, position.Y + y);

                    if (colorMap[y, x] != -1)
                    {
                        Console.BackgroundColor = (ConsoleColor)colorMap[y, x];
                        Console.Write(' ');
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}