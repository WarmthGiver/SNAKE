using System.Collections.Generic;
using ZL.CS.Graphics;

namespace ZL.CS
{
    public sealed class SceneObject : Object
    {
        public readonly string name;

        public readonly Scene scene;
        public IntPoint position;
        public sbyte depth;

        private List<Component> components = new();

        public Canvas canvas;
        private SceneObject? parnet = null;
        private List<SceneObject> children = new();

        public SceneObject(string name, Canvas canvas, IntPoint position, sbyte depth = 0)
        {
            this.name = name;

            this.canvas = canvas;
            this.position = position;
            this.depth = depth;
        }

        protected override void Update()
        {
            foreach (Component component in components)
            {
                component.CallUpdate();
            }
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
        }
    }
}