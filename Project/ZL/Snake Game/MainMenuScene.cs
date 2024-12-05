using System.Collections;

using ZL.CS;
using ZL.CS.Graphics;
using ZL.CS.UI;

namespace ZL.SnakeGame
{
    internal class MainMenuScene : Scene
    {
        internal MainMenuScene(IntPoint size) : base(size)
        {
            /*
            #################################################################
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                  ###  #   #  ###  #   # #####                 #
            #                 #     ##  # #   # #  #  #                     #
            #                  ###  # # # ##### ###   #####                 #
            #                     # #  ## #   # #  #  #                     #
            #                  ###  #   # #   # #   # #####                 #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #                             START                             #
            #                                                               #
            #                             SCORE                             #
            #                                                               #
            #                              QUIT                             #
            #                                                               #
            #                                                               #
            #                                                               #
            #                                                               #
            #################################################################
            */

            Canvas canvas;

            SceneObject sceneObject;

            Image image;
            Text text;
            Button button;

            canvas = new Canvas(size);
            AddCanvas(canvas);

            #region Background

            sceneObject = new("Background", canvas, IntPoint.zero);
            sceneObjects.Add(sceneObject);

            image = new(sceneObject);
            image.graphic = ResourceManager.LoadBackground(BackgroundName.MainFrame);
            sceneObject.AddComponent(image);

            #endregion
            
            #region Logo

            sceneObject = new("Logo", canvas, IntPoint.zero);
            sceneObject.AddComponent(image);
            sceneObjects.Add(sceneObject);

            image = new(sceneObject);
            image.graphic = ResourceManager.LoadBackground(BackgroundName.MainLogo);
            sceneObject.AddComponent(image);

            #endregion

            #region Start Button

            sceneObject = new("Start Button", canvas, new(7, 0));
            sceneObjects.Add(sceneObject);

            text = new(sceneObject);
            text.graphic = new(new int[1, 9] {{15,15,15,15,15,15,15,15,15}}, "  START  ");
            sceneObject.AddComponent(text);

            button = new(sceneObject);
            button.text = text;
            sceneObject.AddComponent(button);

            #endregion

            #region Score Button

            sceneObject = new("Score Button", canvas, new(9, 0));
            sceneObjects.Add(sceneObject);

            text = new(sceneObject);
            text.graphic = new(new int[1, 9] { { 15, 15, 15, 15, 15, 15, 15, 15, 15 } }, "  SCORE  ");
            sceneObject.AddComponent(text);

            button = new(sceneObject);
            button.text = text;
            sceneObject.AddComponent(button);

            #endregion
        }
    }
}