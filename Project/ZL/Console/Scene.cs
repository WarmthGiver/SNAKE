using System.Collections;
using System.Collections.Generic;

using ZL.CS.Graphics;

namespace ZL.CS
{
    public abstract class Scene
    {
        protected readonly IntPoint size;
        protected readonly IntPoint pivot;

        private readonly List<Canvas> canvases = new();

        protected readonly List<SceneObject> sceneObjects = new();

        protected Scene(IntPoint size)
        {
            this.size = size;
            pivot = size.GetPivot();
        }

        internal void Start<TApplication>(TApplication application)

            where TApplication : Application<TApplication>
        {
            application.StartRoutine(Loop());
        }

        protected IEnumerator Loop()
        {
            while (true)
            {
                CallUpdate();

                foreach (var canvas in canvases)
                {
                    canvas.Draw();
                }
                
                yield return null;
            }
        }

        protected void CallUpdate()
        {
            foreach (var sceneObject in sceneObjects)
            {
                sceneObject.CallUpdate();
            }
        }

        protected void AddCanvas(Canvas canvas)
        {
            canvases.Add(canvas);
        }
    }
}