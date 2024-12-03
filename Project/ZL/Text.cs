namespace ZL
{
    public sealed class Text : Graphic
    {
        private readonly string[] strings;

        public Text(int[,] colorMap, string[] strings) : base(colorMap, Coord.GetOffset(strings))
        {
            this.strings = strings;
        }

        public override void Draw(Coord position)
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