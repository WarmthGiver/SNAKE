namespace ZL.CSPlus
{
    public sealed class SceneObject : ConsoleObject
    {
        public readonly string name;

        public IntPoint position;

        private List<Component> components = new();

        private SceneObject? parnet = null;

        private List<SceneObject> children = new();

        public SceneObject(string name, IntPoint position)
        {
            this.name = name;

            this.position = position;
        }

        protected override void _Call()
        {
            foreach (Component component in components)
            {
                component.Call();
            }
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
        }
    }
}