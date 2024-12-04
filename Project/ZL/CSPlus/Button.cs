namespace ZL.CSPlus
{
    public sealed class Button : Selectable
    {
        public Image? image = null;
        public Text? text = null;

        public Button(SceneObject sceneObject) : base(sceneObject) { }

        protected override void _Call()
        {
            image?.Call();
            text?.Call();
        }
    }
}