namespace ZL.CS.Graphics
{
    public sealed class Background : Graphic
    {
        public Background(int[,] colorMap) : base(colorMap) { }

        public override void DrawRequest(Canvas drawer, IntPoint position, sbyte depth)
        {
            drawer.Request(this, position, depth);
        }
    }
}