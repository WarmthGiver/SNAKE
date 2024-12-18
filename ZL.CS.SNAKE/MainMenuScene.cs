﻿using System.Drawing;

using ZL.CS.ConsoleEngine;

using ZL.CS.ConsoleEngine.UI;

using ZL.CS.Graphics;

namespace ZL.CS.SNAKE
{
    internal sealed class MainMenuScene : Scene
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

        internal MainMenuScene() : base(new(33, 65), 1)
        {
            Canvas canvas;

            SceneObject sceneObject;

            Image image;

            Text text;

            Button button;

            #region Canvas

            canvas = new Canvas(size);

            canvases[0] = canvas;

            #endregion

            #region Background

            sceneObject = new("Background", canvas, new(0, 0), 0);

            sceneObjects.Add(sceneObject);

            image = new(sceneObject);

            image.graphic = ResourceManager.LoadBackground(BackgroundName.MainFrame);

            sceneObject.AddComponent(image);

            #endregion
            
            #region Logo

            sceneObject = new("Logo", canvas, new(0, 0), 0);

            sceneObject.AddComponent(image);

            sceneObjects.Add(sceneObject);

            image = new(sceneObject);

            image.graphic = ResourceManager.LoadBackground(BackgroundName.MainLogo);

            sceneObject.AddComponent(image);

            #endregion

            #region Start Button

            sceneObject = new("Start Button", canvas, new(7, 0), 0);
            sceneObjects.Add(sceneObject);

            text = new(sceneObject);
            text.graphic = new(new byte[1, 9] {{15,15,15,15,15,15,15,15,15}}, "  START  ");
            sceneObject.AddComponent(text);

            button = new(sceneObject);
            button.text = text;
            sceneObject.AddComponent(button);

            #endregion

            #region Score Button

            sceneObject = new("Score Button", canvas, new(9, 0), 0);

            sceneObjects.Add(sceneObject);

            text = new(sceneObject);

            text.graphic = new(new byte[1, 9] {{15,15,15,15,15,15,15,15,15}}, "  SCORE  ");

            sceneObject.AddComponent(text);

            button = new(sceneObject);

            button.text = text;

            sceneObject.AddComponent(button);

            #endregion
        }
    }
}