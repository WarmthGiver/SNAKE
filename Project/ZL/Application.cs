using System.Collections;

namespace ZL
{
    public abstract class Application
    {
        private State state = State.Running;

        public int timeScale = 100;

        private static Dictionary<IEnumerator, IEnumerator> routines = new();

        private static Stack<IEnumerator> finishedRoutines = new();

        public static Dictionary<string, Sprite> spriteManager = new();

        public static Dictionary<string, Scene> sceneManager = new();

        public void Run()
        {
            Load();

            Start();

            Update();
        }

        protected abstract void Load();

        protected abstract void Start();

        protected void Update()
        {
            while (state != State.Quit)
            {
                if (routines.Count > 0)
                {
                    foreach (IEnumerator routine in routines.Values)
                    {
                        routine.MoveNext();
                    }

                    RemoveFinisedRoutines();
                }

                Thread.Sleep(timeScale);
            }
        }

        private void RemoveFinisedRoutines()
        {
            foreach (IEnumerator routine in finishedRoutines)
            {
                routines.Remove(routine);
            }

            finishedRoutines.Clear();
        }

        public static void StartRoutine(IEnumerator routine)
        {
            IEnumerator a = Routine(routine);

            routines.Add(routine, a);
        }

        private static IEnumerator Routine(IEnumerator routine)
        {
            while (routine.MoveNext())
            {
                yield return null;
            }

            finishedRoutines.Push(routine);
        }

        public void Quit()
        {
            state = State.Quit;
        }

        public enum State
        {
            Running,
            Paused,
            Quit,
        }
    }
}