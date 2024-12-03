using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ZL;

namespace SNAKE
{
    internal class MainMenuScene : Scene
    {
        private Sprite background;

        private Button startButton;

        private Button ScoreButton;

        private Button quitButton;

        public MainMenuScene(int height, int width) : base(height, width)
        {
            background = Snake.spriteManager.Get(SpriteName.MainMenu_Background);

            startButton = new Button(new(23, 35), );
        }

        public override IEnumerator Loop()
        {
            int cursorX = 35;
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
            }
        }
    }
}