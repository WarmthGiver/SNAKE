using ZL.CSPlus;

namespace ZL.Engine
{
    public abstract partial class Application<TApplication>

        where TApplication : Application<TApplication>
    {
        public static class ResourceManager
        {
            public static Dictionary<string, ConsoleBG> consoleBGs = new();

            public static Dictionary<string, ConsoleFG> consoleFGs = new();

            public static void AddConsoleBG<TEnum>(TEnum name, ConsoleBG consoleBG)

                where TEnum : Enum
            {
                consoleBGs.Add(name, consoleBG);
            }

            public static void AddConsoleBG(string name, ConsoleBG consoleBG)
            {
                consoleBGs.Add(name, consoleBG);
            }

            public static ConsoleBG LoadConsoleBG<TEnum>(TEnum name)

                where TEnum : Enum
            {
                return consoleBGs.Get(name);
            }

            public static ConsoleBG LoadConsoleBG(string name)
            {
                return consoleBGs.Get(name);
            }

            public static void AddConsoleFG<TEnum>(TEnum name, ConsoleFG consoleFG)

                where TEnum : Enum
            {
                consoleFGs.Add(name, consoleFG);
            }

            public static void AddConsoleFG(string name, ConsoleFG consoleFG)
            {
                consoleFGs.Add(name, consoleFG);
            }

            public static ConsoleFG LoadConsoleFG<TEnum>(TEnum name)

                where TEnum : Enum
            {
                return consoleFGs.Get(name);
            }

            public static ConsoleFG LoadConsoleFG(string name)
            {
                return consoleFGs.Get(name);
            }
        }
    }
}