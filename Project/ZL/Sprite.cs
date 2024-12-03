namespace ZL
{
    public sealed class Sprite : Graphic
    {
        public Sprite(int[,] colorMap) : base(colorMap, Coord.GetOffset(colorMap)) { }

        public override void Draw(Coord position)
        {
            position.Y -= offset.Y;
            position.X -= offset.X;

            for (int y = 0; y < colorMap.Length; ++y)
            {
                for (int x = 0; x < colorMap.Length; ++x)
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