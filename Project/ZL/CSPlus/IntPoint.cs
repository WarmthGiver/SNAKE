namespace ZL.CSPlus
{
    public struct IntPoint
    {
        public int Y { get; set; }
        public int X { get; set; }

        public IntPoint(int y, int x)
        {
            Y = y;
            X = x;
        }

        public static IntPoint GetOffset<T>(T[,] strings)
        {
            int y = strings.GetLength(0) >> 1;
            int x = strings.GetLength(1) >> 1;

            return new IntPoint(y, x);
        }

        public static IntPoint GetOffset(string[] strings)
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

            return new IntPoint(y, x);
        }
    }
}