namespace ZL.CSPlus
{
    public sealed class Image : UI
    {
        public ConsoleBG? consoleBG = null;

        public Image(SceneObject consoleObject) : base(consoleObject) { }

        protected override void _Call()
        {
            consoleBG?.Draw(sceneObject.position);
        }
    }
}