namespace ZL
{
    public struct Coord
    {
        public int Y { get; set; }
        public int X { get; set; }

        public Coord(int y, int x)
        {
            Y = y;
            X = x;
        }

        public static Coord GetOffset<T>(T[,] strings)
        {
            int y = strings.GetLength(0);
            int x = strings.GetLength(1);

            return new Coord(y, x);
        }

        public static Coord GetOffset(string[] strings)
        {
            int y = strings.Length;
            int x = 0;

            for (int i = 0; i < y; ++i)
            {
                if (x < strings[i].Length)
                {
                    x = strings[i].Length;
                }
            }

            return new Coord(y, x);
        }
    }
}