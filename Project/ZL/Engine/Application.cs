using System.Collections;

namespace ZL.Engine
{
    public abstract partial class Application<TApplication>

        where TApplication : Application<TApplication>
    {
        private static State state = State.Running;

        private static int timeScale = 100;

        private static Dictionary<IEnumerator, IEnumerator> routines = new();

        private static Stack<IEnumerator> finishedRoutines = new();

        public void Run()
        {
            Console.CursorVisible = false;

            Start();

            Update();
        }

        protected abstract void Start();

        protected void Update()
        {
            while (state != State.Terminated)
            {
                if (state == State.Running)
                {
                    if (routines.Count > 0)
                    {
                        foreach (var routine in routines.Values)
                        {
                            routine.MoveNext();
                        }

                        RemoveFinisedRoutines();
                    }
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
            var _routnie = Routine(routine);

            routines.Add(routine, _routnie);
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
            state = State.Terminated;

            Console.CursorVisible = true;
        }

        public enum State
        {
            Terminated,
            Running,
            Paused,
        }
    }
}