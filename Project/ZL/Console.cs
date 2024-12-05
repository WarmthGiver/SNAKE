namespace ZL.Fixed
{
    public static class Console
    {
        public static void SetWindowSize(IntPoint intPoint)
        {
            System.Console.SetWindowSize(intPoint.X, intPoint.Y);
        }
    }
}