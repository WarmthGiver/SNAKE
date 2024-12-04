using System.Collections;

using ZL.CSPlus;

namespace ZL.Engine
{
    public abstract partial class Application<TApplication>
        
        where TApplication : Application<TApplication>
    {
        public abstract class Scene
        {
            protected readonly int height;
            protected readonly int width;

            protected readonly IntPoint pivot;

            protected readonly List<SceneObject> sceneObjects = new();

            protected Scene(int height, int width)
            {
                this.height = height;
                this.width = width;

                pivot.Y = height >> 1;
                pivot.X = width >> 1;
            }

            public abstract void Start();

            protected abstract IEnumerator Loop();

            protected void Draw()
            {
                foreach (var sceneObject in sceneObjects)
                {
                    sceneObject.Call();
                }
            }
        }
    }
}