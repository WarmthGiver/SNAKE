namespace ZL
{
    public static class ArrayExtension
    {
        public static T Get<T>(this T[,] array, IntPoint point)
        {
            return array[point.Y, point.X];
        }

        public static void Set<T>(this T[,] array, IntPoint point, T value)
        {
            array[point.Y, point.X] = value;
        }

        public static void Fill<T>(this T[,] array, T value)
        {
            for (int y = array.GetLength(0); --y > 0;)
            {
                for (int x = array.GetLength(1); --x > 0;)
                {
                    array[y, x] = value;
                }
            }
        }
    }
}