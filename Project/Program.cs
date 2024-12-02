using System;
using System.Collections.Generic;
using System.Numerics;

namespace SNAKE
{
    internal class Program
    {
        protected abstract class Scene
        {
            public readonly int width = 65;
            public readonly int height = 33;

            protected Scene(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public abstract void Loop();
        }

        private class MainMenuScene : Scene
        {
            public MainMenuScene(int width, int height) : base(width, height)
            {
                Sprite sprite = new(
                [
                    "#################################################################\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                  ###  #   #  ###  #   # #####                 #\n",
                    "#                 #     ##  # #   # #  #  #                     #\n",
                    "#                  ###  # # # ##### ###   #####                 #\n",
                    "#                     # #  ## #   # #  #  #                     #\n",
                    "#                  ###  #   # #   # #   # #####                 #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                             START                             #\n",
                    "#                                                               #\n",
                    "#                             SCORE                             #\n",
                    "#                                                               #\n",
                    "#                             QUIT                              #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#                                                               #\n",
                    "#################################################################"
                ]);
            }

            public override void Loop()
            {
                int cursorX = 28;
                int cursorY = 23;

                Console.SetWindowSize(width, height);

                while (true)
                {
                    Console.Clear();

                    Console.Write("#################################################################\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                  ###  #   #  ###  #   # #####                 #\n");
                    Console.Write("#                 #     ##  # #   # #  #  #                     #\n");
                    Console.Write("#                  ###  # # # ##### ###   #####                 #\n");
                    Console.Write("#                     # #  ## #   # #  #  #                     #\n");
                    Console.Write("#                  ###  #   # #   # #   # #####                 #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                             START                             #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                             SCORE                             #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                             QUIT                              #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#################################################################");



                    var keyInfo = Console.ReadKey();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.W:

                        case ConsoleKey.UpArrow:

                            break;

                        case ConsoleKey.S:

                        case ConsoleKey.DownArrow:

                            break;

                        case ConsoleKey.Enter:

                            break;
                    }
                }
            }
        }

        private enum UIState
        {
            enabled,
            disabled,
            selected,
        }

        public class Sprite
        {
            public readonly int[] alpha;
            public readonly string[] texts;

            public readonly int width = 0;
            public readonly int height;

            public Sprite(string[] texts)
            {
                this.texts = texts;

                for (int i = 0; i < texts.Length; ++i)
                {
                    for (int j = alpha[i]; j < texts.Length; ++j)
                    {

                    }
                }

                foreach (var text in texts)
                {
                    if (width < text.Length)
                    {
                        width = text.Length;
                    }
                }
            }

            public void Draw()
            {

            }
        }

        protected abstract class GameObject
        {
            public Vector2 position;

            protected readonly Sprite[] sprites;

            protected ConsoleColor color;

            public abstract void Draw();
        }

        protected abstract class UI
        {
            protected readonly Vector2 position;
            protected readonly string text;
            protected ConsoleColor color;

            public void Draw()
            {

            }
        }

        private class Button
        {
            public readonly Vector2 position;

            public readonly Dictionary<UIState, UI> texts;

            public void Draw()
            {

            }
        }

        private enum SceneType
        {
            MainMenu,
            Level,
            GameOver,
            Score,
        }

        private static Dictionary<SceneType, Scene> scenes;

        private static void Main(string[] args)
        {
            scenes = new Dictionary<SceneType, Scene>()
            {
                { SceneType.MainMenu, new Scene(65, 33) },
                { SceneType.MainMenu, new Scene(65, 33) },
                { SceneType.MainMenu, new Scene(65, 33) },
                { SceneType.MainMenu, new Scene(65, 33) },
            };
        }

        private static void LoadScene(Scene sceneInfo)
        {
            Console.SetWindowSize(sceneInfo.width, sceneInfo.height);
        }

        private class Snake
        {

        }
    }
}