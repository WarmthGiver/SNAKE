namespace ZL
{
    public static partial class DictionaryExtension
    {
        public static void Add<TEnum, TValue>(this Dictionary<string, TValue> instance, TEnum key, TValue value)

            where TEnum : Enum
        {
            instance.Add(key.ToString(), value);
        }

        public static TValue Get<TEnum, TValue>(this Dictionary<string, TValue> instance, TEnum key)

            where TEnum : Enum
        {
            return instance[key.ToString()];
        }
    }
}