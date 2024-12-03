using System.Collections;

namespace ZL
{
    public abstract class Scene
    {
        protected readonly int height;
        protected readonly int width;

        protected Scene(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public abstract IEnumerator Loop();
    }
}