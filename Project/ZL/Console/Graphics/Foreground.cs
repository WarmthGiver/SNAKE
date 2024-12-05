namespace ZL.CS.Graphics
{
    public sealed class Foreground : Graphic
    {
        public readonly string[] textMap;

        public Foreground(int[,] colorMap, params string[] textMap) : base(colorMap)
        {
            this.textMap = textMap;
        }

        public Foreground(params string[] textMap) : base(textMap.Length, textMap[0].Length)
        {
            this.textMap = textMap;
        }

        public override void DrawRequest(Canvas drawer, IntPoint position, sbyte depth)
        {
            drawer.Request(this, position, depth);
        }
    }
}