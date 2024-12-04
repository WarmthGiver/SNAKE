namespace ZL.CSPlus
{
    public sealed class Text : UI
    {
        public ConsoleFG? consoleFG = null;

        public Text(SceneObject consoleObject) : base(consoleObject) { }

        protected override void _Call()
        {
            consoleFG?.Draw(sceneObject.position);
        }
    }
}