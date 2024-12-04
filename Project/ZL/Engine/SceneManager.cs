using ZL.CSPlus;

namespace ZL.Engine
{
    public abstract partial class Application<TApplication>

        where TApplication : Application<TApplication>
    {
        public static class SceneManager
        {
            public static Dictionary<string, Scene> scenes = new();

            public static void AddScene<TEnum>(TEnum name, Scene scene)

                where TEnum : Enum
            {
                scenes.Add(name, scene);
            }

            public static void AddScene(string name, Scene scene)
            {
                scenes.Add(name, scene);
            }

            public static Scene GetScene<TEnum>(TEnum name)

                where TEnum : Enum
            {
                return scenes.Get(name);
            }

            public static Scene GetScene(string name)
            {
                return scenes.Get(name);
            }
        }
    }
}