using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class SubtitleOccurenceDescriptionExtensions
    {
        public static T SetEndSecond<T>(this T entity, float value)
            where T : SubtitleOccurenceDescription
        {
            entity.SetField("endSecond", value);
            return entity;
        }

        public static T SetLocKey<T>(this T entity, string value)
            where T : SubtitleOccurenceDescription
        {
            entity.SetField("locKey", value);
            return entity;
        }

        public static T SetStartSecond<T>(this T entity, float value)
            where T : SubtitleOccurenceDescription
        {
            entity.SetField("startSecond", value);
            return entity;
        }
    }
}