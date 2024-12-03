namespace ZL
{
    public abstract class Graphic
    {
        protected readonly int[,]? colorMap;

        protected readonly Coord offset;

        protected Graphic(int[,] colorMap, Coord offset)
        {
            this.colorMap = colorMap;

            this.offset = offset;
        }

        public abstract void Draw(Coord position);
    }
}