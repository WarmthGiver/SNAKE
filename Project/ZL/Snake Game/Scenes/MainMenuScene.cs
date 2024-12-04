using System.Collections;

using ZL.CSPlus;
using ZL.Engine;

namespace ZL.SnakeGame
{
    public sealed partial class SnakeGame : Application<SnakeGame>
    {
        public class MainMenuScene : Scene
        {
            public MainMenuScene(int height, int width) : base(height, width)
            {
                SceneObject sceneObject;

                Image image;

                Text text;

                Button button;

                #region Background

                sceneObject = new("Background", pivot);

                image = new(sceneObject);

                image.consoleBG = ResourceManager.LoadConsoleBG(ConsoleBGName.MainFrame);

                sceneObject.AddComponent(image);

                sceneObjects.Add(sceneObject);

                #endregion

                #region Logo

                sceneObject = new("Logo", pivot);

                image = new(sceneObject);

                image.consoleBG = ResourceManager.LoadConsoleBG(ConsoleBGName.MainLogo);

                sceneObject.AddComponent(image);

                sceneObjects.Add(sceneObject);

                #endregion

                #region Start Button

                sceneObject = new("Start Button", new(35, 23));

                text = new(sceneObject);

                text.consoleFG = new(new int[1,9] {{15,15,15,15,15,15,15,15,15}},"  START  ");

                sceneObject.AddComponent(text);

                button = new(sceneObject);

                button.text = text;

                sceneObject.AddComponent(button);

                sceneObjects.Add(sceneObject);

                #endregion
            }

            public override void Start()
            {
                StartRoutine(Loop());
            }

            protected override IEnumerator Loop()
            {
                int cursorX = 35;
                int cursorY = 23;

                while (true)
                {
                    Console.SetWindowSize(width, height);

                    Draw();

                    yield return null;

                    //14, 18
                    
                    /*Console.Clear();

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
                    Console.Write("#                              QUIT                             #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#                                                               #\n");
                    Console.Write("#################################################################");

                    Console.SetCursorPosition(cursorX, cursorY);

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
                    */
                }
            }
        }
    }
}