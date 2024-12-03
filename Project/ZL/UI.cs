namespace ZL
{
    public abstract class UI : GameObject
    {
        private readonly Navigation navigation;

        protected State state;

        protected UI(Coord position, Navigation navigation) : base(position)
        {
            this.navigation = navigation;
        }

        public void Select(bool value)
        {
            if (value == true)
            {
                Navigation.selected?.Select(false);

                Navigation.selected = this;

                state = State.selected;
            }
            else
            {
                state = enabled ? State.enabled : State.disabled;
            }
        }

        public sealed class Navigation
        {
            public static UI? selected = null;

            private readonly UI? up;
            private readonly UI? down;
            private readonly UI? left;
            private readonly UI? right;

            public Navigation(UI? up, UI? down, UI? left, UI? right)
            {
                this.up = up;
                this.down = down;
                this.left = left;
                this.right = right;
            }

            public static void Move(ConsoleKey key)
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow:

                        selected?.navigation.up?.Select(true);

                        break;

                    case ConsoleKey.DownArrow:

                        selected?.navigation.down?.Select(true);

                        break;

                    case ConsoleKey.LeftArrow:

                        selected?.navigation.left?.Select(true);

                        break;

                    case ConsoleKey.RightArrow:

                        selected?.navigation.right?.Select(true);

                        break;
                }
            }
        }

        public enum State
        {
            enabled,
            disabled,
            selected,
        }
    }
}