namespace ZL.CSPlus
{
    public abstract class ConsoleGraphic
    {
        protected readonly int[,]? colorMap;

        protected readonly IntPoint offset;

        protected ConsoleGraphic(int[,] colorMap)
        {
            this.colorMap = colorMap;

            offset = IntPoint.GetOffset(colorMap);
        }

        public abstract void Draw(IntPoint position);
    }
}