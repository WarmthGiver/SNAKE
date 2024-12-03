namespace ZL
{
    public abstract class GameObject
    {
        protected bool enabled;

        protected Coord position;

        protected GameObject(Coord position)
        {
            this.position = position;
        }

        public abstract void Draw();
    }
}