namespace ZL
{
    public struct IntPoint
    {
        public int Y { get; set; }
        public int X { get; set; }

        public static readonly IntPoint zero = new(0, 0);

        public IntPoint(int y, int x)
        {
            Y = y;
            X = x;
        }

        public static IntPoint GetPivot(int[,] map)
        {
            return GetPivot(map.GetLength(0), map.GetLength(1));
        }

        public static IntPoint GetPivot(int height, int width)
        {
            return new IntPoint(height, width).GetPivot();
        }

        public IntPoint GetPivot()
        {
            return new(Y >> 1, X >> 1);
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