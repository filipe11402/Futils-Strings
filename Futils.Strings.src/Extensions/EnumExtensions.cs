using System;

namespace Futils.Strings.src.Extensions
{
    public static class EnumExtensions<T>
    {
        public static T GetEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
