namespace ZL.CS.Graphics
{
    public abstract class Graphic
    {
        public readonly IntPoint pivot;

        public readonly int[,]? colorMap = null;

        protected Graphic(int[,] colorMap)
        {
            pivot = IntPoint.GetPivot(colorMap);

            this.colorMap = colorMap;
        }

        protected Graphic(int height, int width)
        {
            pivot = IntPoint.GetPivot(height, width);
        }

        public abstract void DrawRequest(Canvas canvas, IntPoint position, sbyte depth);
    }
}