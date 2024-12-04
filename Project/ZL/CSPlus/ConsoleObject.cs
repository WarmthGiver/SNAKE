namespace ZL.CSPlus
{
    public abstract class ConsoleObject
    {
        public bool isEnabled = true;

        public virtual void SetEnabled(bool value)
        {
            isEnabled = value;
        }

        public void Call()
        {
            if (isEnabled)
            {
                _Call();
            }
        }

        protected abstract void _Call();
    }
}